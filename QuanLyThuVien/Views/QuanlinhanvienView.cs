using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QuanLyThuVien.BLL;

namespace QuanLyThuVien.Views
{
    public partial class QuanlinhanvienView : Form
    {
        private readonly EmployeeMng employeeMng = new EmployeeMng();

        public QuanlinhanvienView()
        {
            InitializeComponent();
            this.Load += QuanlinhanvienView_Load;
            this.dgvNhanVien.CellClick += dgvNhanVien_CellClick;

            // Xử lý khi nhấn chuột vào vùng trống bên ngoài bảng hoặc trên form -> bỏ chọn dòng
            this.dgvNhanVien.MouseDown += dgvNhanVien_MouseDown;
            this.MouseDown += (s, e) => BoChonDong();
            this.groupBox1.MouseDown += (s, e) => BoChonDong();
        }

        private void QuanlinhanvienView_Load(object? sender, EventArgs e)
        {
            if (cboGioiTinh.Items.Count == 0)
            {
                cboGioiTinh.Items.AddRange(new string[] { "Nam", "Nữ" });
                cboGioiTinh.SelectedIndex = 0;
            }
            dtpNgaySinh.Value = new DateTime(2000, 1, 1);
            LoadDataGrid();
            BoChonDong();
        }

        private void LoadDataGrid()
        {
            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = employeeMng.LayDanhSach();

            if (dgvNhanVien.Columns["MatKhau"] != null)
                dgvNhanVien.Columns["MatKhau"].Visible = false;

            if (dgvNhanVien.Columns["PhieuMuons"] != null)
                dgvNhanVien.Columns["PhieuMuons"].Visible = false;

            if (dgvNhanVien.Columns["PhieuPhat"] != null)
                dgvNhanVien.Columns["PhieuPhat"].Visible = false;

            if (dgvNhanVien.Columns["MaTK"] != null)
            {
                dgvNhanVien.Columns["MaTK"].HeaderText = "Mã TK";
                dgvNhanVien.Columns["MaTK"].FillWeight = 40;
            }
            if (dgvNhanVien.Columns["TenDangNhap"] != null)
            {
                dgvNhanVien.Columns["TenDangNhap"].HeaderText = "Tên Đăng Nhập";
                dgvNhanVien.Columns["TenDangNhap"].FillWeight = 85;
            }
            if (dgvNhanVien.Columns["HoTen"] != null)
            {
                dgvNhanVien.Columns["HoTen"].HeaderText = "Họ và Tên";
                dgvNhanVien.Columns["HoTen"].FillWeight = 110;
            }
            if (dgvNhanVien.Columns["GioiTinh"] != null)
            {
                dgvNhanVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
                dgvNhanVien.Columns["GioiTinh"].FillWeight = 50;
            }
            if (dgvNhanVien.Columns["NgaySinh"] != null)
            {
                dgvNhanVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                dgvNhanVien.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvNhanVien.Columns["NgaySinh"].FillWeight = 75;
            }
            if (dgvNhanVien.Columns["SDT"] != null)
            {
                dgvNhanVien.Columns["SDT"].HeaderText = "Số Điện Thoại";
                dgvNhanVien.Columns["SDT"].FillWeight = 85;
            }
            if (dgvNhanVien.Columns["DiaChi"] != null)
            {
                dgvNhanVien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgvNhanVien.Columns["DiaChi"].FillWeight = 110;
            }
            if (dgvNhanVien.Columns["VaiTro"] != null)
            {
                dgvNhanVien.Columns["VaiTro"].HeaderText = "Vai Trò";
                dgvNhanVien.Columns["VaiTro"].FillWeight = 60;
            }
        }

        private void ClearInputs()
        {
            txtHoTen.Clear();
            txtTenLogIn.Clear();
            txtMK.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            dtpNgaySinh.Value = new DateTime(2000, 1, 1);
            if (cboGioiTinh.Items.Count > 0)
            {
                cboGioiTinh.SelectedIndex = 0;
            }
            txtTenLogIn.ReadOnly = false;
        }

