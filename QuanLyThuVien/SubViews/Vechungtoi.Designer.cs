using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuVien.SubViews
{
    partial class Vechungtoi
    {
        private System.ComponentModel.IContainer components = null;

        private Panel pnlContainer;
        private Label lblHeaderTitle;
        private Panel pnlAppCard;
        private Label lblAppName;
        private Label lblAppVersion;
        private Label lblAppDesc;
        private Panel pnlTeacherCard;
        private Label lblTeacherHeader;
        private Label lblTeacherName;
        private Label lblTeacherThanks;
        private Panel pnlStudentsCard;
        private Label lblStudentsHeader;
        private Panel pnlSv1;
        private Label lblSv1Name;
        private Label lblSv1Mssv;
        private Panel pnlSv2;
        private Label lblSv2Name;
        private Label lblSv2Mssv;
        private Panel pnlSv3;
        private Label lblSv3Name;
        private Label lblSv3Mssv;
        private Panel pnlSv4;
        private Label lblSv4Name;
        private Label lblSv4Mssv;
        private Label lblFooter;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vechungtoi));
            pnlContainer = new Panel();
            lblHeaderTitle = new Label();
            pnlAppCard = new Panel();
            lblAppName = new Label();
            lblAppVersion = new Label();
            lblAppDesc = new Label();
            pnlTeacherCard = new Panel();
            lblTeacherHeader = new Label();
            lblTeacherName = new Label();
            lblTeacherThanks = new Label();
            pnlStudentsCard = new Panel();
            lblStudentsHeader = new Label();
            pnlSv1 = new Panel();
            lblSv1Name = new Label();
            lblSv1Mssv = new Label();
            pnlSv2 = new Panel();
            lblSv2Name = new Label();
            lblSv2Mssv = new Label();
            pnlSv3 = new Panel();
            lblSv3Name = new Label();
            lblSv3Mssv = new Label();
            pnlSv4 = new Panel();
            lblSv4Name = new Label();
            lblSv4Mssv = new Label();
            lblFooter = new Label();
            pnlContainer.SuspendLayout();
            pnlAppCard.SuspendLayout();
            pnlTeacherCard.SuspendLayout();
            pnlStudentsCard.SuspendLayout();
            pnlSv1.SuspendLayout();
            pnlSv2.SuspendLayout();
            pnlSv3.SuspendLayout();
            pnlSv4.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.AutoScroll = true;
            pnlContainer.BackColor = Color.White;
            pnlContainer.Controls.Add(lblHeaderTitle);
            pnlContainer.Controls.Add(pnlAppCard);
            pnlContainer.Controls.Add(pnlTeacherCard);
            pnlContainer.Controls.Add(pnlStudentsCard);
            pnlContainer.Controls.Add(lblFooter);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Padding = new Padding(35, 20, 35, 30);
            pnlContainer.Size = new Size(770, 605);
            pnlContainer.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(24, 24, 27);
            lblHeaderTitle.Location = new Point(35, 18);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(222, 30);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Giới thiệu ứng dụng";
            // 
            // pnlAppCard
            // 
            pnlAppCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlAppCard.BackColor = Color.FromArgb(248, 250, 252);
            pnlAppCard.Controls.Add(lblAppName);
            pnlAppCard.Controls.Add(lblAppVersion);
            pnlAppCard.Controls.Add(lblAppDesc);
            pnlAppCard.Location = new Point(35, 60);
            pnlAppCard.Name = "pnlAppCard";
            pnlAppCard.Padding = new Padding(20, 16, 20, 16);
            pnlAppCard.Size = new Size(690, 130);
            pnlAppCard.TabIndex = 1;
            pnlAppCard.Paint += pnlAppCard_Paint;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblAppName.ForeColor = Color.FromArgb(0, 120, 215);
            lblAppName.Location = new Point(18, 14);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(281, 25);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "HỆ THỐNG QUẢN LÝ THƯ VIỆN";
            // 
            // lblAppVersion
            // 
            lblAppVersion.AutoSize = true;
            lblAppVersion.Font = new Font("Segoe UI", 9.5F);
            lblAppVersion.ForeColor = Color.FromArgb(100, 116, 139);
            lblAppVersion.Location = new Point(19, 42);
            lblAppVersion.Name = "lblAppVersion";
            lblAppVersion.Size = new Size(352, 17);
            lblAppVersion.TabIndex = 1;
            lblAppVersion.Text = "Phiên bản: 1.0 (Bản chính thức) • Kiến trúc 3 lớp C# .NET 10";
            // 
            // lblAppDesc
            // 
            lblAppDesc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblAppDesc.Font = new Font("Segoe UI", 9.75F);
            lblAppDesc.ForeColor = Color.FromArgb(51, 65, 85);
            lblAppDesc.Location = new Point(19, 66);
            lblAppDesc.Name = "lblAppDesc";
            lblAppDesc.Size = new Size(650, 52);
            lblAppDesc.TabIndex = 2;
            lblAppDesc.Text = resources.GetString("lblAppDesc.Text");
            // 
            // pnlTeacherCard
            // 
            pnlTeacherCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTeacherCard.BackColor = Color.FromArgb(240, 253, 244);
            pnlTeacherCard.Controls.Add(lblTeacherHeader);
            pnlTeacherCard.Controls.Add(lblTeacherName);
            pnlTeacherCard.Controls.Add(lblTeacherThanks);
            pnlTeacherCard.Location = new Point(35, 205);
            pnlTeacherCard.Name = "pnlTeacherCard";
            pnlTeacherCard.Padding = new Padding(20, 16, 20, 16);
            pnlTeacherCard.Size = new Size(690, 115);
            pnlTeacherCard.TabIndex = 2;
            pnlTeacherCard.Paint += pnlTeacherCard_Paint;
            // 
            // lblTeacherHeader
            // 
            lblTeacherHeader.AutoSize = true;
            lblTeacherHeader.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTeacherHeader.ForeColor = Color.FromArgb(22, 101, 52);
            lblTeacherHeader.Location = new Point(18, 12);
            lblTeacherHeader.Name = "lblTeacherHeader";
            lblTeacherHeader.Size = new Size(173, 17);
            lblTeacherHeader.TabIndex = 0;
            lblTeacherHeader.Text = "GIẢNG VIÊN HƯỚNG DẪN:";
            // 
            // lblTeacherName
            // 
            lblTeacherName.AutoSize = true;
            lblTeacherName.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            lblTeacherName.ForeColor = Color.FromArgb(20, 83, 45);
            lblTeacherName.Location = new Point(195, 8);
            lblTeacherName.Name = "lblTeacherName";
            lblTeacherName.Size = new Size(191, 23);
            lblTeacherName.TabIndex = 1;
            lblTeacherName.Text = "Trịnh Đồng Thạch Trúc";
            // 
            // lblTeacherThanks
            // 
            lblTeacherThanks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTeacherThanks.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            lblTeacherThanks.ForeColor = Color.FromArgb(21, 128, 61);
            lblTeacherThanks.Location = new Point(18, 42);
            lblTeacherThanks.Name = "lblTeacherThanks";
            lblTeacherThanks.Size = new Size(650, 58);
            lblTeacherThanks.TabIndex = 2;
            lblTeacherThanks.Text = resources.GetString("lblTeacherThanks.Text");
            // 
            // pnlStudentsCard
            // 
            pnlStudentsCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlStudentsCard.BackColor = Color.FromArgb(248, 250, 252);
            pnlStudentsCard.Controls.Add(lblStudentsHeader);
            pnlStudentsCard.Controls.Add(pnlSv1);
            pnlStudentsCard.Controls.Add(pnlSv2);
            pnlStudentsCard.Controls.Add(pnlSv3);
            pnlStudentsCard.Controls.Add(pnlSv4);
            pnlStudentsCard.Location = new Point(35, 335);
            pnlStudentsCard.Name = "pnlStudentsCard";
            pnlStudentsCard.Padding = new Padding(20, 16, 20, 16);
            pnlStudentsCard.Size = new Size(690, 190);
            pnlStudentsCard.TabIndex = 3;
            pnlStudentsCard.Paint += pnlStudentsCard_Paint;
            // 
            // lblStudentsHeader
            // 
            lblStudentsHeader.AutoSize = true;
            lblStudentsHeader.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblStudentsHeader.ForeColor = Color.FromArgb(30, 41, 59);
            lblStudentsHeader.Location = new Point(18, 14);
            lblStudentsHeader.Name = "lblStudentsHeader";
            lblStudentsHeader.Size = new Size(162, 19);
            lblStudentsHeader.TabIndex = 0;
            lblStudentsHeader.Text = "SINH VIÊN THỰC HIỆN:";
            // 
            // pnlSv1
            // 
            pnlSv1.BackColor = Color.White;
            pnlSv1.Controls.Add(lblSv1Name);
            pnlSv1.Controls.Add(lblSv1Mssv);
            pnlSv1.Location = new Point(20, 46);
            pnlSv1.Name = "pnlSv1";
            pnlSv1.Size = new Size(310, 56);
            pnlSv1.TabIndex = 1;
            pnlSv1.Paint += pnlSvItem_Paint;
            // 
            // lblSv1Name
            // 
            lblSv1Name.AutoSize = true;
            lblSv1Name.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblSv1Name.ForeColor = Color.FromArgb(15, 23, 42);
            lblSv1Name.Location = new Point(14, 9);
            lblSv1Name.Name = "lblSv1Name";
            lblSv1Name.Size = new Size(137, 19);
            lblSv1Name.TabIndex = 0;
            lblSv1Name.Text = "Nguyễn Đức Khang";
            // 
            // lblSv1Mssv
            // 
            lblSv1Mssv.AutoSize = true;
            lblSv1Mssv.Font = new Font("Segoe UI", 9.5F);
            lblSv1Mssv.ForeColor = Color.FromArgb(100, 116, 139);
            lblSv1Mssv.Location = new Point(14, 29);
            lblSv1Mssv.Name = "lblSv1Mssv";
            lblSv1Mssv.Size = new Size(126, 17);
            lblSv1Mssv.TabIndex = 1;
            lblSv1Mssv.Text = "MSSV: 24800600445";
            // 
            // pnlSv2
            // 
            pnlSv2.BackColor = Color.White;
            pnlSv2.Controls.Add(lblSv2Name);
            pnlSv2.Controls.Add(lblSv2Mssv);
            pnlSv2.Location = new Point(350, 46);
            pnlSv2.Name = "pnlSv2";
            pnlSv2.Size = new Size(310, 56);
            pnlSv2.TabIndex = 2;
            pnlSv2.Paint += pnlSvItem_Paint;
            // 
            // lblSv2Name
            // 
            lblSv2Name.AutoSize = true;
            lblSv2Name.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblSv2Name.ForeColor = Color.FromArgb(15, 23, 42);
            lblSv2Name.Location = new Point(14, 9);
            lblSv2Name.Name = "lblSv2Name";
            lblSv2Name.Size = new Size(156, 19);
            lblSv2Name.TabIndex = 0;
            lblSv2Name.Text = "Nguyễn Hoàng Khang";
            // 
            // lblSv2Mssv
            // 
            lblSv2Mssv.AutoSize = true;
            lblSv2Mssv.Font = new Font("Segoe UI", 9.5F);
            lblSv2Mssv.ForeColor = Color.FromArgb(100, 116, 139);
            lblSv2Mssv.Location = new Point(14, 29);
            lblSv2Mssv.Name = "lblSv2Mssv";
            lblSv2Mssv.Size = new Size(126, 17);
            lblSv2Mssv.TabIndex = 1;
            lblSv2Mssv.Text = "MSSV: 24800600447";
            // 
            // pnlSv3
            // 
            pnlSv3.BackColor = Color.White;
            pnlSv3.Controls.Add(lblSv3Name);
            pnlSv3.Controls.Add(lblSv3Mssv);
            pnlSv3.Location = new Point(20, 115);
            pnlSv3.Name = "pnlSv3";
            pnlSv3.Size = new Size(310, 56);
            pnlSv3.TabIndex = 3;
            pnlSv3.Paint += pnlSvItem_Paint;
            // 
            // lblSv3Name
            // 
            lblSv3Name.AutoSize = true;
            lblSv3Name.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblSv3Name.ForeColor = Color.FromArgb(15, 23, 42);
            lblSv3Name.Location = new Point(14, 9);
            lblSv3Name.Name = "lblSv3Name";
            lblSv3Name.Size = new Size(127, 19);
            lblSv3Name.TabIndex = 0;
            lblSv3Name.Text = "Hoàng Nhật Long";
            // 
            // lblSv3Mssv
            // 
            lblSv3Mssv.AutoSize = true;
            lblSv3Mssv.Font = new Font("Segoe UI", 9.5F);
            lblSv3Mssv.ForeColor = Color.FromArgb(100, 116, 139);
            lblSv3Mssv.Location = new Point(14, 29);
            lblSv3Mssv.Name = "lblSv3Mssv";
            lblSv3Mssv.Size = new Size(126, 17);
            lblSv3Mssv.TabIndex = 1;
            lblSv3Mssv.Text = "MSSV: 24800600554";
            // 
            // pnlSv4
            // 
            pnlSv4.BackColor = Color.White;
            pnlSv4.Controls.Add(lblSv4Name);
            pnlSv4.Controls.Add(lblSv4Mssv);
            pnlSv4.Location = new Point(350, 115);
            pnlSv4.Name = "pnlSv4";
            pnlSv4.Size = new Size(310, 56);
            pnlSv4.TabIndex = 4;
            pnlSv4.Paint += pnlSvItem_Paint;
            // 
            // lblSv4Name
            // 
            lblSv4Name.AutoSize = true;
            lblSv4Name.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblSv4Name.ForeColor = Color.FromArgb(15, 23, 42);
            lblSv4Name.Location = new Point(14, 9);
            lblSv4Name.Name = "lblSv4Name";
            lblSv4Name.Size = new Size(107, 19);
            lblSv4Name.TabIndex = 0;
            lblSv4Name.Text = "Lê Đình Hoàng";
            // 
            // lblSv4Mssv
            // 
            lblSv4Mssv.AutoSize = true;
            lblSv4Mssv.Font = new Font("Segoe UI", 9.5F);
            lblSv4Mssv.ForeColor = Color.FromArgb(100, 116, 139);
            lblSv4Mssv.Location = new Point(14, 29);
            lblSv4Mssv.Name = "lblSv4Mssv";
            lblSv4Mssv.Size = new Size(126, 17);
            lblSv4Mssv.TabIndex = 1;
            lblSv4Mssv.Text = "MSSV: 24800600332";
            // 
            // lblFooter
            // 
            lblFooter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblFooter.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblFooter.ForeColor = Color.FromArgb(148, 163, 184);
            lblFooter.Location = new Point(35, 545);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(690, 30);
            lblFooter.TabIndex = 4;
            lblFooter.Text = "© 2026 Đồ án Quản lý Thư viện • Bản quyền thuộc về nhóm phát triển";
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Vechungtoi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(770, 605);
            Controls.Add(pnlContainer);
            FormBorderStyle = FormBorderStyle.Sizable;
            ControlBox = true;
            MinimizeBox = true;
            MaximizeBox = true;
            Name = "Vechungtoi";
            Text = "Giới thiệu ứng dụng";
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            pnlAppCard.ResumeLayout(false);
            pnlAppCard.PerformLayout();
            pnlTeacherCard.ResumeLayout(false);
            pnlTeacherCard.PerformLayout();
            pnlStudentsCard.ResumeLayout(false);
            pnlStudentsCard.PerformLayout();
            pnlSv1.ResumeLayout(false);
            pnlSv1.PerformLayout();
            pnlSv2.ResumeLayout(false);
            pnlSv2.PerformLayout();
            pnlSv3.ResumeLayout(false);
            pnlSv3.PerformLayout();
            pnlSv4.ResumeLayout(false);
            pnlSv4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        #region Paint Handlers

        private void pnlAppCard_Paint(object sender, PaintEventArgs e)
        {
            using var pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(226, 232, 240), 1);
            e.Graphics.DrawRectangle(pen, 0, 0, pnlAppCard.Width - 1, pnlAppCard.Height - 1);
        }

        private void pnlTeacherCard_Paint(object sender, PaintEventArgs e)
        {
            using var pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(187, 247, 208), 1);
            e.Graphics.DrawRectangle(pen, 0, 0, pnlTeacherCard.Width - 1, pnlTeacherCard.Height - 1);
        }

        private void pnlStudentsCard_Paint(object sender, PaintEventArgs e)
        {
            using var pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(226, 232, 240), 1);
            e.Graphics.DrawRectangle(pen, 0, 0, pnlStudentsCard.Width - 1, pnlStudentsCard.Height - 1);
        }

        private void pnlSvItem_Paint(object sender, PaintEventArgs e)
        {
            if (sender is Panel pnl)
            {
                using var pen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(226, 232, 240), 1);
                e.Graphics.DrawRectangle(pen, 0, 0, pnl.Width - 1, pnl.Height - 1);
            }
        }

        #endregion
    }
}
