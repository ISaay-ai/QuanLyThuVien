using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuVien.SubViews
{
    partial class FrmChatBot
    {
        private System.ComponentModel.IContainer components = null;

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
            lblTieuDe = new Label();
            rtbLichSu = new RichTextBox();
            pnlNhap = new Panel();
            txtCauHoi = new TextBox();
            btnGui = new Button();
            btnLamMoi = new Button();
            pnlNhap.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Dock = DockStyle.Top;
            lblTieuDe.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(0, 120, 215);
            lblTieuDe.Location = new Point(10, 10);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(680, 35);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "Trợ lý ảo Thư viện";
            lblTieuDe.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rtbLichSu
            // 
            rtbLichSu.BackColor = Color.White;
            rtbLichSu.BorderStyle = BorderStyle.FixedSingle;
            rtbLichSu.Dock = DockStyle.Fill;
            rtbLichSu.Font = new Font("Segoe UI", 10.5F);
            rtbLichSu.Location = new Point(10, 45);
            rtbLichSu.Name = "rtbLichSu";
            rtbLichSu.ReadOnly = true;
            rtbLichSu.Size = new Size(680, 374);
            rtbLichSu.TabIndex = 1;
            rtbLichSu.Text = "";
            // 
            // pnlNhap
            // 
            pnlNhap.Controls.Add(txtCauHoi);
            pnlNhap.Controls.Add(btnGui);
            pnlNhap.Controls.Add(btnLamMoi);
            pnlNhap.Dock = DockStyle.Bottom;
            pnlNhap.Location = new Point(10, 419);
            pnlNhap.Name = "pnlNhap";
            pnlNhap.Padding = new Padding(0, 8, 0, 0);
            pnlNhap.Size = new Size(680, 48);
            pnlNhap.TabIndex = 2;
            // 
            // txtCauHoi
            // 
            txtCauHoi.Dock = DockStyle.Fill;
            txtCauHoi.Font = new Font("Segoe UI", 12F);
            txtCauHoi.Location = new Point(0, 8);
            txtCauHoi.Name = "txtCauHoi";
            txtCauHoi.PlaceholderText = "Nhập câu hỏi, ví dụ: Còn bao nhiêu cuốn Mắt Biếc?";
            txtCauHoi.Size = new Size(500, 29);
            txtCauHoi.TabIndex = 0;
            txtCauHoi.KeyDown += txtCauHoi_KeyDown;
            // 
            // btnGui
            // 
            btnGui.BackColor = Color.FromArgb(0, 120, 215);
            btnGui.Dock = DockStyle.Right;
            btnGui.FlatStyle = FlatStyle.Flat;
            btnGui.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGui.ForeColor = Color.White;
            btnGui.Location = new Point(500, 8);
            btnGui.Name = "btnGui";
            btnGui.Size = new Size(90, 40);
            btnGui.TabIndex = 1;
            btnGui.Text = "Gửi";
            btnGui.UseVisualStyleBackColor = false;
            btnGui.Click += btnGui_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Dock = DockStyle.Right;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 10F);
            btnLamMoi.Location = new Point(590, 8);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(90, 40);
            btnLamMoi.TabIndex = 2;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // FrmChatBot
            // 
            AcceptButton = btnGui;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 477);
            Controls.Add(rtbLichSu);
            Controls.Add(pnlNhap);
            Controls.Add(lblTieuDe);
            Name = "FrmChatBot";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChatBot Thư viện";
            Load += FrmChatBot_Load;
            pnlNhap.ResumeLayout(false);
            pnlNhap.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTieuDe;
        private RichTextBox rtbLichSu;
        private Panel pnlNhap;
        private TextBox txtCauHoi;
        private Button btnGui;
        private Button btnLamMoi;
    }
}
