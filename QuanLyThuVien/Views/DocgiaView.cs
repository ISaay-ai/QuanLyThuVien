using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyThuVien.BLL;
using QuanLyThuVien.DAL.Models;

namespace QuanLyThuVien.Views
{
    public partial class DocgiaView : Form
    {
        private readonly DocGiaMng docGiaMng = new DocGiaMng();
        private bool isAdding = false;

        public DocgiaView()
        {
            InitializeComponent();
            if (cmbKhoaHoc.Items.Count > 7)
            {
                cmbKhoaHoc.SelectedIndex = 7;
            }
            KhoiTaoComboBoxNganh();
            ThietLapTrangThaiNut(false);
            LoadData();
        }

        private void KhoiTaoComboBoxNganh()
        {
            cboNganh.Items.Clear();
            var danhSachNganh = docGiaMng.LayDanhSachNganh();
            if (danhSachNganh.Count > 0)
            {
                foreach (var n in danhSachNganh)
                {
                    if (!cboNganh.Items.Contains(n.TenNganh))
                    {
                        cboNganh.Items.Add(n.TenNganh);
                    }
                }
            }
            else
            {
                cboNganh.Items.AddRange(new string[]
                {
                    "Công nghệ thông tin",
                    "Kỹ thuật phần mềm",
                    "Khoa học máy tính",
                    "Hệ thống thông tin",
                    "Kỹ thuật máy tính",
                    "An toàn thông tin",
                    "Kinh tế",
                    "Kế toán",
                    "Quản trị kinh doanh",
                    "Ngôn ngữ Anh"
                });
            }

            if (cboNganh.Items.Count > 0 && cboNganh.SelectedIndex < 0)
            {
                cboNganh.SelectedIndex = 0;
            }
        }

        private void ThietLapTrangThaiNut(bool dangThaoTac)
        {
            CapNhatGiaoDienTrangThaiNut(dangThaoTac);
        }

        private void XoaTrangForm()
        {
            txtMaSV.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtSoDienThoai.Text = string.Empty;
            if (cboNganh.Items.Count > 0)
            {
                cboNganh.SelectedIndex = 0;
            }
            if (cmbKhoaHoc.Items.Count > 0)
            {
                cmbKhoaHoc.SelectedIndex = 0;
            }
        }

        private void LoadData()
        {
            var listDocGia = docGiaMng.LayDanhSach();
            dgvDocGia.DataSource = null;
            dgvDocGia.DataSource = listDocGia;

            DinhDangCotDataGridView();

            if (dgvDocGia.Rows.Count > 0)
            {
                dgvDocGia.Rows[0].Selected = true;
                HienThiDocGia(listDocGia[0]);
            }
            else
            {
                XoaTrangForm();
            }
        }

        private void DinhDangCotDataGridView()
        {
            // Ẩn các navigation property không cần hiển thị
            if (dgvDocGia.Columns["Nganh"] is DataGridViewColumn colNganh)
                colNganh.Visible = false;
            if (dgvDocGia.Columns["PhieuMuons"] is DataGridViewColumn colPhieuMuon)
                colPhieuMuon.Visible = false;
            if (dgvDocGia.Columns["MaNganh"] is DataGridViewColumn colMaNganh)
                colMaNganh.Visible = false;

            // Đặt tiêu đề và độ rộng các cột
            if (dgvDocGia.Columns["MaSV"] is DataGridViewColumn colMaSV)
            {
                colMaSV.HeaderText = "Mã SV";
                colMaSV.FillWeight = 50;
            }
            if (dgvDocGia.Columns["HoTen"] is DataGridViewColumn colHoTen)
            {
                colHoTen.HeaderText = "Họ và Tên";
                colHoTen.FillWeight = 110;
            }
            if (dgvDocGia.Columns["TenNganh"] is DataGridViewColumn colTenNganh)
            {
                colTenNganh.HeaderText = "Ngành Học";
                colTenNganh.FillWeight = 100;
            }
            if (dgvDocGia.Columns["Khoa"] is DataGridViewColumn colKhoa)
            {
                colKhoa.HeaderText = "Khoá";
                colKhoa.FillWeight = 50;
            }
            if (dgvDocGia.Columns["SDT"] is DataGridViewColumn colSDT)
            {
                colSDT.HeaderText = "Số ĐT";
                colSDT.FillWeight = 80;
            }
            if (dgvDocGia.Columns["Email"] is DataGridViewColumn colEmail)
            {
                colEmail.HeaderText = "Email";
                colEmail.FillWeight = 100;
            }
            if (dgvDocGia.Columns["NgayLapThe"] is DataGridViewColumn colNgayLap)
            {
                colNgayLap.HeaderText = "Ngày Lập Thẻ";
                colNgayLap.DefaultCellStyle.Format = "dd/MM/yyyy";
                colNgayLap.FillWeight = 75;
            }
            if (dgvDocGia.Columns["NgayHetHan"] is DataGridViewColumn colNgayHetHan)
            {
                colNgayHetHan.HeaderText = "Ngày Hết Hạn";
                colNgayHetHan.DefaultCellStyle.Format = "dd/MM/yyyy";
                colNgayHetHan.FillWeight = 75;
            }
        }

