using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyThuVien.BLL;
using QuanLyThuVien.DAL.Models;
using QuanLyThuVien.SubViews;

namespace QuanLyThuVien.Views
{
    public partial class MuontrasachViewcs : Form
    {
        private readonly MuonTraSach muonTraSach = new MuonTraSach();
        private enum ThaoTac { Xem, Muon, GiaHan }
        private ThaoTac thaoTacHienTai = ThaoTac.Xem;

        private List<DocGia> dsDocGia = new List<DocGia>();
        private List<Sach> dsSach = new List<Sach>();
        private List<ChiTietPhieuMuon> dsMuonTra = new List<ChiTietPhieuMuon>();

        public MuontrasachViewcs()
        {
            InitializeComponent();
            KhoiTaoDuLieu();
            SetTrangThaiNut(ThaoTac.Xem);
            LoadData();
        }

        private void KhoiTaoDuLieu()
        {
            dsDocGia = muonTraSach.LayDanhSachDocGia();
            cbPMMaSV.DataSource = null;
            cbPMMaSV.DataSource = dsDocGia;
            cbPMMaSV.DisplayMember = "HoTen";
            cbPMMaSV.ValueMember = "MaSV";

            dsSach = muonTraSach.LayDanhSachSach();
            cbPMTenSach.DataSource = null;
            cbPMTenSach.DataSource = dsSach;
            cbPMTenSach.DisplayMember = "TenSach";
            cbPMTenSach.ValueMember = "MaSach";
        }

        private void SetTrangThaiNut(ThaoTac tt)
        {
            thaoTacHienTai = tt;
            bool dangThaoTac = (tt != ThaoTac.Xem);

            btnMuon.Enabled = !dangThaoTac;
            btnGiaHan.Enabled = !dangThaoTac;
            btnTraSach.Enabled = !dangThaoTac;

            btnLuu.Enabled = dangThaoTac;
            btnHuyBo.Enabled = dangThaoTac;

            btnLuu.BackColor = dangThaoTac ? Color.FromArgb(42, 138, 98) : Color.FromArgb(248, 248, 248);
            btnLuu.ForeColor = dangThaoTac ? Color.White : Color.FromArgb(64, 64, 64);

            btnHuyBo.BackColor = dangThaoTac ? Color.FromArgb(220, 53, 69) : Color.FromArgb(248, 248, 248);
            btnHuyBo.ForeColor = dangThaoTac ? Color.White : Color.FromArgb(64, 64, 64);

            dgvMuonTra.Enabled = !dangThaoTac;
            gbTimKiem.Enabled = !dangThaoTac;

            cbPMTenSach.Enabled = (tt == ThaoTac.Muon);
            cbPMMaSV.Enabled = (tt == ThaoTac.Muon);
            dtpNgayMuon.Enabled = (tt == ThaoTac.Muon);
            dtpNgayTra.Enabled = dangThaoTac;
        }

        private void LoadData()
        {
            dsMuonTra = muonTraSach.LayDanhSachChiTietMuonTra();
            dgvMuonTra.DataSource = null;
            dgvMuonTra.DataSource = dsMuonTra;

            DinhDangCotDataGridView();

            if (dgvMuonTra.Rows.Count > 0)
            {
                dgvMuonTra.Rows[0].Selected = true;
                HienThiChiTiet(dsMuonTra[0]);
            }
            else
            {
                XoaTrangPhieuMuon();
            }
        }

