using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuanLyThuVien.BLL;
using QuanLyThuVien.DAL.Models;
using QuanLyThuVien.GUI.SubViews;

namespace QuanLyThuVien.Views
{
    public partial class QuanlisachView : Form
    {
        private readonly QuanLiSach quanLiSach = new();
        private bool isAdding = false;

        public QuanlisachView()
        {
            InitializeComponent();
        }

        private void QuanlisachView_Load(object? sender, EventArgs e)
        {
            try
            {
                quanLiSach.KhoiTaoDuLieuMau();

                LoadComboBoxTheLoai();
                LoadComboBoxTacGia();
                LoadComboBoxNhaXuatBan();

                LoadDataGrid();
                SetButtonState(isEditing: false);

                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[0].Selected = true;
                    HienThiChiTietDong(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo dữ liệu: " + ex.Message, "Lỗi kết nối CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadComboBoxTheLoai()
        {
            var oldSelected = cmbLoaiSach.SelectedValue;
            var list = quanLiSach.LayDanhSachTheLoai();
            cmbLoaiSach.DataSource = null;
            cmbLoaiSach.DataSource = list;
            cmbLoaiSach.DisplayMember = "TenTheLoai";
            cmbLoaiSach.ValueMember = "MaTheLoai";

            if (oldSelected != null)
            {
                cmbLoaiSach.SelectedValue = oldSelected;
            }
        }

        public void LoadComboBoxTacGia()
        {
            var oldSelected = cmbTacGia.SelectedValue;
            var list = quanLiSach.LayDanhSachTacGia();
            cmbTacGia.DataSource = null;
            cmbTacGia.DataSource = list;
            cmbTacGia.DisplayMember = "TenTacGia";
            cmbTacGia.ValueMember = "MaTacGia";

            if (oldSelected != null)
            {
                cmbTacGia.SelectedValue = oldSelected;
            }
        }

        public void LoadComboBoxNhaXuatBan()
        {
            var oldSelected = cmbNhaXuatBan.SelectedValue;
            var list = quanLiSach.LayDanhSachNhaXuatBan();
            cmbNhaXuatBan.DataSource = null;
            cmbNhaXuatBan.DataSource = list;
            cmbNhaXuatBan.DisplayMember = "TenNXB";
            cmbNhaXuatBan.ValueMember = "MaNXB";

            if (oldSelected != null)
            {
                cmbNhaXuatBan.SelectedValue = oldSelected;
            }
        }

        private void LoadDataGrid()
        {
            var dsSach = quanLiSach.LayDanhSach();
            HienThiLenDataGrid(dsSach);
        }

        private void HienThiLenDataGrid(List<Sach> dsSach)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dsSach;

            void SetHeader(string colName, string text, bool visible = true)
            {
                var col = dataGridView1.Columns[colName];
                if (col != null)
                {
                    col.HeaderText = text;
                    col.Visible = visible;
                }
            }

            SetHeader("MaSach", "Mã Sách");
            SetHeader("TenSach", "Tên Sách");
            SetHeader("TenTheLoai", "Thể Loại");
            SetHeader("TenTacGia", "Tác Giả");
            SetHeader("TenNXB", "Nhà Xuất Bản");
            SetHeader("NamXB", "Năm XB");
            SetHeader("SoLuong", "Số Lượng");
            SetHeader("SoLuongCon", "Còn Lại");
            SetHeader("ViTri", "Vị Trí");

            var colGiaBia = dataGridView1.Columns["GiaBia"];
            if (colGiaBia != null)
            {
                colGiaBia.HeaderText = "Giá Bìa";
                colGiaBia.DefaultCellStyle.Format = "N0";
            }

            // Ẩn các cột quan hệ và khóa ngoại kỹ thuật
            SetHeader("MaTheLoai", "", false);
            SetHeader("MaTacGia", "", false);
            SetHeader("MaNXB", "", false);
            SetHeader("TheLoai", "", false);
            SetHeader("TacGia", "", false);
            SetHeader("NhaXuatBan", "", false);
            SetHeader("AnhBia", "", false);
            SetHeader("ChiTietPhieuMuons", "", false);
            SetHeader("PhieuPhats", "", false);
        }

        private void SetButtonState(bool isEditing)
        {
            bool coDuLieu = dataGridView1.Rows.Count > 0;

            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing && coDuLieu;
            btnXoa.Enabled = !isEditing && coDuLieu;
            btnGhi.Enabled = isEditing;
            btnHuyBo.Enabled = isEditing;

            txtMaSach.ReadOnly = true;
            txtTenSach.ReadOnly = !isEditing;
            txtSoTrang.ReadOnly = !isEditing;
            txtGiaBan.ReadOnly = !isEditing;
            txtSoLuong.ReadOnly = !isEditing;

            cmbLoaiSach.Enabled = isEditing;
            btnThemTheLoai.Enabled = isEditing;

            cmbTacGia.Enabled = isEditing;
            btnThemTacGia.Enabled = isEditing;

            cmbNhaXuatBan.Enabled = isEditing;
            btnThemNhaXuatBan.Enabled = isEditing;

            dataGridView1.Enabled = !isEditing;
            textBoxSearch.Enabled = !isEditing;
        }

        private void ClearInputs()
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            txtSoTrang.Text = DateTime.Now.Year.ToString();
            txtGiaBan.Text = "0";
            txtSoLuong.Text = "1";

            if (cmbLoaiSach.Items.Count > 0) cmbLoaiSach.SelectedIndex = 0;
            if (cmbTacGia.Items.Count > 0) cmbTacGia.SelectedIndex = 0;
            if (cmbNhaXuatBan.Items.Count > 0) cmbNhaXuatBan.SelectedIndex = 0;
        }

        private void HienThiChiTietDong(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= dataGridView1.Rows.Count)
            {
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            txtMaSach.Text = row.Cells["MaSach"].Value?.ToString() ?? "";
            txtTenSach.Text = row.Cells["TenSach"].Value?.ToString() ?? "";
            txtSoTrang.Text = row.Cells["NamXB"].Value?.ToString() ?? "";
            txtGiaBan.Text = row.Cells["GiaBia"].Value?.ToString() ?? "";
            txtSoLuong.Text = row.Cells["SoLuong"].Value?.ToString() ?? "";

            if (row.Cells["MaTheLoai"].Value != null)
            {
                cmbLoaiSach.SelectedValue = Convert.ToInt32(row.Cells["MaTheLoai"].Value);
            }

            if (row.Cells["MaTacGia"].Value != null)
            {
                cmbTacGia.SelectedValue = Convert.ToInt32(row.Cells["MaTacGia"].Value);
            }

            if (row.Cells["MaNXB"].Value != null)
            {
                cmbNhaXuatBan.SelectedValue = Convert.ToInt32(row.Cells["MaNXB"].Value);
            }
        }

        private void dataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                HienThiChiTietDong(e.RowIndex);
                if (!btnGhi.Enabled)
                {
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                }
            }
        }

