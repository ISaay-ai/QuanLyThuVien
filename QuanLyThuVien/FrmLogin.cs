using QuanLyThuVien.BLL;

namespace QuanLyThuVien
{
    public partial class FrmLogin : Form
    {
        private readonly AuthenticationService authenticationService = new();

        public FrmLogin()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
            AcceptButton = button1;
            button1.Click += LoginButton_Click;
            ForgotPassLbl.LinkClicked += ForgotPassLbl_LinkClicked;
            ShowPassBox.CheckedChanged += ShowPassBox_CheckedChanged;
        }

        private void LoginButton_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên hoặc tên đăng nhập cùng mật khẩu.", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var taiKhoan = authenticationService.Authenticate(textBox1.Text.Trim(), textBox2.Text);
                if (taiKhoan is null)
                {
                    MessageBox.Show("Mã nhân viên hoặc mật khẩu không đúng.", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Clear();
                    textBox2.Focus();
                    return;
                }

                Hide();
                using var mainForm = new FrmMain(taiKhoan);
                mainForm.ShowDialog(this);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể kết nối hoặc truy vấn cơ sở dữ liệu. Vui lòng kiểm tra cấu hình kết nối.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ForgotPassLbl_LinkClicked(object? sender, LinkLabelLinkClickedEventArgs e)
        {
            using var forgotPasswordForm = new FrmForgotPass();
            forgotPasswordForm.ShowDialog(this);
        }

        private void ShowPassBox_CheckedChanged(object? sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !ShowPassBox.Checked;
        }
    }
}