        private void DinhDangCotDataGridView()
        {
            if (dgvMuonTra.Columns["PhieuMuon"] is DataGridViewColumn colPM) colPM.Visible = false;
            if (dgvMuonTra.Columns["Sach"] is DataGridViewColumn colS) colS.Visible = false;
            if (dgvMuonTra.Columns["SoLuong"] is DataGridViewColumn colSL) colSL.Visible = false;

            if (dgvMuonTra.Columns["MaPM"] is DataGridViewColumn cMaPM)
            {
                cMaPM.HeaderText = "Mã PM";
                cMaPM.FillWeight = 50;
            }
            if (dgvMuonTra.Columns["MaSV"] is DataGridViewColumn cMaSV)
            {
                cMaSV.HeaderText = "Mã SV";
                cMaSV.FillWeight = 50;
            }
            if (dgvMuonTra.Columns["TenDocGia"] is DataGridViewColumn cTenSV)
            {
                cTenSV.HeaderText = "Tên Độc Giả";
                cTenSV.FillWeight = 110;
            }
            if (dgvMuonTra.Columns["MaSach"] is DataGridViewColumn cMaSach)
            {
                cMaSach.HeaderText = "Mã Sách";
                cMaSach.FillWeight = 55;
            }
            if (dgvMuonTra.Columns["TenSach"] is DataGridViewColumn cTenSach)
            {
                cTenSach.HeaderText = "Tên Sách";
                cTenSach.FillWeight = 120;
            }
            if (dgvMuonTra.Columns["NgayMuon"] is DataGridViewColumn cNgayMuon)
            {
                cNgayMuon.HeaderText = "Ngày Mượn";
                cNgayMuon.DefaultCellStyle.Format = "dd/MM/yyyy";
                cNgayMuon.FillWeight = 75;
            }
            if (dgvMuonTra.Columns["HanTra"] is DataGridViewColumn cHanTra)
            {
                cHanTra.HeaderText = "Hạn Trả";
                cHanTra.DefaultCellStyle.Format = "dd/MM/yyyy";
                cHanTra.FillWeight = 75;
            }
            if (dgvMuonTra.Columns["NgayTra"] is DataGridViewColumn cNgayTra)
            {
                cNgayTra.HeaderText = "Ngày Trả";
                cNgayTra.DefaultCellStyle.Format = "dd/MM/yyyy";
                cNgayTra.FillWeight = 75;
            }
            if (dgvMuonTra.Columns["TrangThai"] is DataGridViewColumn cTrangThai)
            {
                cTrangThai.HeaderText = "Trạng Thái";
                cTrangThai.FillWeight = 75;
            }
            if (dgvMuonTra.Columns["TinhTrangSach"] is DataGridViewColumn cTinhTrang)
            {
                cTinhTrang.HeaderText = "Tình Trạng";
                cTinhTrang.FillWeight = 75;
            }
            if (dgvMuonTra.Columns["SoLanGiaHan"] is DataGridViewColumn cGiaHan)
            {
                cGiaHan.HeaderText = "Gia Hạn";
                cGiaHan.FillWeight = 50;
            }
            if (dgvMuonTra.Columns["GhiChu"] is DataGridViewColumn cGhiChu)
            {
                cGhiChu.HeaderText = "Ghi Chú";
                cGhiChu.FillWeight = 110;
                cGhiChu.Visible = true;
            }
            if (dgvMuonTra.Columns["SoNgayQuaHan"] is DataGridViewColumn colQuaHan) colQuaHan.Visible = false;
        }

        private void HienThiChiTiet(ChiTietPhieuMuon? ctpm)
        {
            if (ctpm == null)
            {
                XoaTrangPhieuMuon();
                return;
            }

            txtMaPM.Text = ctpm.MaPM.ToString();
            txtTinhTrangSach.Text = ctpm.TinhTrangSach;
            if (ctpm.NgayMuon != default)
            {
                dtpNgayMuon.Value = ctpm.NgayMuon;
            }
            if (ctpm.HanTra != default)
            {
                dtpNgayTra.Value = ctpm.HanTra;
            }

            // Đồng bộ combobox Độc giả và thông tin sinh viên
            cbPMMaSV.SelectedValue = ctpm.MaSV;
            var dg = dsDocGia.FirstOrDefault(x => x.MaSV == ctpm.MaSV);
            if (dg != null)
            {
                txtMaSV.Text = dg.MaSV.ToString();
                txtTenSV.Text = dg.HoTen;
            }
            else
            {
                txtMaSV.Text = ctpm.MaSV.ToString();
                txtTenSV.Text = ctpm.TenDocGia;
            }

            // Đồng bộ combobox Sách và thông tin sách
            cbPMTenSach.SelectedValue = ctpm.MaSach;
            var sach = dsSach.FirstOrDefault(x => x.MaSach == ctpm.MaSach);
            if (sach != null)
            {
                txtMaSach.Text = sach.MaSach.ToString();
                txtTenSach.Text = sach.TenSach;
                txtTenTG.Text = sach.TenTacGia;
                txtSLCon.Text = sach.SoLuongCon.ToString();
            }
            else
            {
                txtMaSach.Text = ctpm.MaSach.ToString();
                txtTenSach.Text = ctpm.TenSach;
                txtTenTG.Text = string.Empty;
                txtSLCon.Text = string.Empty;
            }
        }