        private void HienThiDocGia(DocGia? dg)
        {
            if (dg == null)
            {
                XoaTrangForm();
                return;
            }

            txtMaSV.Text = dg.MaSV.ToString();
            txtHoTen.Text = dg.HoTen;
            cboNganh.Text = dg.TenNganh;
            cmbKhoaHoc.Text = dg.Khoa;
            txtSoDienThoai.Text = dg.SDT;
        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnGhi.Enabled)
            {
                return; // Đang trong chế độ Thêm/Sửa thì không đổi thông tin hiển thị
            }

            if (e.RowIndex >= 0 && dgvDocGia.Rows[e.RowIndex].DataBoundItem is DocGia dg)
            {
                HienThiDocGia(dg);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            XoaTrangForm();
            txtMaSV.Text = "(Tự động)";
            ThietLapTrangThaiNut(true);
            txtHoTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDocGia.CurrentRow?.DataBoundItem is not DocGia)
            {
                MessageBox.Show("Vui lòng chọn độc giả cần sửa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            isAdding = false;
            ThietLapTrangThaiNut(true);
            txtHoTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDocGia.CurrentRow?.DataBoundItem is not DocGia dg)
            {
                MessageBox.Show("Vui lòng chọn độc giả cần xoá từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var xacNhan = MessageBox.Show(
                $"Bạn có chắc chắn muốn xoá độc giả '{dg.HoTen}' (Mã SV: {dg.MaSV}) không?",
                "Xác nhận xoá độc giả",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (xacNhan != DialogResult.Yes)
            {
                return;
            }

            if (docGiaMng.Xoa(dg.MaSV, out string thongBaoLoi))
            {
                MessageBox.Show("Xoá độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show(thongBaoLoi, "Không thể xoá", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            if (string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ và tên độc giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            string tenNganh = cboNganh.Text.Trim();
            if (string.IsNullOrWhiteSpace(tenNganh))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập ngành học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNganh.Focus();
                return;
            }

            string khoaHoc = cmbKhoaHoc.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();

            if (isAdding)
            {
                var docGiaMoi = new DocGia
                {
                    HoTen = hoTen,
                    Khoa = khoaHoc,
                    SDT = sdt,
                    Email = !string.IsNullOrWhiteSpace(sdt) ? $"{sdt}@student.edu.vn" : string.Empty,
                    NgayLapThe = DateTime.Today,
                    NgayHetHan = DateTime.Today.AddYears(4)
                };

                if (docGiaMng.ThemMoi(docGiaMoi, tenNganh, out string thongBaoLoi))
                {
                    MessageBox.Show("Thêm mới độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ThietLapTrangThaiNut(false);
                    KhoiTaoComboBoxNganh();
                    LoadData();
                }
                else
                {
                    MessageBox.Show(thongBaoLoi, "Lỗi thêm độc giả", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (!int.TryParse(txtMaSV.Text, out int maSV))
                {
                    MessageBox.Show("Mã độc giả không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var docGiaCapNhat = new DocGia
                {
                    MaSV = maSV,
                    HoTen = hoTen,
                    Khoa = khoaHoc,
                    SDT = sdt,
                    Email = !string.IsNullOrWhiteSpace(sdt) ? $"{sdt}@student.edu.vn" : string.Empty
                };

                if (docGiaMng.CapNhat(docGiaCapNhat, tenNganh, out string thongBaoLoi))
                {
                    MessageBox.Show("Cập nhật thông tin độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ThietLapTrangThaiNut(false);
                    KhoiTaoComboBoxNganh();
                    LoadData();
                }
                else
                {
                    MessageBox.Show(thongBaoLoi, "Lỗi cập nhật độc giả", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            ThietLapTrangThaiNut(false);
            if (dgvDocGia.CurrentRow?.DataBoundItem is DocGia dg)
            {
                HienThiDocGia(dg);
            }
            else if (dgvDocGia.Rows.Count > 0 && dgvDocGia.Rows[0].DataBoundItem is DocGia firstDg)
            {
                HienThiDocGia(firstDg);
            }
            else
            {
                XoaTrangForm();
            }
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ThucHienTimKiem();
        }

        private void radTimKiem_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                ThucHienTimKiem();
            }
        }

        private void ThucHienTimKiem()
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            bool theoMaSV = radMaSV.Checked;

            var ketQua = docGiaMng.TimKiem(tuKhoa, theoMaSV);
            dgvDocGia.DataSource = null;
            dgvDocGia.DataSource = ketQua;
            DinhDangCotDataGridView();

            if (ketQua.Count > 0)
            {
                HienThiDocGia(ketQua[0]);
            }
            else
            {
                XoaTrangForm();
            }
        }

        private void DocgiaView_Load(object sender, EventArgs e)
        {

        }
    }
}
