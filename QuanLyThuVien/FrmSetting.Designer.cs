namespace QuanLyThuVien.GUI
{
    partial class FrmSetting
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlIndicator;
        private System.Windows.Forms.Button btnThongTinTaiKhoan;
        private System.Windows.Forms.Button btnGioiThieu;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel pnlContent;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetting));
            pnlHeader = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblClose = new Label();
            pnlSidebar = new Panel();
            pnlIndicator = new Panel();
            btnThongTinTaiKhoan = new Button();
            btnGioiThieu = new Button();
            btnDangXuat = new Button();
            pnlContent = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1000, 55);
            pnlHeader.TabIndex = 0;
            pnlHeader.Paint += pnlHeader_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(24, 24, 27);
            lblTitle.Location = new Point(68, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(79, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Cài đặt";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblClose
            // 
            lblClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblClose.Cursor = Cursors.Hand;
            lblClose.Font = new Font("Segoe UI", 13F);
            lblClose.ForeColor = Color.FromArgb(115, 115, 115);
            lblClose.Location = new Point(955, 14);
            lblClose.Name = "lblClose";
            lblClose.Size = new Size(30, 28);
            lblClose.TabIndex = 1;
            lblClose.Text = "✕";
            lblClose.TextAlign = ContentAlignment.MiddleCenter;
            lblClose.Click += lblClose_Click;
            lblClose.MouseEnter += lblClose_MouseEnter;
            lblClose.MouseLeave += lblClose_MouseLeave;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(248, 249, 250);
            pnlSidebar.Controls.Add(pictureBox4);
            pnlSidebar.Controls.Add(pictureBox3);
            pnlSidebar.Controls.Add(pictureBox2);
            pnlSidebar.Controls.Add(pnlIndicator);
            pnlSidebar.Controls.Add(btnThongTinTaiKhoan);
            pnlSidebar.Controls.Add(btnGioiThieu);
            pnlSidebar.Controls.Add(btnDangXuat);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 55);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(230, 605);
            pnlSidebar.TabIndex = 1;
            pnlSidebar.Paint += pnlSidebar_Paint;
            // 
            // pnlIndicator
            // 
            pnlIndicator.BackColor = Color.FromArgb(0, 120, 215);
            pnlIndicator.Location = new Point(0, 8);
            pnlIndicator.Name = "pnlIndicator";
            pnlIndicator.Size = new Size(4, 46);
            pnlIndicator.TabIndex = 0;
            // 
            // btnThongTinTaiKhoan
            // 
            btnThongTinTaiKhoan.BackColor = Color.White;
            btnThongTinTaiKhoan.Cursor = Cursors.Hand;
            btnThongTinTaiKhoan.FlatAppearance.BorderSize = 0;
            btnThongTinTaiKhoan.FlatStyle = FlatStyle.Flat;
            btnThongTinTaiKhoan.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnThongTinTaiKhoan.ForeColor = Color.FromArgb(24, 24, 27);
            btnThongTinTaiKhoan.Location = new Point(3, 11);
            btnThongTinTaiKhoan.Name = "btnThongTinTaiKhoan";
            btnThongTinTaiKhoan.Padding = new Padding(48, 0, 0, 0);
            btnThongTinTaiKhoan.Size = new Size(230, 46);
            btnThongTinTaiKhoan.TabIndex = 1;
            btnThongTinTaiKhoan.Text = "  Thông tin tài khoản";
            btnThongTinTaiKhoan.TextAlign = ContentAlignment.MiddleLeft;
            btnThongTinTaiKhoan.UseVisualStyleBackColor = false;
            btnThongTinTaiKhoan.Click += btnThongTinTaiKhoan_Click;
            btnThongTinTaiKhoan.Paint += btnThongTinTaiKhoan_Paint;
            // 
            // btnGioiThieu
            // 
            btnGioiThieu.BackColor = Color.Transparent;
            btnGioiThieu.Cursor = Cursors.Hand;
            btnGioiThieu.FlatAppearance.BorderSize = 0;
            btnGioiThieu.FlatStyle = FlatStyle.Flat;
            btnGioiThieu.Font = new Font("Segoe UI", 10.5F);
            btnGioiThieu.ForeColor = Color.FromArgb(75, 85, 99);
            btnGioiThieu.Location = new Point(3, 60);
            btnGioiThieu.Name = "btnGioiThieu";
            btnGioiThieu.Padding = new Padding(48, 0, 0, 0);
            btnGioiThieu.Size = new Size(230, 46);
            btnGioiThieu.TabIndex = 2;
            btnGioiThieu.Text = "  Về chúng tôi";
            btnGioiThieu.TextAlign = ContentAlignment.MiddleLeft;
            btnGioiThieu.UseVisualStyleBackColor = false;
            btnGioiThieu.Click += btnGioiThieu_Click;
            btnGioiThieu.Paint += btnGioiThieu_Paint;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.Transparent;
            btnDangXuat.Cursor = Cursors.Hand;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI", 10.5F);
            btnDangXuat.ForeColor = Color.Red;
            btnDangXuat.Location = new Point(1, 112);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Padding = new Padding(48, 0, 0, 0);
            btnDangXuat.Size = new Size(230, 46);
            btnDangXuat.TabIndex = 3;
            btnDangXuat.Text = "  Đăng xuất";
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            btnDangXuat.Paint += btnDangXuat_Paint;
            // 
            // pnlContent
            // 
            pnlContent.AutoScroll = true;
            pnlContent.BackColor = Color.White;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(230, 55);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(770, 605);
            pnlContent.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 64);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 116);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 38);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // FrmSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 660);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            Name = "FrmSetting";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += FrmSetting_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        #region Giao diện đồ họa Paint & Hover của Form Setting

        private void lblClose_MouseEnter(object sender, System.EventArgs e)
        {
            lblClose.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69);
        }

        private void lblClose_MouseLeave(object sender, System.EventArgs e)
        {
            lblClose.ForeColor = System.Drawing.Color.FromArgb(115, 115, 115);
        }

        private void pnlHeader_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            using var pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(229, 231, 235), 1);
            e.Graphics.DrawLine(pen, 0, pnlHeader.Height - 1, pnlHeader.Width, pnlHeader.Height - 1);
        }

        private void pnlSidebar_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            using var pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(229, 231, 235), 1);
            e.Graphics.DrawLine(pen, pnlSidebar.Width - 1, 0, pnlSidebar.Width - 1, pnlSidebar.Height);
        }

        private void btnThongTinTaiKhoan_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            System.Drawing.Color iconColor = (pnlIndicator.Top == btnThongTinTaiKhoan.Top)
                ? System.Drawing.Color.FromArgb(0, 120, 215)
                : System.Drawing.Color.FromArgb(107, 114, 128);

            using var brush = new System.Drawing.SolidBrush(iconColor);
            using var pen = new System.Drawing.Pen(iconColor, 1.8F);

            // Đầu người (vòng tròn)
            g.FillEllipse(brush, 19, 13, 10, 10);

            // Thân người (vòm cung vai)
            g.DrawArc(pen, 15, 23, 18, 14, 190, 160);
        }

        private void btnGioiThieu_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            System.Drawing.Color iconColor = (pnlIndicator.Top == btnGioiThieu.Top)
                ? System.Drawing.Color.FromArgb(0, 120, 215)
                : System.Drawing.Color.FromArgb(107, 114, 128);

            using var pen = new System.Drawing.Pen(iconColor, 1.8F);
            using var brush = new System.Drawing.SolidBrush(iconColor);

            // Vòng tròn thông tin 'i'
            g.DrawEllipse(pen, 17, 13, 20, 20);

            // Dấu chấm chữ i
            g.FillEllipse(brush, 26, 17, 2.5F, 2.5F);

            // Thân chữ i
            g.DrawLine(pen, 27, 22, 27, 28);
            g.DrawLine(pen, 25, 22, 27, 22);
            g.DrawLine(pen, 25, 28, 29, 28);
        }

        private void btnDangXuat_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            System.Drawing.Color iconColor = System.Drawing.Color.FromArgb(220, 53, 69); // Màu đỏ cảnh báo đăng xuất
            using var pen = new System.Drawing.Pen(iconColor, 1.8F);
            using var brush = new System.Drawing.SolidBrush(iconColor);

            // Khung cửa đăng xuất
            g.DrawLine(pen, 28, 13, 16, 13);
            g.DrawLine(pen, 16, 13, 16, 31);
            g.DrawLine(pen, 16, 31, 28, 31);

            // Mũi tên trỏ ra ngoài
            g.DrawLine(pen, 22, 22, 33, 22);
            System.Drawing.Point[] arrowHead = new System.Drawing.Point[]
            {
                new System.Drawing.Point(30, 18),
                new System.Drawing.Point(34, 22),
                new System.Drawing.Point(30, 26)
            };
            g.DrawLines(pen, arrowHead);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}
