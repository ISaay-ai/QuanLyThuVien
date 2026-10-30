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
            if (cboGioiTinh.SelectedIndex < 0 && cboGioiTinh.Items.Count > 0)
                cboGioiTinh.SelectedIndex = 0;
            dtpNgaySinh.Value = new DateTime(2000, 1, 1);
            LoadDataGrid();
            BoChonDong();
        }

        private void LoadDataGrid()
        {
            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = employeeMng.LayDanhSach();
            DinhDangCotNhanVien();
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
