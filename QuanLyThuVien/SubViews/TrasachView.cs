using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyThuVien.BLL;
using QuanLyThuVien.DAL.Models;

namespace QuanLyThuVien.SubViews
{
    public partial class TrasachView : Form
    {
        private readonly MuonTraSach muonTraSach = new MuonTraSach();
        private readonly int maPM;
        private readonly int maSach;
        private readonly DateTime hanTra = DateTime.Today;
        private readonly DateTime ngayMuon = DateTime.Today;
        private List<QuyDinhPhat> dsQuyDinh = new List<QuyDinhPhat>();

        public TrasachView()
        {
            InitializeComponent();
            dtpNgayTraThucTe.Value = DateTime.Today;
            LoadQuyDinhPhat();
            CapNhatSoNgayTre();
        }

        public TrasachView(ChiTietMuonTraDTO dto) : this()
        {
            if (dto != null)
            {
                this.maPM = dto.MaPM;
                this.maSach = dto.MaSach;
                this.hanTra = dto.HanTra != default ? dto.HanTra : DateTime.Today;
                this.ngayMuon = dto.NgayMuon != default ? dto.NgayMuon : DateTime.Today;

                txtMaPM.Text = dto.MaPM.ToString();
                txtMaSV.Text = dto.MaSV + (string.IsNullOrWhiteSpace(dto.TenDocGia) ? "" : $" - {dto.TenDocGia}");
                txtMaSach.Text = dto.MaSach + (string.IsNullOrWhiteSpace(dto.TenSach) ? "" : $" - {dto.TenSach}");
                dtpNgayHenTra.Value = this.hanTra;

                CapNhatSoNgayTre();
            }
        }

        private void LoadQuyDinhPhat()
        {
            dsQuyDinh = muonTraSach.LayDanhSachQuyDinh();
            cboQuyDinhPhat.DataSource = null;
            cboQuyDinhPhat.DataSource = dsQuyDinh;
            cboQuyDinhPhat.DisplayMember = "TenQuyDinh";
            cboQuyDinhPhat.ValueMember = "MaQD";
        }

        private void CapNhatSoNgayTre()
        {
            int soNgayTre = Math.Max(0, (dtpNgayTraThucTe.Value.Date - dtpNgayHenTra.Value.Date).Days);
            lblSoNgayTre.Text = $"{soNgayTre} ngày";

            if (soNgayTre > 0)
            {
                lblSoNgayTre.ForeColor = Color.Red;
                chkCoViPham.Checked = true;

                // Tự động tìm quy định trễ hạn
                var qdTre = dsQuyDinh.FirstOrDefault(x => x.MaViPham == "TRE_HAN");
                if (qdTre != null)
                {
                    cboQuyDinhPhat.SelectedItem = qdTre;
                    decimal tien = soNgayTre * qdTre.MucPhat;
                    if (qdTre.TranPhat > 0 && tien > qdTre.TranPhat)
                    {
                        tien = qdTre.TranPhat;
                    }
                    txtTienPhat.Text = tien.ToString("0");
                    txtLyDo.Text = $"Trả sách quá hạn {soNgayTre} ngày.";
                }
            }
            else
            {
                lblSoNgayTre.ForeColor = Color.DarkGreen;
                if (!pnlPhat.Enabled)
                {
                    chkCoViPham.Checked = false;
                }
            }
        }

        private void dtpNgayTraThucTe_ValueChanged(object sender, EventArgs e)
        {
            CapNhatSoNgayTre();
        }

        private void chkCoViPham_CheckedChanged(object sender, EventArgs e)
        {
            pnlPhat.Enabled = chkCoViPham.Checked;
            if (!chkCoViPham.Checked)
            {
                txtTienPhat.Text = "0";
                txtLyDo.Text = string.Empty;
            }
            else
            {
                CapNhatThongTinPhat();
            }
        }

        private void cboQuyDinhPhat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkCoViPham.Checked)
            {
                CapNhatThongTinPhat();
            }
        }

        private void CapNhatThongTinPhat()
        {
            if (cboQuyDinhPhat.SelectedItem is QuyDinhPhat qd)
            {
                int soNgayTre = Math.Max(0, (dtpNgayTraThucTe.Value.Date - dtpNgayHenTra.Value.Date).Days);
                if (qd.KieuTinh == "TheoNgay")
                {
                    if (soNgayTre > 0)
                    {
                        decimal tien = soNgayTre * qd.MucPhat;
                        if (qd.TranPhat > 0 && tien > qd.TranPhat)
                        {
                            tien = qd.TranPhat;
                        }
                        txtTienPhat.Text = tien.ToString("0");
                        txtLyDo.Text = $"Trả sách quá hạn {soNgayTre} ngày.";
                    }
                    else
                    {
                        txtTienPhat.Text = "0";
                        txtLyDo.Text = "Trả sách đúng hạn.";
                    }
                }
                else
                {
                    txtTienPhat.Text = qd.MucPhat.ToString("0");
                    txtLyDo.Text = qd.TenQuyDinh;
                }
            }
        }

        private void btnXacNhanTra_Click(object sender, EventArgs e)
        {
            if (dtpNgayTraThucTe.Value.Date < this.ngayMuon.Date)
            {
                MessageBox.Show($"Ngày trả thực tế ({dtpNgayTraThucTe.Value:dd/MM/yyyy}) không thể trước ngày mượn ({this.ngayMuon:dd/MM/yyyy})!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool coViPham = chkCoViPham.Checked;
            int maQD = 0;
            decimal tienPhat = 0;
            string lyDo = txtLyDo.Text.Trim();

            if (coViPham)
            {
                if (cboQuyDinhPhat.SelectedValue is int qdId)
                {
                    maQD = qdId;
                }
                decimal.TryParse(txtTienPhat.Text, out tienPhat);
            }

            string tinhTrangSach = "Bình thường";
            if (coViPham && cboQuyDinhPhat.SelectedItem is QuyDinhPhat qd)
            {
                if (qd.MaViPham == "MAT_SACH")
                {
                    tinhTrangSach = "Mất";
                }
                else if (qd.MaViPham == "HU_HONG")
                {
                    tinhTrangSach = "Hỏng";
                }
            }

            if (muonTraSach.TraSach(maPM, maSach, dtpNgayTraThucTe.Value, tinhTrangSach, coViPham, maQD, tienPhat, lyDo, out string thongBaoLoi))
            {
                MessageBox.Show("Xác nhận trả sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(thongBaoLoi, "Lỗi trả sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