        // ================= Xử lý mở các SubView =================
        private void btnThemTheLoai_Click(object? sender, EventArgs e)
        {
            using var form = new ThemTheLoai();
            form.ShowDialog(this);
            LoadComboBoxTheLoai();
        }

        private void btnThemTacGia_Click(object? sender, EventArgs e)
        {
            using var form = new ThemTacGia();
            form.ShowDialog(this);
            LoadComboBoxTacGia();
        }

        private void btnThemNhaXuatBan_Click(object? sender, EventArgs e)
        {
            using var form = new ThemNhaXuatBan();
            form.ShowDialog(this);
            LoadComboBoxNhaXuatBan();
        }

        // ================= Xử lý nghiệp vụ Sách =================
        private void btnThem_Click(object? sender, EventArgs e)
        {
            isAdding = true;
            ClearInputs();
            SetButtonState(isEditing: true);
            txtTenSach.Focus();
        }

        private void btnSua_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || string.IsNullOrWhiteSpace(txtMaSach.Text))
            {
                MessageBox.Show("Vui lòng chọn cuốn sách cần sửa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isAdding = false;
            SetButtonState(isEditing: true);
            txtTenSach.Focus();
        }

        private void btnHuyBo_Click(object? sender, EventArgs e)
        {
            SetButtonState(isEditing: false);

            if (dataGridView1.CurrentRow != null)
            {
                HienThiChiTietDong(dataGridView1.CurrentRow.Index);
            }
            else
            {
                ClearInputs();
            }
        }

        private void btnGhi_Click(object? sender, EventArgs e)
        {
            string tenSach = txtTenSach.Text.Trim();
            if (string.IsNullOrWhiteSpace(tenSach))
            {
                MessageBox.Show("Vui lòng nhập tên sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSach.Focus();
                return;
            }

            if (cmbLoaiSach.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn thể loại sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbLoaiSach.Focus();
                return;
            }

            if (cmbTacGia.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn tác giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTacGia.Focus();
                return;
            }

            if (cmbNhaXuatBan.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbNhaXuatBan.Focus();
                return;
            }

            if (!int.TryParse(txtSoTrang.Text.Trim(), out int namXB) || namXB < 1000 || namXB > DateTime.Now.Year + 1)
            {
                MessageBox.Show($"Năm xuất bản không hợp lệ! Vui lòng nhập số từ 1000 đến {DateTime.Now.Year + 1}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTrang.Focus();
                return;
            }

            if (!decimal.TryParse(txtGiaBan.Text.Trim(), out decimal giaBia) || giaBia < 0)
            {
                MessageBox.Show("Giá bìa không hợp lệ! Vui lòng nhập số dương.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaBan.Focus();
                return;
            }

            if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong) || soLuong < 0)
            {
                MessageBox.Show("Số lượng sách không hợp lệ! Vui lòng nhập số nguyên không âm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            int maTheLoai = Convert.ToInt32(cmbLoaiSach.SelectedValue);
            int maTacGia = Convert.ToInt32(cmbTacGia.SelectedValue);
            int maNXB = Convert.ToInt32(cmbNhaXuatBan.SelectedValue);

            if (isAdding)
            {
                var sachMoi = new Sach
                {
                    TenSach = tenSach,
                    MaTheLoai = maTheLoai,
                    MaTacGia = maTacGia,
                    MaNXB = maNXB,
                    NamXB = namXB,
                    GiaBia = giaBia,
                    SoLuong = soLuong,
                    ViTri = "Kệ A"
                };

                bool ketQua = quanLiSach.Them(sachMoi, out string thongBaoLoi);
                if (ketQua)
                {
                    MessageBox.Show("Thêm sách mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGrid();
                    SetButtonState(isEditing: false);

                    if (dataGridView1.Rows.Count > 0)
                    {
                        dataGridView1.Rows[0].Selected = true;
                        HienThiChiTietDong(0);
                    }
                }
                else
                {
                    MessageBox.Show(thongBaoLoi, "Thêm sách thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (!int.TryParse(txtMaSach.Text.Trim(), out int maSach))
                {
                    MessageBox.Show("Mã sách không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var sachCapNhat = new Sach
                {
                    MaSach = maSach,
                    TenSach = tenSach,
                    MaTheLoai = maTheLoai,
                    MaTacGia = maTacGia,
                    MaNXB = maNXB,
                    NamXB = namXB,
                    GiaBia = giaBia,
                    SoLuong = soLuong,
                    ViTri = "Kệ A"
                };

                bool ketQua = quanLiSach.CapNhat(sachCapNhat, out string thongBaoLoi);
                if (ketQua)
                {
                    MessageBox.Show("Cập nhật thông tin sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGrid();
                    SetButtonState(isEditing: false);

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["MaSach"].Value?.ToString() == maSach.ToString())
                        {
                            row.Selected = true;
                            HienThiChiTietDong(row.Index);
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show(thongBaoLoi, "Cập nhật thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || !int.TryParse(txtMaSach.Text.Trim(), out int maSach))
            {
                MessageBox.Show("Vui lòng chọn cuốn sách cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenSach = txtTenSach.Text.Trim();
            DialogResult dialog = MessageBox.Show($"Bạn có chắc chắn muốn xóa cuốn sách '{tenSach}' (Mã: {maSach})?", "Xác nhận xóa sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                bool ketQua = quanLiSach.Xoa(maSach, out string thongBaoLoi);
                if (ketQua)
                {
                    MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGrid();
                    SetButtonState(isEditing: false);

                    if (dataGridView1.Rows.Count > 0)
                    {
                        dataGridView1.Rows[0].Selected = true;
                        HienThiChiTietDong(0);
                    }
                    else
                    {
                        ClearInputs();
                    }
                }
                else
                {
                    MessageBox.Show(thongBaoLoi, "Xóa sách thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void textBoxSearch_TextChanged(object? sender, EventArgs e)
        {
            string tuKhoa = textBoxSearch.Text.Trim();
            var ketQua = quanLiSach.TimKiem(tuKhoa);
            HienThiLenDataGrid(ketQua);

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Selected = true;
                HienThiChiTietDong(0);
            }
            else
            {
                ClearInputs();
            }

            SetButtonState(isEditing: false);
        }

        private void btnTrangChu_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
