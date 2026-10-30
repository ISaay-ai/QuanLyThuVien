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
            sidebarTimer = new System.Windows.Forms.Timer(components);
            homeTimer = new System.Windows.Forms.Timer(components);
            sidebar = new FlowLayoutPanel();
            MenuContainer = new Panel();
            Menu = new Label();
            MenuBtn = new PictureBox();
            HomeContainer = new Panel();
            Baocaothongke = new Panel();
            BaocaothongkeBtn = new Button();
            Muontrasach = new Panel();
            MuontrasachBtn = new Button();
            Docgia = new Panel();
            DocgiaBtn = new Button();
            Quanlisach = new Panel();
            QuanlisachBtn = new Button();
            Trangchu = new Panel();
            TrangchuBtn = new Button();
            Setting = new Panel();
            button2 = new Button();
            Chatbot = new Panel();
            Chatbotbtn = new Button();
            Quanlinhanvien = new Panel();
            QuanlinhanvienBtn = new Button();
            Title = new Panel();
            TitleLbl = new Label();
            pictureBox1 = new PictureBox();
            MinimizeBtn = new PictureBox();
            ExitBtn = new PictureBox();
            ViewPanel = new Panel();
            sidebar.SuspendLayout();
            MenuContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuBtn).BeginInit();
            HomeContainer.SuspendLayout();
            Baocaothongke.SuspendLayout();
            Muontrasach.SuspendLayout();
            Docgia.SuspendLayout();
            Quanlisach.SuspendLayout();
            Trangchu.SuspendLayout();
            Setting.SuspendLayout();
            Chatbot.SuspendLayout();
            Quanlinhanvien.SuspendLayout();
            Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExitBtn).BeginInit();
            SuspendLayout();
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // homeTimer
            // 
            homeTimer.Interval = 10;
            homeTimer.Tick += homeTimer_Tick;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(53, 162, 184);
            sidebar.Controls.Add(MenuContainer);
            sidebar.Controls.Add(HomeContainer);
            sidebar.Controls.Add(Setting);
            sidebar.Controls.Add(Chatbot);
            sidebar.Controls.Add(Quanlinhanvien);
            sidebar.Location = new Point(0, 103);
            sidebar.MinimumSize = new Size(112, 929);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(310, 1116);
            sidebar.TabIndex = 0;
            // 
            // MenuContainer
            // 
            MenuContainer.Controls.Add(Menu);
            MenuContainer.Controls.Add(MenuBtn);
            MenuContainer.Dock = DockStyle.Top;
            MenuContainer.Location = new Point(3, 3);
            MenuContainer.Name = "MenuContainer";
            MenuContainer.Size = new Size(313, 104);
            MenuContainer.TabIndex = 0;
            // 
            // Menu
            // 
            Menu.AutoSize = true;
            Menu.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Menu.ForeColor = SystemColors.ButtonHighlight;
            Menu.Location = new Point(137, 28);
            Menu.Name = "Menu";
            Menu.Size = new Size(102, 45);
            Menu.TabIndex = 2;
            Menu.Text = "Menu";
            // 
            // MenuBtn
            // 
            MenuBtn.Cursor = Cursors.Hand;
            MenuBtn.Image = (Image)resources.GetObject("MenuBtn.Image");
            MenuBtn.Location = new Point(19, 28);
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
            HomeContainer.Controls.Add(Muontrasach);
            HomeContainer.Controls.Add(Docgia);
            HomeContainer.Controls.Add(Quanlisach);
            HomeContainer.Controls.Add(Trangchu);
            HomeContainer.Dock = DockStyle.Top;
            HomeContainer.Location = new Point(3, 113);
            HomeContainer.MaximumSize = new Size(313, 415);
            HomeContainer.MinimumSize = new Size(313, 81);
            HomeContainer.Name = "HomeContainer";
            HomeContainer.Size = new Size(313, 415);
            HomeContainer.TabIndex = 5;
            // 
            // Baocaothongke
            // 
            Baocaothongke.Controls.Add(BaocaothongkeBtn);
            Baocaothongke.Dock = DockStyle.Top;
            Baocaothongke.Location = new Point(0, 332);
            Baocaothongke.Name = "Baocaothongke";
            Baocaothongke.Size = new Size(313, 79);
            Baocaothongke.TabIndex = 10;
            // 
            // BaocaothongkeBtn
            // 
            BaocaothongkeBtn.BackColor = Color.FromArgb(53, 162, 184);
            BaocaothongkeBtn.FlatStyle = FlatStyle.Flat;
            BaocaothongkeBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BaocaothongkeBtn.ForeColor = SystemColors.ButtonHighlight;
            BaocaothongkeBtn.Image = (Image)resources.GetObject("BaocaothongkeBtn.Image");
            BaocaothongkeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            BaocaothongkeBtn.Location = new Point(-6, 1);
            BaocaothongkeBtn.Name = "BaocaothongkeBtn";
            BaocaothongkeBtn.Padding = new Padding(55, 0, 0, 0);
            BaocaothongkeBtn.Size = new Size(319, 82);
            BaocaothongkeBtn.TabIndex = 8;
            BaocaothongkeBtn.Text = "           Báo cáo - Thống kê";
            BaocaothongkeBtn.TextAlign = ContentAlignment.MiddleLeft;
            BaocaothongkeBtn.UseVisualStyleBackColor = false;
            // 
            // Muontrasach
            // 
            Muontrasach.Controls.Add(MuontrasachBtn);
            Muontrasach.Dock = DockStyle.Top;
            Muontrasach.Location = new Point(0, 253);
            Muontrasach.Name = "Muontrasach";
            Muontrasach.Size = new Size(313, 79);
            Muontrasach.TabIndex = 9;
            // 
            // MuontrasachBtn
            // 
            MuontrasachBtn.BackColor = Color.FromArgb(53, 162, 184);
            MuontrasachBtn.FlatStyle = FlatStyle.Flat;
            MuontrasachBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MuontrasachBtn.ForeColor = SystemColors.ButtonHighlight;
            MuontrasachBtn.Image = GUI.Properties.Resources.book_2__1_;
            MuontrasachBtn.ImageAlign = ContentAlignment.MiddleLeft;
            MuontrasachBtn.Location = new Point(-4, 0);
            MuontrasachBtn.Name = "MuontrasachBtn";
            MuontrasachBtn.Padding = new Padding(55, 0, 0, 0);
            MuontrasachBtn.Size = new Size(317, 87);
            MuontrasachBtn.TabIndex = 5;
            MuontrasachBtn.Text = "           Mượn trả sách";
            MuontrasachBtn.TextAlign = ContentAlignment.MiddleLeft;
            MuontrasachBtn.UseVisualStyleBackColor = false;
            // 
            // Docgia
            // 
            Docgia.Controls.Add(DocgiaBtn);
            Docgia.Dock = DockStyle.Top;
            Docgia.Location = new Point(0, 174);
            Docgia.Name = "Docgia";
            Docgia.Size = new Size(313, 79);
            Docgia.TabIndex = 8;
            // 
            // DocgiaBtn
            // 
            DocgiaBtn.BackColor = Color.FromArgb(53, 162, 184);
            DocgiaBtn.FlatStyle = FlatStyle.Flat;
            DocgiaBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DocgiaBtn.ForeColor = SystemColors.ButtonHighlight;
            DocgiaBtn.Image = GUI.Properties.Resources.pupil_1_;
            DocgiaBtn.ImageAlign = ContentAlignment.MiddleLeft;
            DocgiaBtn.Location = new Point(-5, 0);
            DocgiaBtn.Name = "DocgiaBtn";
            DocgiaBtn.Padding = new Padding(55, 0, 0, 0);
            DocgiaBtn.Size = new Size(318, 93);
            DocgiaBtn.TabIndex = 4;
            DocgiaBtn.Text = "           Độc giả";
            DocgiaBtn.TextAlign = ContentAlignment.MiddleLeft;
            DocgiaBtn.UseVisualStyleBackColor = false;
            // 
            // Quanlisach
            // 
            Quanlisach.Controls.Add(QuanlisachBtn);
            Quanlisach.Dock = DockStyle.Top;
            Quanlisach.Location = new Point(0, 95);
            Quanlisach.Name = "Quanlisach";
            Quanlisach.Size = new Size(313, 79);
            Quanlisach.TabIndex = 7;
            // 
            // QuanlisachBtn
            // 
            QuanlisachBtn.BackColor = Color.FromArgb(53, 162, 184);
            QuanlisachBtn.FlatStyle = FlatStyle.Flat;
            QuanlisachBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuanlisachBtn.ForeColor = SystemColors.ButtonHighlight;
            QuanlisachBtn.Image = GUI.Properties.Resources.book_1__1_;
            QuanlisachBtn.ImageAlign = ContentAlignment.MiddleLeft;
            QuanlisachBtn.Location = new Point(-4, -9);
            QuanlisachBtn.Name = "QuanlisachBtn";
            QuanlisachBtn.Padding = new Padding(55, 0, 0, 0);
            QuanlisachBtn.Size = new Size(317, 90);
            QuanlisachBtn.TabIndex = 3;
            QuanlisachBtn.Text = "          Quản lí sách";
            QuanlisachBtn.TextAlign = ContentAlignment.MiddleLeft;
            QuanlisachBtn.UseVisualStyleBackColor = false;
            // 
            // Trangchu
            // 
            Trangchu.Controls.Add(TrangchuBtn);
            Trangchu.Dock = DockStyle.Top;
            Trangchu.Location = new Point(0, 0);
            Trangchu.Name = "Trangchu";
            Trangchu.Size = new Size(313, 95);
            Trangchu.TabIndex = 6;
            // 
            // TrangchuBtn
            // 
            TrangchuBtn.BackColor = Color.FromArgb(53, 162, 184);
            TrangchuBtn.FlatStyle = FlatStyle.Flat;
            TrangchuBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TrangchuBtn.ForeColor = SystemColors.ButtonHighlight;
            TrangchuBtn.Image = (Image)resources.GetObject("TrangchuBtn.Image");
            TrangchuBtn.ImageAlign = ContentAlignment.MiddleLeft;
            TrangchuBtn.Location = new Point(-8, 0);
            TrangchuBtn.Name = "TrangchuBtn";
            TrangchuBtn.Padding = new Padding(40, 0, 0, 0);
            TrangchuBtn.Size = new Size(321, 95);
            TrangchuBtn.TabIndex = 7;
            TrangchuBtn.Text = "              Trang chủ";
            TrangchuBtn.TextAlign = ContentAlignment.MiddleLeft;
            TrangchuBtn.UseVisualStyleBackColor = false;
            TrangchuBtn.Click += TrangchuBtn_Click_1;
            // 
            // Setting
            // 
            Setting.Controls.Add(button2);
            Setting.Location = new Point(3, 534);
            Setting.Name = "Setting";
            Setting.Size = new Size(313, 95);
            Setting.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(53, 162, 184);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-8, 0);
            button2.Name = "button2";
            button2.Padding = new Padding(40, 0, 0, 0);
            button2.Size = new Size(321, 95);
            button2.TabIndex = 9;
            button2.Text = "              Cài đặt";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // Chatbot
            // 
            Chatbot.Controls.Add(Chatbotbtn);
            Chatbot.Location = new Point(3, 635);
            Chatbot.Name = "Chatbot";
            Chatbot.Size = new Size(313, 95);
            Chatbot.TabIndex = 6;
            // 
            // Chatbotbtn
            // 
            Chatbotbtn.BackColor = Color.FromArgb(53, 162, 184);
            Chatbotbtn.FlatStyle = FlatStyle.Flat;
            Chatbotbtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Chatbotbtn.ForeColor = SystemColors.ButtonHighlight;
            Chatbotbtn.Image = (Image)resources.GetObject("Chatbotbtn.Image");
            Chatbotbtn.ImageAlign = ContentAlignment.MiddleLeft;
            Chatbotbtn.Location = new Point(-8, -2);
            Chatbotbtn.Name = "Chatbotbtn";
            Chatbotbtn.Padding = new Padding(40, 0, 0, 0);
            Chatbotbtn.Size = new Size(321, 95);
            Chatbotbtn.TabIndex = 9;
            Chatbotbtn.Text = "              AI Chatbot";
            Chatbotbtn.TextAlign = ContentAlignment.MiddleLeft;
            Chatbotbtn.UseVisualStyleBackColor = false;
            // 
            // Quanlinhanvien
            // 
            Quanlinhanvien.Controls.Add(QuanlinhanvienBtn);
            Quanlinhanvien.Location = new Point(3, 736);
            Quanlinhanvien.Name = "Quanlinhanvien";
            Quanlinhanvien.Size = new Size(313, 95);
            Quanlinhanvien.TabIndex = 11;
            // 
            // QuanlinhanvienBtn
            // 
            QuanlinhanvienBtn.BackColor = Color.FromArgb(53, 162, 184);
            QuanlinhanvienBtn.FlatStyle = FlatStyle.Flat;
            QuanlinhanvienBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuanlinhanvienBtn.ForeColor = SystemColors.ButtonHighlight;
            QuanlinhanvienBtn.Image = (Image)resources.GetObject("QuanlinhanvienBtn.Image");
            QuanlinhanvienBtn.ImageAlign = ContentAlignment.MiddleLeft;
            QuanlinhanvienBtn.Location = new Point(-6, -12);
            QuanlinhanvienBtn.Name = "QuanlinhanvienBtn";
            QuanlinhanvienBtn.Padding = new Padding(40, 0, 0, 0);
            QuanlinhanvienBtn.Size = new Size(321, 103);
            QuanlinhanvienBtn.TabIndex = 4;
            QuanlinhanvienBtn.Text = "              Quản lí nhân viên";
            QuanlinhanvienBtn.TextAlign = ContentAlignment.MiddleLeft;
            QuanlinhanvienBtn.UseVisualStyleBackColor = false;
            // 
            // Title
            // 
            Title.BackColor = Color.FromArgb(53, 162, 184);
            Title.Controls.Add(TitleLbl);
            Title.Controls.Add(pictureBox1);
            Title.Controls.Add(MinimizeBtn);
            Title.Controls.Add(ExitBtn);
            Title.Dock = DockStyle.Top;
            Title.Location = new Point(0, 0);
            Title.Name = "Title";
            Title.Size = new Size(1443, 104);
            Title.TabIndex = 1;
            Title.MouseDown += Title_MouseDown;
            Title.MouseMove += Title_MouseMove;
            Title.MouseUp += Title_MouseUp;
            // 
            // TitleLbl
            // 
            TitleLbl.AutoSize = true;
            TitleLbl.BackColor = Color.FromArgb(53, 162, 184);
            TitleLbl.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLbl.ForeColor = SystemColors.ButtonHighlight;
            TitleLbl.Location = new Point(528, 21);
            TitleLbl.Name = "TitleLbl";
            TitleLbl.Size = new Size(467, 50);
            TitleLbl.TabIndex = 3;
            TitleLbl.Text = "Hệ thống quản lí thư viện";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // MinimizeBtn
            // 
            MinimizeBtn.Image = (Image)resources.GetObject("MinimizeBtn.Image");
            MinimizeBtn.Location = new Point(1320, 35);
            MinimizeBtn.Name = "MinimizeBtn";
            MinimizeBtn.Size = new Size(33, 36);
            MinimizeBtn.SizeMode = PictureBoxSizeMode.Zoom;
            MinimizeBtn.TabIndex = 1;
            MinimizeBtn.TabStop = false;
            MinimizeBtn.Click += MinimizeBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Image = (Image)resources.GetObject("ExitBtn.Image");
            ExitBtn.Location = new Point(1384, 35);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(33, 36);
            ExitBtn.SizeMode = PictureBoxSizeMode.Zoom;
            ExitBtn.TabIndex = 0;
            ExitBtn.TabStop = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // ViewPanel
            // 
            ViewPanel.BackColor = Color.White;
            ViewPanel.Location = new Point(316, 110);
            ViewPanel.Name = "ViewPanel";
            ViewPanel.Size = new Size(946, 1003);
            ViewPanel.TabIndex = 2;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 248);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1443, 1100);
            Controls.Add(ViewPanel);
            Controls.Add(Title);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMain";
            Load += FrmMain_Load;
            sidebar.ResumeLayout(false);
            MenuContainer.ResumeLayout(false);
            MenuContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MenuBtn).EndInit();
            HomeContainer.ResumeLayout(false);
            Baocaothongke.ResumeLayout(false);
            Muontrasach.ResumeLayout(false);
            Docgia.ResumeLayout(false);
            Quanlisach.ResumeLayout(false);
            Trangchu.ResumeLayout(false);
            Setting.ResumeLayout(false);
            Chatbot.ResumeLayout(false);
            Quanlinhanvien.ResumeLayout(false);
            Title.ResumeLayout(false);
            Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExitBtn).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Timer homeTimer;
        private FlowLayoutPanel sidebar;
        private Panel MenuContainer;
        private Label Menu;
        private PictureBox MenuBtn;
        private Panel HomeContainer;
        private Button BaocaothongkeBtn;
        private Button QuanlinhanvienBtn;
        private Panel Docgia;
        private Button DocgiaBtn;
        private Button QuanlisachBtn;
        private Button MuontrasachBtn;
        private Button TrangchuBtn;
        private Panel Setting;
        private Button button2;
        private Panel Quanlinhanvien;
        private Panel Title;
        private Panel Trangchu;
        private Panel Baocaothongke;
        private Panel Muontrasach;
        private Panel Quanlisach;
        private PictureBox ExitBtn;
        private PictureBox MinimizeBtn;
        private PictureBox pictureBox1;
        private Label TitleLbl;
        public Panel ViewPanel;
        private Panel Chatbot;
        private Button Chatbotbtn;
    }
}
