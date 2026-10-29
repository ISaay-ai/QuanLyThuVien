using System;
using System.Windows.Forms;
using QuanLyThuVien.BLL;

namespace QuanLyThuVien
{
    public partial class FrmLogin : Form
    {
        private readonly AuthenticationService authenticationService = new();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object? sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }

            try
            {
                var taiKhoan = authenticationService.Authenticate(username, password);
                if (taiKhoan is null)
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                    return;
                }

                Hide();
                using var mainForm = new FrmMain(taiKhoan);
                mainForm.ShowDialog(this);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối hoặc truy vấn cơ sở dữ liệu: " + ex.Message, "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkHienMatKhau_CheckedChanged(object? sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkHienMatKhau.Checked;
        }

        private void lnkQuenMatKhau_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            using var forgotPasswordForm = new FrmForgotPass();
            if (forgotPasswordForm.ShowDialog(this) == DialogResult.OK)
            {
                txtMatKhau.Clear();
                txtMatKhau.Focus();
            }
        }
    }
}
