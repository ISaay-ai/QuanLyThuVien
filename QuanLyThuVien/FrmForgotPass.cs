using System;
using System.Windows.Forms;
using QuanLyThuVien.BLL;

namespace QuanLyThuVien
{
    public partial class FrmForgotPass : Form
    {
        private readonly AuthenticationService authenticationService = new();

        public FrmForgotPass()
        {
            InitializeComponent();
        }

        private void btnDatLaiMatKhau_Click(object? sender, EventArgs e)
        {
            var tenDangNhap = txtTenDangNhap.Text.Trim();
            var matKhauMoi = txtMatKhauMoi.Text;
            var xacNhan = txtXacNhanMatKhau.Text;

            if (string.IsNullOrWhiteSpace(tenDangNhap))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return;
            }

            if (string.IsNullOrEmpty(matKhauMoi))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhauMoi.Focus();
                return;
            }

            if (matKhauMoi != xacNhan)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtXacNhanMatKhau.Clear();
                txtXacNhanMatKhau.Focus();
                return;
            }

            try
            {
                if (authenticationService.ResetPassword(tenDangNhap, matKhauMoi, out string thongBaoLoi))
                {
                    MessageBox.Show("Đặt lại mật khẩu thành công! Vui lòng sử dụng mật khẩu mới để đăng nhập.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show(thongBaoLoi, "Đặt lại mật khẩu thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi đặt lại mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkHienMatKhau_CheckedChanged(object? sender, EventArgs e)
        {
            txtMatKhauMoi.UseSystemPasswordChar = !chkHienMatKhau.Checked;
            txtXacNhanMatKhau.UseSystemPasswordChar = !chkHienMatKhau.Checked;
        }

        private void lnkQuayLai_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
