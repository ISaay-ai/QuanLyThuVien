using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuVien.SubViews
{
    partial class TrasachView
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            grpThongTin = new GroupBox();
            lblTextSoNgayTre = new Label();
            lblSoNgayTre = new Label();
            dtpNgayTraThucTe = new DateTimePicker();
            lblNgayTraThucTe = new Label();
            dtpNgayHenTra = new DateTimePicker();
            lblNgayHenTra = new Label();
            txtMaSach = new TextBox();
            lblMaSach = new Label();
            txtMaSV = new TextBox();
            lblMaSV = new Label();
            txtMaPM = new TextBox();
            lblMaPM = new Label();
            chkCoViPham = new CheckBox();
            pnlPhat = new Panel();
            txtLyDo = new TextBox();
            lblLyDo = new Label();
            txtTienPhat = new TextBox();
            lblTienPhat = new Label();
            cboQuyDinhPhat = new ComboBox();
            lblQuyDinh = new Label();
            btnXacNhanTra = new Button();
            btnHuy = new Button();
            pnlHeader.SuspendLayout();
            grpThongTin.SuspendLayout();
            pnlPhat.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(53, 162, 184);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(584, 45);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(180, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(202, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "XÁC NHẬN TRẢ SÁCH";
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(lblTextSoNgayTre);
            grpThongTin.Controls.Add(lblSoNgayTre);
            grpThongTin.Controls.Add(dtpNgayTraThucTe);
            grpThongTin.Controls.Add(lblNgayTraThucTe);
            grpThongTin.Controls.Add(dtpNgayHenTra);
            grpThongTin.Controls.Add(lblNgayHenTra);
            grpThongTin.Controls.Add(txtMaSach);
            grpThongTin.Controls.Add(lblMaSach);
            grpThongTin.Controls.Add(txtMaSV);
            grpThongTin.Controls.Add(lblMaSV);
            grpThongTin.Controls.Add(txtMaPM);
            grpThongTin.Controls.Add(lblMaPM);
            grpThongTin.Font = new Font("Segoe UI", 9.5F);
            grpThongTin.Location = new Point(12, 55);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(560, 140);
            grpThongTin.TabIndex = 1;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông Tin Trả Sách";
            // 
            // lblTextSoNgayTre
            // 
            lblTextSoNgayTre.AutoSize = true;
            lblTextSoNgayTre.Location = new Point(280, 100);
            lblTextSoNgayTre.Name = "lblTextSoNgayTre";
            lblTextSoNgayTre.Size = new Size(56, 17);
            lblTextSoNgayTre.TabIndex = 0;
            lblTextSoNgayTre.Text = "Trễ Hạn:";
            // 
            // lblSoNgayTre
            // 
            lblSoNgayTre.AutoSize = true;
            lblSoNgayTre.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSoNgayTre.ForeColor = Color.Lime;
            lblSoNgayTre.Location = new Point(370, 100);
            lblSoNgayTre.Name = "lblSoNgayTre";
            lblSoNgayTre.Size = new Size(49, 17);
            lblSoNgayTre.TabIndex = 1;
            lblSoNgayTre.Text = "0 ngày";
            // 
            // dtpNgayTraThucTe
            // 
            dtpNgayTraThucTe.Format = DateTimePickerFormat.Short;
            dtpNgayTraThucTe.Location = new Point(370, 62);
            dtpNgayTraThucTe.Name = "dtpNgayTraThucTe";
            dtpNgayTraThucTe.Size = new Size(175, 24);
            dtpNgayTraThucTe.TabIndex = 4;
            dtpNgayTraThucTe.ValueChanged += dtpNgayTraThucTe_ValueChanged;
            // 
            // lblNgayTraThucTe
            // 
            lblNgayTraThucTe.AutoSize = true;
            lblNgayTraThucTe.Location = new Point(280, 65);
            lblNgayTraThucTe.Name = "lblNgayTraThucTe";
            lblNgayTraThucTe.Size = new Size(64, 17);
            lblNgayTraThucTe.TabIndex = 5;
            lblNgayTraThucTe.Text = "Ngày Trả:";
            // 
            // dtpNgayHenTra
            // 
            dtpNgayHenTra.Enabled = false;
            dtpNgayHenTra.Format = DateTimePickerFormat.Short;
            dtpNgayHenTra.Location = new Point(370, 27);
            dtpNgayHenTra.Name = "dtpNgayHenTra";
            dtpNgayHenTra.Size = new Size(175, 24);
            dtpNgayHenTra.TabIndex = 3;
            // 
            // lblNgayHenTra
            // 
            lblNgayHenTra.AutoSize = true;
            lblNgayHenTra.Location = new Point(280, 30);
            lblNgayHenTra.Name = "lblNgayHenTra";
            lblNgayHenTra.Size = new Size(56, 17);
            lblNgayHenTra.TabIndex = 6;
            lblNgayHenTra.Text = "Hạn Trả:";
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(85, 97);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.ReadOnly = true;
            txtMaSach.Size = new Size(170, 24);
            txtMaSach.TabIndex = 2;
            // 
            // lblMaSach
            // 
            lblMaSach.AutoSize = true;
            lblMaSach.Location = new Point(15, 100);
            lblMaSach.Name = "lblMaSach";
            lblMaSach.Size = new Size(61, 17);
            lblMaSach.TabIndex = 7;
            lblMaSach.Text = "Mã Sách:";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(85, 62);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.ReadOnly = true;
            txtMaSV.Size = new Size(170, 24);
            txtMaSV.TabIndex = 1;
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(15, 65);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(49, 17);
            lblMaSV.TabIndex = 8;
            lblMaSV.Text = "Mã SV:";
            // 
            // txtMaPM
            // 
            txtMaPM.Location = new Point(85, 27);
            txtMaPM.Name = "txtMaPM";
            txtMaPM.ReadOnly = true;
            txtMaPM.Size = new Size(170, 24);
            txtMaPM.TabIndex = 0;
            // 
            // lblMaPM
            // 
            lblMaPM.AutoSize = true;
            lblMaPM.Location = new Point(15, 30);
            lblMaPM.Name = "lblMaPM";
            lblMaPM.Size = new Size(53, 17);
            lblMaPM.TabIndex = 9;
            lblMaPM.Text = "Mã PM:";
            // 
            // chkCoViPham
            // 
            chkCoViPham.AutoSize = true;
            chkCoViPham.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            chkCoViPham.ForeColor = Color.Red;
            chkCoViPham.Location = new Point(12, 205);
            chkCoViPham.Name = "chkCoViPham";
            chkCoViPham.Size = new Size(99, 21);
            chkCoViPham.TabIndex = 2;
            chkCoViPham.Text = "Có Vi Phạm";
            chkCoViPham.UseVisualStyleBackColor = true;
            chkCoViPham.CheckedChanged += chkCoViPham_CheckedChanged;
            // 
            // pnlPhat
            // 
            pnlPhat.BorderStyle = BorderStyle.FixedSingle;
            pnlPhat.Controls.Add(txtLyDo);
            pnlPhat.Controls.Add(lblLyDo);
            pnlPhat.Controls.Add(txtTienPhat);
            pnlPhat.Controls.Add(lblTienPhat);
            pnlPhat.Controls.Add(cboQuyDinhPhat);
            pnlPhat.Controls.Add(lblQuyDinh);
            pnlPhat.Enabled = false;
            pnlPhat.Location = new Point(12, 232);
            pnlPhat.Name = "pnlPhat";
            pnlPhat.Size = new Size(560, 168);
            pnlPhat.TabIndex = 3;
            // 
            // txtLyDo
            // 
            txtLyDo.Location = new Point(82, 80);
            txtLyDo.Multiline = true;
            txtLyDo.Name = "txtLyDo";
            txtLyDo.Size = new Size(462, 71);
            txtLyDo.TabIndex = 2;
            // 
            // lblLyDo
            // 
            lblLyDo.AutoSize = true;
            lblLyDo.Location = new Point(12, 80);
            lblLyDo.Name = "lblLyDo";
            lblLyDo.Size = new Size(53, 15);
            lblLyDo.TabIndex = 3;
            lblLyDo.Text = "Ghi Chú:";
            // 
            // txtTienPhat
            // 
            txtTienPhat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTienPhat.ForeColor = Color.DarkRed;
            txtTienPhat.Location = new Point(82, 45);
            txtTienPhat.Name = "txtTienPhat";
            txtTienPhat.Size = new Size(200, 25);
            txtTienPhat.TabIndex = 1;
            // 
            // lblTienPhat
            // 
            lblTienPhat.AutoSize = true;
            lblTienPhat.Location = new Point(12, 48);
            lblTienPhat.Name = "lblTienPhat";
            lblTienPhat.Size = new Size(60, 15);
            lblTienPhat.TabIndex = 4;
            lblTienPhat.Text = "Tiền Phạt:";
            // 
            // cboQuyDinhPhat
            // 
            cboQuyDinhPhat.DropDownStyle = ComboBoxStyle.DropDownList;
            cboQuyDinhPhat.FormattingEnabled = true;
            cboQuyDinhPhat.Location = new Point(82, 12);
            cboQuyDinhPhat.Name = "cboQuyDinhPhat";
            cboQuyDinhPhat.Size = new Size(462, 23);
            cboQuyDinhPhat.TabIndex = 0;
            cboQuyDinhPhat.SelectedIndexChanged += cboQuyDinhPhat_SelectedIndexChanged;
            // 
            // lblQuyDinh
            // 
            lblQuyDinh.AutoSize = true;
            lblQuyDinh.Location = new Point(12, 15);
            lblQuyDinh.Name = "lblQuyDinh";
            lblQuyDinh.Size = new Size(60, 15);
            lblQuyDinh.TabIndex = 5;
            lblQuyDinh.Text = "Quy Định:";
            // 
            // btnXacNhanTra
            // 
            btnXacNhanTra.BackColor = Color.FromArgb(53, 162, 184);
            btnXacNhanTra.Cursor = Cursors.Hand;
            btnXacNhanTra.FlatStyle = FlatStyle.Flat;
            btnXacNhanTra.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnXacNhanTra.ForeColor = Color.White;
            btnXacNhanTra.Location = new Point(427, 420);
            btnXacNhanTra.Name = "btnXacNhanTra";
            btnXacNhanTra.Size = new Size(130, 35);
            btnXacNhanTra.TabIndex = 4;
            btnXacNhanTra.Text = "✓ Xác Nhận Trả";
            btnXacNhanTra.UseVisualStyleBackColor = false;
            btnXacNhanTra.Click += btnXacNhanTra_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = SystemColors.ControlDark;
            btnHuy.Cursor = Cursors.Hand;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(292, 420);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(112, 35);
            btnHuy.TabIndex = 5;
            btnHuy.Text = "✕ Hủy Bỏ";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // TrasachView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(584, 476);
            Controls.Add(btnHuy);
            Controls.Add(btnXacNhanTra);
            Controls.Add(pnlPhat);
            Controls.Add(chkCoViPham);
            Controls.Add(grpThongTin);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TrasachView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Xác Nhận Trả Sách";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            pnlPhat.ResumeLayout(false);
            pnlPhat.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaPM;
        private System.Windows.Forms.TextBox txtMaPM;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label lblNgayHenTra;
        private System.Windows.Forms.DateTimePicker dtpNgayHenTra;
        private System.Windows.Forms.Label lblNgayTraThucTe;
        private System.Windows.Forms.DateTimePicker dtpNgayTraThucTe;
        private System.Windows.Forms.Label lblTextSoNgayTre;
        private System.Windows.Forms.Label lblSoNgayTre;
        private System.Windows.Forms.CheckBox chkCoViPham;
        private System.Windows.Forms.Panel pnlPhat;
        private System.Windows.Forms.Label lblQuyDinh;
        private System.Windows.Forms.ComboBox cboQuyDinhPhat;
        private System.Windows.Forms.Label lblTienPhat;
        private System.Windows.Forms.TextBox txtTienPhat;
        private System.Windows.Forms.Label lblLyDo;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Button btnXacNhanTra;
        private System.Windows.Forms.Button btnHuy;
    }
}
