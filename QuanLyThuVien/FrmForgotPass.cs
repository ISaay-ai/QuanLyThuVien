using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            textBox2.UseSystemPasswordChar = true;
            textBox3.UseSystemPasswordChar = true;
            AcceptButton = button1;
            button1.Click += ResetPasswordButton_Click;
            LoginNowLbl.LinkClicked += LoginNowLbl_LinkClicked;
        }

        private void ResetPasswordButton_Click(object? sender, EventArgs e)
        {
            var maNhanVien = textBox1.Text.Trim();
            var matKhauMoi = textBox2.Text;

            if (string.IsNullOrWhiteSpace(maNhanVien) || string.IsNullOrEmpty(matKhauMoi) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên và điền đầy đủ mật khẩu mới.", "Đặt lại mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (matKhauMoi != textBox3.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.", "Đặt lại mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Clear();
                textBox3.Focus();
                return;
            }

            try
            {
                if (!authenticationService.ResetPassword(maNhanVien, matKhauMoi))
                {
                    MessageBox.Show("Không tìm thấy mã nhân viên trong hệ thống.", "Đặt lại mật khẩu thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Đặt lại mật khẩu thành công.", "Đặt lại mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể cập nhật cơ sở dữ liệu. Vui lòng kiểm tra cấu hình kết nối.", "Lỗi đặt lại mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginNowLbl_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
