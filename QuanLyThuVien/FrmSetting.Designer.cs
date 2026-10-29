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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlIndicator = new System.Windows.Forms.Panel();
            this.btnThongTinTaiKhoan = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();

            this.pnlHeader.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 55;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(24, 24, 27);
            this.lblTitle.Location = new System.Drawing.Point(20, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(95, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Settings";

            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(115, 115, 115);
            this.lblClose.Location = new System.Drawing.Point(955, 14);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(30, 28);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "✕";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += (s, e) => { this.lblClose.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69); };
            this.lblClose.MouseLeave += (s, e) => { this.lblClose.ForeColor = System.Drawing.Color.FromArgb(115, 115, 115); };

            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.pnlSidebar.Controls.Add(this.pnlIndicator);
            this.pnlSidebar.Controls.Add(this.btnThongTinTaiKhoan);
            this.pnlSidebar.Controls.Add(this.btnDangXuat);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Width = 230;
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSidebar_Paint);

            // 
            // pnlIndicator
            // 
            this.pnlIndicator.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.pnlIndicator.Location = new System.Drawing.Point(0, 8);
            this.pnlIndicator.Name = "pnlIndicator";
            this.pnlIndicator.Size = new System.Drawing.Size(4, 46);
            this.pnlIndicator.TabIndex = 0;

            // 
            // btnThongTinTaiKhoan
            // 
            this.btnThongTinTaiKhoan.BackColor = System.Drawing.Color.White;
            this.btnThongTinTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongTinTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnThongTinTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTinTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThongTinTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(24, 24, 27);
            this.btnThongTinTaiKhoan.Location = new System.Drawing.Point(0, 8);
            this.btnThongTinTaiKhoan.Name = "btnThongTinTaiKhoan";
            this.btnThongTinTaiKhoan.Padding = new System.Windows.Forms.Padding(48, 0, 0, 0);
            this.btnThongTinTaiKhoan.Size = new System.Drawing.Size(230, 46);
            this.btnThongTinTaiKhoan.TabIndex = 1;
            this.btnThongTinTaiKhoan.Text = "Thông tin tài khoản";
            this.btnThongTinTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTinTaiKhoan.UseVisualStyleBackColor = false;
            this.btnThongTinTaiKhoan.Click += new System.EventHandler(this.btnThongTinTaiKhoan_Click);
            this.btnThongTinTaiKhoan.Paint += new System.Windows.Forms.PaintEventHandler(this.btnThongTinTaiKhoan_Paint);

            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDangXuat.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99);
            this.btnDangXuat.Location = new System.Drawing.Point(0, 58);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(48, 0, 0, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(230, 46);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            this.btnDangXuat.Paint += new System.Windows.Forms.PaintEventHandler(this.btnDangXuat_Paint);

            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(230, 55);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(770, 605);
            this.pnlContent.TabIndex = 2;

            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FrmSetting_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
