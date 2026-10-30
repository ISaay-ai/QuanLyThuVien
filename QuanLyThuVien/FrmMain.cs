using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyThuVien.DAL.Models;

namespace QuanLyThuVien
{
    public partial class FrmMain : Form
    {
        private bool sidebarExpand = true;
        private bool homeCollapsed = false;
        private readonly bool isAdmin;
        private readonly TaiKhoan currentUser;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private Form? currentChildForm = null;

        public FrmMain(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            currentUser = taiKhoan;
            isAdmin = string.Equals(taiKhoan.VaiTro, "Admin", StringComparison.OrdinalIgnoreCase);

            Quanlinhanvien.Visible = isAdmin;
            QuanlinhanvienBtn.Enabled = isAdmin;

            this.Text = $"Hệ thống quản lý thư viện - Người dùng: {taiKhoan.HoTen} [{(isAdmin ? "Quản trị viên (Admin)" : "Nhân viên")}]";

            // Gán sự kiện click cho các nút chức năng để mở form lên ViewPanel
            QuanlinhanvienBtn.Click += QuanlinhanvienBtn_Click;
            QuanlisachBtn.Click += QuanlisachBtn_Click;
            DocgiaBtn.Click += DocgiaBtn_Click;
            MuontrasachBtn.Click += MuontrasachBtn_Click;
            BaocaothongkeBtn.Click += BaocaothongkeBtn_Click;
            AboutBtn.Click += AboutBtn_Click;
            button2.Click += CaiDatBtn_Click;

            Title.MouseDown += Title_MouseDown;
            Title.MouseMove += Title_MouseMove;
            Title.MouseUp += Title_MouseUp;
            this.Resize += FrmMain_Resize;
            ViewPanel.Resize += (s, e) => CanChinhFormCon(currentChildForm);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            CapNhatViTriViewPanel();
            ShowHomeScreen();
        }

        private void FrmMain_Resize(object? sender, EventArgs e)
        {
            CapNhatViTriViewPanel();
        }

        private void CapNhatViTriViewPanel()
        {
            int left = sidebar.Width + 6;
            int top = Title.Height + 6;
            int width = Math.Max(400, this.ClientSize.Width - left - 10);
            int height = Math.Max(300, this.ClientSize.Height - top - 10);

            ViewPanel.Location = new Point(left, top);
            ViewPanel.Size = new Size(width, height);

            CanChinhFormCon(currentChildForm);
        }
        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                Form oldForm = currentChildForm;
                currentChildForm = null;
                oldForm.Close();
                oldForm.Dispose();
            }

            currentChildForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BackColor = ViewPanel.BackColor;

            // Bật thanh cuộn tự động trên ViewPanel
            ViewPanel.AutoScroll = true;

            ViewPanel.Controls.Clear();
            ViewPanel.Controls.Add(childForm);
            ViewPanel.Tag = childForm;

            childForm.FormClosed += (s, e) =>
            {
                if (currentChildForm == childForm)
                {
                    currentChildForm = null;
                    ShowHomeScreen();
                }
            };

            // Đưa form con lên lớp trên cùng và hiển thị
            childForm.BringToFront();
            childForm.Show();
        }
        private void CanChinhFormCon(Form? childForm)
        {
            if (childForm == null || ViewPanel == null) return;

            if (childForm.Dock == DockStyle.None)
            {
                int x = Math.Max(0, (ViewPanel.ClientSize.Width - childForm.Width) / 2);
                int y = Math.Max(0, (ViewPanel.ClientSize.Height - childForm.Height) / 2);
                childForm.Location = new Point(x, y);
            }
        }

        public void ShowHomeScreen()
        {
            if (currentChildForm != null)
            {
                Form oldForm = currentChildForm;
                currentChildForm = null;
                oldForm.Close();
                oldForm.Dispose();
            }

            ViewPanel.Controls.Clear();

            // Khung chào mừng trang chủ trên ViewPanel
            var pnlHome = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(30)
            };

            var lblWelcome = new Label
            {
                Text = "CHÀO MỪNG ĐẾN VỚI HỆ THỐNG QUẢN LÝ THƯ VIỆN - GenLib",
                Font = new Font("Segoe UI", 20F, FontStyle.Bold),
                ForeColor = Color.FromArgb(53, 162, 184),
                Dock = DockStyle.Top,
                Height = 60,
                TextAlign = ContentAlignment.MiddleCenter
            };

            var lblUser = new Label
            {
                Text = $"Tài khoản đăng nhập: {currentUser.HoTen}  |  Vai trò: {(isAdmin ? "Quản trị viên" : "Nhân viên thư viện")}",
                Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                ForeColor = Color.FromArgb(80, 80, 80),
                Dock = DockStyle.Top,
                Height = 40,
                TextAlign = ContentAlignment.MiddleCenter
            };

            pnlHome.Controls.Add(lblUser);
            pnlHome.Controls.Add(lblWelcome);

            ViewPanel.Controls.Add(pnlHome);
        }

        // Xử lý thanh sidebar trượt ra vào
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
            CapNhatViTriViewPanel();
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        // Xử lý menu home mở rộng/thu gọn
        private void homeTimer_Tick(object sender, EventArgs e)
        {
            if (homeCollapsed)
            {
                HomeContainer.Height += 10;
                if (HomeContainer.Height >= HomeContainer.MaximumSize.Height)
                {
                    homeCollapsed = false;
                    homeTimer.Stop();
                }
            }
            else
            {
                HomeContainer.Height -= 10;
                if (HomeContainer.Height <= HomeContainer.MinimumSize.Height)
                {
                    homeCollapsed = true;
                    homeTimer.Stop();
                }
            }
        }

        private void TrangchuBtn_Click_1(object sender, EventArgs e)
        {
            homeTimer.Start();
            ShowHomeScreen();
        }

        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }

        private void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Title_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = false;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuanlinhanvienBtn_Click(object? sender, EventArgs e)
        {
            if (!isAdmin)
            {
                MessageBox.Show("Chỉ tài khoản Quản trị viên (Admin) mới có quyền truy cập chức năng Quản lý nhân viên!", "Từ chối truy cập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenChildForm(new Views.QuanlinhanvienView());
        }

        private void QuanlisachBtn_Click(object? sender, EventArgs e)
        {
            OpenChildForm(new Views.QuanlisachView());
        }

        private void DocgiaBtn_Click(object? sender, EventArgs e)
        {
            OpenChildForm(new Views.DocgiaView());
        }

        private void MuontrasachBtn_Click(object? sender, EventArgs e)
        {
            OpenChildForm(new Views.MuontrasachViewcs());
        }

        private void BaocaothongkeBtn_Click(object? sender, EventArgs e)
        {
            OpenChildForm(new Views.BaocaothongkeView());
        }


        private void AboutBtn_Click(object? sender, EventArgs e)
        {
            OpenChildForm(new Views.AboutView());
        }

        private void CaiDatBtn_Click(object? sender, EventArgs e)
        {
            OpenChildForm(new GUI.FrmSetting(currentUser));
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
