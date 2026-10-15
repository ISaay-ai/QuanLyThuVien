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
        public FrmMain()
        {
            InitializeComponent();
        }

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

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void HomeContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TrangchuBtn_Click_1(object sender, EventArgs e)
        {
            homeTimer.Start();
        }
    }
}