        /// <summary>
        /// Bỏ chọn dòng đang chọn trên DataGridView và xóa trắng ô nhập liệu
        /// </summary>
        private void BoChonDong()
        {
            dgvNhanVien.ClearSelection();
            dgvNhanVien.CurrentCell = null;
            ClearInputs();
        }

        /// <summary>
        /// Khi nhấn chuột vào vùng trống bên ngoài các dòng dữ liệu của DataGridView
        /// </summary>
        private void dgvNhanVien_MouseDown(object? sender, MouseEventArgs e)
        {
            var hit = dgvNhanVien.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.None)
            {
                BoChonDong();
            }
        }

        private void btnDangKy_Click(object? sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            string tenDangNhap = txtTenLogIn.Text.Trim();
            string matKhau = txtMK.Text;
            string gioTinh = cboGioiTinh.SelectedItem?.ToString() ?? "Nam";
            DateTime ngaySinh = dtpNgaySinh.Value.Date;
            string sdt = txtSDT.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            bool isSuccess = employeeMng.DangKy(tenDangNhap, matKhau, hoTen, gioTinh, ngaySinh, sdt, null, diaChi);

            if (isSuccess)
            {
                MessageBox.Show("Thêm nhân viên/Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGrid();
                BoChonDong();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại! Vui lòng kiểm tra:\n- Tên đăng nhập và mật khẩu không được trống.\n- Mật khẩu phải từ 6 ký tự trở lên.\n- Tên đăng nhập có thể đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDoiMK_Click(object? sender, EventArgs e)
        {
            string tenDangNhap = txtTenLogIn.Text.Trim();
            string matKhauMoi = txtMK.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenDangNhap))
            {
                MessageBox.Show("Vui lòng chọn nhân viên hoặc nhập Tên đăng nhập cần đổi mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(matKhauMoi) || matKhauMoi.Length < 6)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới vào ô 'Mật Khẩu' (tối thiểu 6 ký tự)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string matKhauCu = Microsoft.VisualBasic.Interaction.InputBox("Nhập mật khẩu cũ của tài khoản:", "Xác nhận đổi mật khẩu", "");
            if (string.IsNullOrEmpty(matKhauCu)) return;

            bool isSuccess = employeeMng.DoiMatKhau(tenDangNhap, matKhauCu, matKhauMoi);

            if (isSuccess)
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGrid();
                BoChonDong();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại! Mật khẩu cũ không chính xác hoặc mật khẩu mới trùng mật khẩu cũ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object? sender, EventArgs e)
        {
            string tenDangNhap = txtTenLogIn.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenDangNhap))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản '{tenDangNhap}' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                bool isSuccess = employeeMng.XoaTaiKhoan(tenDangNhap);
                if (isSuccess)
                {
                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataGrid();
                    BoChonDong();
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object? sender, EventArgs e)
        {
            BoChonDong();
        }

        private void dgvNhanVien_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvNhanVien.Rows.Count)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString() ?? "";
                txtTenLogIn.Text = row.Cells["TenDangNhap"].Value?.ToString() ?? "";
                txtSDT.Text = row.Cells["SDT"].Value?.ToString() ?? "";
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString() ?? "";

                string gioiTinh = row.Cells["GioiTinh"].Value?.ToString() ?? "";
                if (gioiTinh.Equals("Nữ", StringComparison.OrdinalIgnoreCase))
                {
                    cboGioiTinh.SelectedItem = "Nữ";
                }
                else
                {
                    cboGioiTinh.SelectedItem = "Nam";
                }

                if (row.Cells["NgaySinh"].Value is DateTime ns)
                {
                    dtpNgaySinh.Value = ns;
                }
                else if (DateTime.TryParse(row.Cells["NgaySinh"].Value?.ToString(), out DateTime parsedDate))
                {
                    dtpNgaySinh.Value = parsedDate;
                }
                else
                {
                    dtpNgaySinh.Value = new DateTime(2000, 1, 1);
                }

                txtTenLogIn.ReadOnly = true;
            }
        }
    }
}
