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

        /// <summary>
        /// Nhúng Form con vào pnlContent bên phải
        /// </summary>
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

        /// <summary>
        /// Nhấn nút "Thông tin tài khoản"
        /// </summary>
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

        /// <summary>
        /// Nhấn nút "Đăng xuất"
        /// </summary>
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
                // Reset lại vị trí con trỏ về mục Thông tin tài khoản
                pnlIndicator.Top = btnThongTinTaiKhoan.Top;
            }
        }

        /// <summary>
        /// Nút đóng 'X'
        /// </summary>
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.FromArgb(220, 53, 69);
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.FromArgb(115, 115, 115);
        }

        #region Vẽ Icon Đồ Họa Đẹp Mắt Cho Sidebar & Header

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
            using var pen = new Pen(Color.FromArgb(229, 231, 235), 1);
            e.Graphics.DrawLine(pen, 0, pnlHeader.Height - 1, pnlHeader.Width, pnlHeader.Height - 1);
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {
            using var pen = new Pen(Color.FromArgb(229, 231, 235), 1);
            e.Graphics.DrawLine(pen, pnlSidebar.Width - 1, 0, pnlSidebar.Width - 1, pnlSidebar.Height);
        }

        private void btnThongTinTaiKhoan_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color iconColor = (pnlIndicator.Top == btnThongTinTaiKhoan.Top)
                ? Color.FromArgb(0, 120, 215)
                : Color.FromArgb(107, 114, 128);

            using var brush = new SolidBrush(iconColor);
            using var pen = new Pen(iconColor, 1.8F);

            // Đầu người (vòng tròn)
            g.FillEllipse(brush, 19, 13, 10, 10);

            // Thân người (vòm cung vai)
            g.DrawArc(pen, 15, 23, 18, 14, 190, 160);
        }

        private void btnDangXuat_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color iconColor = Color.FromArgb(220, 53, 69); // Màu đỏ cảnh báo đăng xuất
            using var pen = new Pen(iconColor, 1.8F);
            using var brush = new SolidBrush(iconColor);

            // Khung cửa đăng xuất
            g.DrawLine(pen, 28, 13, 16, 13);
            g.DrawLine(pen, 16, 13, 16, 31);
            g.DrawLine(pen, 16, 31, 28, 31);

            // Mũi tên trỏ ra ngoài
            g.DrawLine(pen, 22, 22, 33, 22);
            Point[] arrowHead = new Point[]
            {
                new Point(30, 18),
                new Point(34, 22),
                new Point(30, 26)
            };
            g.DrawLines(pen, arrowHead);
        }

        #endregion
    }
}
