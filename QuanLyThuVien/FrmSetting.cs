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
        private readonly bool _showAboutInitially;
        private Form? _currentChildForm = null;

        public FrmSetting() : this(null, false)
        {
        }

        public FrmSetting(TaiKhoan? currentUser, bool showAbout = false)
        {
            InitializeComponent();
            _currentUser = currentUser;
            _showAboutInitially = showAbout;
        }

        private void FrmSetting_Load(object? sender, EventArgs e)
        {
            if (_showAboutInitially)
            {
                btnGioiThieu_Click(this, EventArgs.Empty);
            }
            else
            {
                btnThongTinTaiKhoan_Click(this, EventArgs.Empty);
            }
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

            btnGioiThieu.BackColor = Color.Transparent;
            btnGioiThieu.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            btnGioiThieu.ForeColor = Color.FromArgb(75, 85, 99);

            btnDangXuat.BackColor = Color.Transparent;
            btnDangXuat.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            btnDangXuat.ForeColor = Color.FromArgb(75, 85, 99);

            pnlSidebar.Invalidate();
            OpenChildForm(new Thongtincanhan(_currentUser));
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            pnlIndicator.Top = btnGioiThieu.Top;
            pnlIndicator.Visible = true;

            btnGioiThieu.BackColor = Color.White;
            btnGioiThieu.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnGioiThieu.ForeColor = Color.FromArgb(24, 24, 27);

            btnThongTinTaiKhoan.BackColor = Color.Transparent;
            btnThongTinTaiKhoan.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            btnThongTinTaiKhoan.ForeColor = Color.FromArgb(75, 85, 99);

            btnDangXuat.BackColor = Color.Transparent;
            btnDangXuat.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            btnDangXuat.ForeColor = Color.FromArgb(75, 85, 99);

            pnlSidebar.Invalidate();
            OpenChildForm(new Vechungtoi());
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
                if (_currentChildForm is Vechungtoi)
                    pnlIndicator.Top = btnGioiThieu.Top;
                else
                    pnlIndicator.Top = btnThongTinTaiKhoan.Top;
            }
        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
