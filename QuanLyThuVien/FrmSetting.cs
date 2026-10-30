using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using QuanLyThuVien.DAL.Models;
using QuanLyThuVien.SubViews;

namespace QuanLyThuVien.GUI
{
    public partial class FrmSetting : Form
    {
        private readonly TaiKhoan? _currentUser;
        private Form? _currentChildForm = null;

        public FrmSetting() : this(null)
        {
        }

        public FrmSetting(TaiKhoan? currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
        }

        private void FrmSetting_Load(object? sender, EventArgs e)
        {
            // Mở mặc định màn hình Thông tin cá nhân
            btnThongTinTaiKhoan_Click(this, EventArgs.Empty);
        }
        private void OpenChildForm(Form childForm)
        {
            if (_currentChildForm != null)
            {
                Form oldForm = _currentChildForm;
                _currentChildForm = null;
                oldForm.Close();
                oldForm.Dispose();
            }

            _currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BackColor = Color.White;

            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }
        private void btnThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            pnlIndicator.Top = btnThongTinTaiKhoan.Top;
            pnlIndicator.Visible = true;

            btnThongTinTaiKhoan.BackColor = Color.White;
            btnThongTinTaiKhoan.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnThongTinTaiKhoan.ForeColor = Color.FromArgb(24, 24, 27);

            btnDangXuat.BackColor = Color.Transparent;
            btnDangXuat.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            btnDangXuat.ForeColor = Color.FromArgb(75, 85, 99);

            OpenChildForm(new Thongtincanhan(_currentUser));
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            pnlIndicator.Top = btnDangXuat.Top;

            var result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất khỏi hệ thống?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
            else
            {
                pnlIndicator.Top = btnThongTinTaiKhoan.Top;
            }
        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