        private void XoaTrangPhieuMuon()
        {
            txtMaPM.Text = string.Empty;
            txtTinhTrangSach.Text = "Bình thường";
            txtMaSV.Text = string.Empty;
            txtTenSV.Text = string.Empty;
            txtMaSach.Text = string.Empty;
            txtTenSach.Text = string.Empty;
            txtTenTG.Text = string.Empty;
            txtSLCon.Text = string.Empty;
        }

        private void dgvMuonTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (thaoTacHienTai != ThaoTac.Xem)
            {
                return;
            }

            if (e.RowIndex >= 0 && dgvMuonTra.Rows[e.RowIndex].DataBoundItem is ChiTietPhieuMuon ctpm)
            {
                HienThiChiTiet(ctpm);
            }
        }

        private void cbPMMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPMMaSV.SelectedItem is DocGia dg)
            {
                txtMaSV.Text = dg.MaSV.ToString();
                txtTenSV.Text = dg.HoTen;
            }
        }

        private void cbPMTenSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPMTenSach.SelectedItem is Sach s)
            {
                txtMaSach.Text = s.MaSach.ToString();
                txtTenSach.Text = s.TenSach;
                txtTenTG.Text = s.TenTacGia;
                txtSLCon.Text = s.SoLuongCon.ToString();
            }
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            if (dsDocGia.Count == 0)
            {
                MessageBox.Show("Hiện chưa có dữ liệu độc giả. Vui lòng thêm độc giả trước khi lập phiếu mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dsSach.Count == 0)
            {
                MessageBox.Show("Hiện chưa có dữ liệu sách trong thư viện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetTrangThaiNut(ThaoTac.Muon);
            txtMaPM.Text = "(Tự động)";
            dtpNgayMuon.Value = DateTime.Today;
            dtpNgayTra.Value = DateTime.Today.AddDays(14);
            txtTinhTrangSach.Text = "Bình thường";

            if (cbPMMaSV.Items.Count > 0)
            {
                cbPMMaSV.SelectedIndex = 0;
            }
            if (cbPMTenSach.Items.Count > 0)
            {
                cbPMTenSach.SelectedIndex = 0;
            }
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            if (dgvMuonTra.CurrentRow?.DataBoundItem is not ChiTietPhieuMuon ctpm)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn cần gia hạn từ bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ctpm.NgayTra != null || ctpm.TrangThai == "DaTra")
            {
                MessageBox.Show("Sách này đã được trả, không thể gia hạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ctpm.SoLanGiaHan >= 2)
            {
                MessageBox.Show("Phiếu mượn này đã được gia hạn 2 lần (tối đa theo quy định), không thể gia hạn thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetTrangThaiNut(ThaoTac.GiaHan);
            dtpNgayTra.Value = ctpm.HanTra.AddDays(7);
        }

        // =========================================================================================================
        // SỰ KIỆN CLICK NÚT btnTraSach -> POPUP FORM TrasachView ĐỂ XỬ LÝ TRẢ SÁCH, VI PHẠM, PHẠT TIỀN
        // =========================================================================================================
        private void btnTraSach_Click(object sender, EventArgs e)
        {
            ChiTietPhieuMuon? ctpm = null;

            // 1. Lấy thông tin phiếu mượn từ dòng đang chọn trên DataGridView
            if (dgvMuonTra.CurrentRow?.DataBoundItem is ChiTietPhieuMuon item1)
            {
                ctpm = item1;
            }
            else if (dgvMuonTra.SelectedRows.Count > 0 && dgvMuonTra.SelectedRows[0].DataBoundItem is ChiTietPhieuMuon item2)
            {
                ctpm = item2;
            }

            // 2. Nếu người dùng chưa chọn dòng nào, tự động lấy phiếu mượn chưa trả đầu tiên
            if (ctpm == null)
            {
                ctpm = dsMuonTra.FirstOrDefault(x => x.NgayTra == null && x.TrangThai != "DaTra");
            }

            if (ctpm == null)
            {
                MessageBox.Show("Hiện không có phiếu mượn nào cần trả sách trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 3. Nếu dòng đang chọn đã được trả trước đó, hỗ trợ chuyển sang phiếu mượn đang mượn gần nhất
            if (ctpm.NgayTra != null || ctpm.TrangThai == "DaTra")
            {
                var chuaTra = dsMuonTra.FirstOrDefault(x => x.NgayTra == null && x.TrangThai != "DaTra");
                if (chuaTra != null)
                {
                    var luaChon = MessageBox.Show(
                        $"Phiếu mượn số {ctpm.MaPM} đã được trả trước đó rồi.\n\nBạn có muốn chuyển sang trả sách cho phiếu mượn chưa trả gần nhất (Mã PM: {chuaTra.MaPM} - Độc giả: {chuaTra.TenDocGia} - Sách: {chuaTra.TenSach}) không?",
                        "Phiếu mượn đã trả", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (luaChon == DialogResult.Yes)
                    {
                        ctpm = chuaTra;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Tất cả phiếu mượn trong hệ thống đều đã được trả sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            // 4. Khởi tạo và hiển thị popup TrasachView dạng Modal Dialog
            using var frmTra = new SubViews.TrasachView(ctpm);
            if (frmTra.ShowDialog(this) == DialogResult.OK)
            {
                // Khi xác nhận trả sách thành công, làm mới toàn bộ dữ liệu trên bảng
                KhoiTaoDuLieu();
                LoadData();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (thaoTacHienTai == ThaoTac.Muon)
            {
                if (cbPMMaSV.SelectedValue is not int maSV)
                {
                    MessageBox.Show("Vui lòng chọn độc giả mượn sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbPMTenSach.SelectedValue is not int maSach)
                {
                    MessageBox.Show("Vui lòng chọn sách cần mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dtpNgayTra.Value.Date < dtpNgayMuon.Value.Date)
                {
                    MessageBox.Show("Hạn trả sách không thể trước ngày mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (muonTraSach.ThemPhieuMuon(maSV, maSach, dtpNgayMuon.Value, dtpNgayTra.Value, out string thongBaoLoi))
                {
                    MessageBox.Show("Lập phiếu mượn sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetTrangThaiNut(ThaoTac.Xem);
                    KhoiTaoDuLieu();
                    LoadData();
                }
                else
                {
                    MessageBox.Show(thongBaoLoi, "Lỗi lập phiếu mượn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (thaoTacHienTai == ThaoTac.GiaHan)
            {
                if (!int.TryParse(txtMaPM.Text, out int maPM))
                {
                    MessageBox.Show("Mã phiếu mượn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (muonTraSach.GiaHan(maPM, dtpNgayTra.Value, out string thongBaoLoi))
                {
                    MessageBox.Show("Gia hạn phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetTrangThaiNut(ThaoTac.Xem);
                    LoadData();
                }
                else
                {
                    MessageBox.Show(thongBaoLoi, "Lỗi gia hạn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            SetTrangThaiNut(ThaoTac.Xem);
            if (dgvMuonTra.CurrentRow?.DataBoundItem is ChiTietPhieuMuon ctpm)
            {
                HienThiChiTiet(ctpm);
            }
            else if (dsMuonTra.Count > 0)
            {
                HienThiChiTiet(dsMuonTra[0]);
            }
            else
            {
                XoaTrangPhieuMuon();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ThucHienTimKiem();
        }

        private void rbTimKiem_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                ThucHienTimKiem();
            }
        }

        private void ThucHienTimKiem()
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            bool isTimTheoMaSV = rbMaSV.Checked;

            var ketQua = muonTraSach.TimKiem(tuKhoa, isTimTheoMaSV);
            dgvMuonTra.DataSource = null;
            dgvMuonTra.DataSource = ketQua;
            DinhDangCotDataGridView();

            if (ketQua.Count > 0)
            {
                HienThiChiTiet(ketQua[0]);
            }
            else
            {
                XoaTrangPhieuMuon();
            }
        }
    }
}
