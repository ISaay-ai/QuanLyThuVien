namespace QuanLyThuVien
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            MenuBtn = new PictureBox();
            HomeContainer = new Panel();
            Baocaothongke = new Panel();
            BaocaothongkeBtn = new Button();
            Quanlinhanvien = new Panel();
            QuanlinhanvienBtn = new Button();
            Docgia = new Panel();
            DocgiaBtn = new Button();
            Quanlisach = new Panel();
            QuanlisachBtn = new Button();
            Muontrasach = new Panel();
            MuontrasachBtn = new Button();
            Trangchu = new Panel();
            TrangchuBtn = new Button();
            panel2 = new Panel();
            button2 = new Button();
            panel3 = new Panel();
            button1 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            Titlebar = new Panel();
            homeTimer = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuBtn).BeginInit();
            HomeContainer.SuspendLayout();
            Baocaothongke.SuspendLayout();
            Quanlinhanvien.SuspendLayout();
            Docgia.SuspendLayout();
            Quanlisach.SuspendLayout();
            Muontrasach.SuspendLayout();
            Trangchu.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(53, 162, 184);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(HomeContainer);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(310, 929);
            sidebar.MinimumSize = new Size(112, 929);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(310, 929);
            sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(MenuBtn);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 82);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(129, 23);
            label1.Name = "label1";
            label1.Size = new Size(102, 45);
            label1.TabIndex = 2;
            label1.Text = "Menu";
            // 
            // MenuBtn
            // 
            MenuBtn.Cursor = Cursors.Hand;
            MenuBtn.Image = (Image)resources.GetObject("MenuBtn.Image");
            MenuBtn.Location = new Point(19, 18);
            MenuBtn.Name = "MenuBtn";
            MenuBtn.Size = new Size(68, 50);
            MenuBtn.SizeMode = PictureBoxSizeMode.Zoom;
            MenuBtn.TabIndex = 1;
            MenuBtn.TabStop = false;
            MenuBtn.Click += MenuBtn_Click;
            // 
            // HomeContainer
            // 
            HomeContainer.BackColor = Color.FromArgb(53, 162, 184);
            HomeContainer.Controls.Add(Baocaothongke);
            HomeContainer.Controls.Add(Quanlinhanvien);
            HomeContainer.Controls.Add(Docgia);
            HomeContainer.Controls.Add(Quanlisach);
            HomeContainer.Controls.Add(Muontrasach);
            HomeContainer.Controls.Add(Trangchu);
            HomeContainer.Location = new Point(3, 91);
            HomeContainer.MaximumSize = new Size(313, 526);
            HomeContainer.MinimumSize = new Size(313, 81);
            HomeContainer.Name = "HomeContainer";
            HomeContainer.Size = new Size(313, 526);
            HomeContainer.TabIndex = 5;
            // 
            // Baocaothongke
            // 
            Baocaothongke.BackColor = Color.FromArgb(53, 162, 184);
            Baocaothongke.Controls.Add(BaocaothongkeBtn);
            Baocaothongke.Location = new Point(3, 452);
            Baocaothongke.Name = "Baocaothongke";
            Baocaothongke.Size = new Size(313, 82);
            Baocaothongke.TabIndex = 11;
            // 
            // BaocaothongkeBtn
            // 
            BaocaothongkeBtn.BackColor = Color.FromArgb(53, 162, 184);
            BaocaothongkeBtn.FlatStyle = FlatStyle.Flat;
            BaocaothongkeBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BaocaothongkeBtn.ForeColor = SystemColors.ButtonHighlight;
            BaocaothongkeBtn.Image = (Image)resources.GetObject("BaocaothongkeBtn.Image");
            BaocaothongkeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            BaocaothongkeBtn.Location = new Point(-12, -14);
            BaocaothongkeBtn.Name = "BaocaothongkeBtn";
            BaocaothongkeBtn.Padding = new Padding(55, 0, 0, 0);
            BaocaothongkeBtn.Size = new Size(344, 112);
            BaocaothongkeBtn.TabIndex = 8;
            BaocaothongkeBtn.Text = "           Báo cáo - Thống kê";
            BaocaothongkeBtn.TextAlign = ContentAlignment.MiddleLeft;
            BaocaothongkeBtn.UseVisualStyleBackColor = false;
            // 
            // Quanlinhanvien
            // 
            Quanlinhanvien.BackColor = Color.FromArgb(53, 162, 184);
            Quanlinhanvien.Controls.Add(QuanlinhanvienBtn);
            Quanlinhanvien.Location = new Point(0, 360);
            Quanlinhanvien.Name = "Quanlinhanvien";
            Quanlinhanvien.Size = new Size(313, 86);
            Quanlinhanvien.TabIndex = 10;
            // 
            // QuanlinhanvienBtn
            // 
            QuanlinhanvienBtn.BackColor = Color.FromArgb(53, 162, 184);
            QuanlinhanvienBtn.FlatStyle = FlatStyle.Flat;
            QuanlinhanvienBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuanlinhanvienBtn.ForeColor = SystemColors.ButtonHighlight;
            QuanlinhanvienBtn.Image = (Image)resources.GetObject("QuanlinhanvienBtn.Image");
            QuanlinhanvienBtn.ImageAlign = ContentAlignment.MiddleLeft;
            QuanlinhanvienBtn.Location = new Point(-8, 0);
            QuanlinhanvienBtn.Name = "QuanlinhanvienBtn";
            QuanlinhanvienBtn.Padding = new Padding(55, 0, 0, 0);
            QuanlinhanvienBtn.Size = new Size(344, 86);
            QuanlinhanvienBtn.TabIndex = 4;
            QuanlinhanvienBtn.Text = "           Quản lí nhân viên";
            QuanlinhanvienBtn.TextAlign = ContentAlignment.MiddleLeft;
            QuanlinhanvienBtn.UseVisualStyleBackColor = false;
            // 
            // Docgia
            // 
            Docgia.BackColor = Color.FromArgb(53, 162, 184);
            Docgia.Controls.Add(DocgiaBtn);
            Docgia.Location = new Point(3, 268);
            Docgia.Name = "Docgia";
            Docgia.Size = new Size(313, 86);
            Docgia.TabIndex = 9;
            // 
            // DocgiaBtn
            // 
            DocgiaBtn.BackColor = Color.FromArgb(53, 162, 184);
            DocgiaBtn.FlatStyle = FlatStyle.Flat;
            DocgiaBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DocgiaBtn.ForeColor = SystemColors.ButtonHighlight;
            DocgiaBtn.Image = Properties.Resources.pupil_1_;
            DocgiaBtn.ImageAlign = ContentAlignment.MiddleLeft;
            DocgiaBtn.Location = new Point(-13, 3);
            DocgiaBtn.Name = "DocgiaBtn";
            DocgiaBtn.Padding = new Padding(55, 0, 0, 0);
            DocgiaBtn.Size = new Size(344, 95);
            DocgiaBtn.TabIndex = 4;
            DocgiaBtn.Text = "           Độc giả";
            DocgiaBtn.TextAlign = ContentAlignment.MiddleLeft;
            DocgiaBtn.UseVisualStyleBackColor = false;
            // 
            // Quanlisach
            // 
            Quanlisach.Controls.Add(QuanlisachBtn);
            Quanlisach.Location = new Point(0, 83);
            Quanlisach.Name = "Quanlisach";
            Quanlisach.Size = new Size(313, 82);
            Quanlisach.TabIndex = 6;
            // 
            // QuanlisachBtn
            // 
            QuanlisachBtn.BackColor = Color.FromArgb(53, 162, 184);
            QuanlisachBtn.FlatStyle = FlatStyle.Flat;
            QuanlisachBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuanlisachBtn.ForeColor = SystemColors.ButtonHighlight;
            QuanlisachBtn.Image = Properties.Resources.book_1__1_;
            QuanlisachBtn.ImageAlign = ContentAlignment.MiddleLeft;
            QuanlisachBtn.Location = new Point(-8, 12);
            QuanlisachBtn.Name = "QuanlisachBtn";
            QuanlisachBtn.Padding = new Padding(55, 0, 0, 0);
            QuanlisachBtn.Size = new Size(337, 75);
            QuanlisachBtn.TabIndex = 3;
            QuanlisachBtn.Text = "          Quản lí sách";
            QuanlisachBtn.TextAlign = ContentAlignment.MiddleLeft;
            QuanlisachBtn.UseVisualStyleBackColor = false;
            // 
            // Muontrasach
            // 
            Muontrasach.BackColor = Color.FromArgb(53, 162, 184);
            Muontrasach.Controls.Add(MuontrasachBtn);
            Muontrasach.Location = new Point(0, 176);
            Muontrasach.Name = "Muontrasach";
            Muontrasach.Size = new Size(313, 86);
            Muontrasach.TabIndex = 8;
            // 
            // MuontrasachBtn
            // 
            MuontrasachBtn.BackColor = Color.FromArgb(53, 162, 184);
            MuontrasachBtn.FlatStyle = FlatStyle.Flat;
            MuontrasachBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MuontrasachBtn.ForeColor = SystemColors.ButtonHighlight;
            MuontrasachBtn.Image = Properties.Resources.book_2__1_;
            MuontrasachBtn.ImageAlign = ContentAlignment.MiddleLeft;
            MuontrasachBtn.Location = new Point(-10, 3);
            MuontrasachBtn.Name = "MuontrasachBtn";
            MuontrasachBtn.Padding = new Padding(55, 0, 0, 0);
            MuontrasachBtn.Size = new Size(355, 96);
            MuontrasachBtn.TabIndex = 5;
            MuontrasachBtn.Text = "           Mượn trả sách";
            MuontrasachBtn.TextAlign = ContentAlignment.MiddleLeft;
            MuontrasachBtn.UseVisualStyleBackColor = false;
            // 
            // Trangchu
            // 
            Trangchu.Controls.Add(TrangchuBtn);
            Trangchu.Location = new Point(0, 3);
            Trangchu.Name = "Trangchu";
            Trangchu.Size = new Size(313, 86);
            Trangchu.TabIndex = 1;
            // 
            // TrangchuBtn
            // 
            TrangchuBtn.BackColor = Color.FromArgb(53, 162, 184);
            TrangchuBtn.FlatStyle = FlatStyle.Flat;
            TrangchuBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TrangchuBtn.ForeColor = SystemColors.ButtonHighlight;
            TrangchuBtn.Image = (Image)resources.GetObject("TrangchuBtn.Image");
            TrangchuBtn.ImageAlign = ContentAlignment.MiddleLeft;
            TrangchuBtn.Location = new Point(-24, 2);
            TrangchuBtn.Name = "TrangchuBtn";
            TrangchuBtn.Padding = new Padding(55, 0, 0, 0);
            TrangchuBtn.Size = new Size(351, 95);
            TrangchuBtn.TabIndex = 7;
            TrangchuBtn.Text = "              Trang chủ";
            TrangchuBtn.TextAlign = ContentAlignment.MiddleLeft;
            TrangchuBtn.UseVisualStyleBackColor = false;
            TrangchuBtn.Click += TrangchuBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button2);
            panel2.Location = new Point(3, 623);
            panel2.Name = "panel2";
            panel2.Size = new Size(318, 95);
            panel2.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(53, 162, 184);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-23, 0);
            button2.Name = "button2";
            button2.Padding = new Padding(55, 0, 0, 0);
            button2.Size = new Size(344, 103);
            button2.TabIndex = 9;
            button2.Text = "              Cài đặt";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Location = new Point(3, 724);
            panel3.Name = "panel3";
            panel3.Size = new Size(318, 109);
            panel3.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(53, 162, 184);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-23, 3);
            button1.Name = "button1";
            button1.Padding = new Padding(55, 0, 0, 0);
            button1.Size = new Size(414, 103);
            button1.TabIndex = 10;
            button1.Text = "              Trợ giúp";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(3, 839);
            panel4.Name = "panel4";
            panel4.Size = new Size(307, 94);
            panel4.TabIndex = 11;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(53, 162, 184);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-24, -25);
            button3.Name = "button3";
            button3.Padding = new Padding(55, 0, 0, 0);
            button3.Size = new Size(374, 129);
            button3.TabIndex = 10;
            button3.Text = "               Về chúng tôi";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // Titlebar
            // 
            Titlebar.BackColor = Color.FromArgb(57, 169, 180);
            Titlebar.Dock = DockStyle.Top;
            Titlebar.Location = new Point(310, 0);
            Titlebar.Name = "Titlebar";
            Titlebar.Size = new Size(1084, 99);
            Titlebar.TabIndex = 4;
            // 
            // homeTimer
            // 
            homeTimer.Interval = 10;
            homeTimer.Tick += homeTimer_Tick;
            // 
            // FrmMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1394, 929);
            Controls.Add(Titlebar);
            Controls.Add(sidebar);
            Name = "FrmMain";
            Text = "FrmMain";
            WindowState = FormWindowState.Maximized;
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MenuBtn).EndInit();
            HomeContainer.ResumeLayout(false);
            Baocaothongke.ResumeLayout(false);
            Quanlinhanvien.ResumeLayout(false);
            Docgia.ResumeLayout(false);
            Quanlisach.ResumeLayout(false);
            Muontrasach.ResumeLayout(false);
            Trangchu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private PictureBox MenuBtn;
        private Label label1;
        private System.Windows.Forms.Timer sidebarTimer;
        private Panel Trangchu;
        private Panel Titlebar;
        private Panel HomeContainer;
        private Button QuanlisachBtn;
        private Button TrangchuBtn;
        private Button DocgiaBtn;
        private Button button8;
        private Button MuontrasachBtn;
        private Panel Quanlisach;
        private Panel Muontrasach;
        private Panel Docgia;
        private Panel Quanlinhanvien;
        private Button QuanlinhanvienBtn;
        private Panel Baocaothongke;
        private Button BaocaothongkeBtn;
        private Panel panel2;
        private Panel panel3;
        private Button button2;
        private System.Windows.Forms.Timer homeTimer;
        private Button button1;
        private Button button3;
        private Panel panel4;
    }
}