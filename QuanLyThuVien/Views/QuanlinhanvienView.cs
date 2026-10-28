using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            this.btnDoiMK.Click += btnDoiMK_Click;
            this.btnXoa.Click += btnXoa_Click;
        }
        private void QuanlinhanvienView_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }
        private void LoadDataGrid()
        {
            dgvNhanVien.DataSource = null;
            dgvNhanVien.DataSource = employeeMng.LayDanhSach();

            // Tùy chỉnh hiển thị cột (nếu cần ẩn mật khẩu)
            if (dgvNhanVien.Columns["MatKhau"] != null)
            {
                dgvNhanVien.Columns["MatKhau"].Visible = false;
            }
        }
        private void ClearInputs()
        {
            txtHoTen.Clear();
            txtTenLogIn.Clear();
            txtMK.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            rdoNam.Checked = true;
            dtpNgaySinh.Value = DateTime.Now;
            txtTenLogIn.ReadOnly = false; // Mở lại ô tên đăng nhập
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;
            string tenDangNhap = txtTenLogIn.Text;
            string matKhau = txtMK.Text;
            string gioTinh = rdoNam.Checked ? "Nam" : (rdoNu.Checked ? "Nữ" : "");
            string sdt = txtSDT.Text;
            string diaChi = txtDiaChi.Text;
            string email = txtEmail.Text;

            bool isSuccess = employeeMng.DangKy(tenDangNhap, matKhau, hoTen, gioTinh, sdt, email, diaChi);

            if (isSuccess)
            {
                MessageBox.Show("Thêm nhân viên/Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGrid();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại! Vui lòng kiểm tra:\n- Tên đăng nhập và mật khẩu không được trống.\n- Mật khẩu phải từ 6 ký tự trở lên.\n- Tên đăng nhập có thể đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
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

            // Nhập mật khẩu cũ xác nhận
            string matKhauCu = Microsoft.VisualBasic.Interaction.InputBox("Nhập mật khẩu cũ của tài khoản:", "Xác nhận đổi mật khẩu", "");
            if (string.IsNullOrEmpty(matKhauCu)) return;

            bool isSuccess = employeeMng.DoiMatKhau(tenDangNhap, matKhauCu, matKhauMoi);

            if (isSuccess)
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGrid();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại! Mật khẩu cũ không chính xác hoặc mật khẩu mới trùng mật khẩu cũ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
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
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvNhanVien.Rows.Count)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString() ?? "";
                txtTenLogIn.Text = row.Cells["TenDangNhap"].Value?.ToString() ?? "";
                txtSDT.Text = row.Cells["SDT"].Value?.ToString() ?? "";
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";

                string gioiTinh = row.Cells["GioiTinh"].Value?.ToString() ?? "";
                if (gioiTinh.Equals("Nam", StringComparison.OrdinalIgnoreCase))
                {
                    rdoNam.Checked = true;
                }
                else if (gioiTinh.Equals("Nữ", StringComparison.OrdinalIgnoreCase))
                {
                    rdoNu.Checked = true;
                }

                // Khóa sửa Tên đăng nhập khi đang chọn dòng có sẵn
                txtTenLogIn.ReadOnly = true;
            }
        }
    }
}
