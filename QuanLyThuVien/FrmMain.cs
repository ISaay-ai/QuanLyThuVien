using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class FrmMain : Form
    {
        bool sidebarExpand;
        bool homeCollapsed;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public FrmMain()
        {
            InitializeComponent();
            Title.MouseDown += Title_MouseDown;
            Title.MouseMove += Title_MouseMove;
            Title.MouseUp += Title_MouseUp;
        }
        //Hàm xử lý thanh sidebar trượt ra vào
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
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        //Hàm xử lý thanh home trượt ra vào
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

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
