using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    partial class FrmForgotPass
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
            txtTenDangNhap = new TextBox();
            txtMatKhauMoi = new TextBox();
            txtXacNhanMatKhau = new TextBox();
            lblTitle = new Label();
            lblTenDangNhap = new Label();
            lblMatKhauMoi = new Label();
            lblXacNhan = new Label();
            btnDatLaiMatKhau = new Button();
            lnkQuayLai = new LinkLabel();
            chkHienMatKhau = new CheckBox();
            SuspendLayout();
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 10.5F);
            txtTenDangNhap.Location = new Point(190, 78);
            txtTenDangNhap.Margin = new Padding(2);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "Nhập tên đăng nhập...";
            txtTenDangNhap.Size = new Size(270, 26);
            txtTenDangNhap.TabIndex = 0;
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Font = new Font("Segoe UI", 10.5F);
            txtMatKhauMoi.Location = new Point(190, 120);
            txtMatKhauMoi.Margin = new Padding(2);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.PlaceholderText = "Nhập mật khẩu mới...";
            txtMatKhauMoi.Size = new Size(270, 26);
            txtMatKhauMoi.TabIndex = 1;
            txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // txtXacNhanMatKhau
            // 
            txtXacNhanMatKhau.Font = new Font("Segoe UI", 10.5F);
            txtXacNhanMatKhau.Location = new Point(190, 162);
            txtXacNhanMatKhau.Margin = new Padding(2);
            txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            txtXacNhanMatKhau.PlaceholderText = "Nhập lại mật khẩu mới...";
            txtXacNhanMatKhau.Size = new Size(270, 26);
            txtXacNhanMatKhau.TabIndex = 2;
            txtXacNhanMatKhau.UseSystemPasswordChar = true;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(53, 162, 184);
            lblTitle.Location = new Point(100, 20);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(320, 35);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "ĐẶT LẠI MẬT KHẨU";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 10F);
            lblTenDangNhap.Location = new Point(35, 81);
            lblTenDangNhap.Margin = new Padding(2, 0, 2, 0);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(103, 19);
            lblTenDangNhap.TabIndex = 8;
            lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // lblMatKhauMoi
            // 
            lblMatKhauMoi.AutoSize = true;
            lblMatKhauMoi.Font = new Font("Segoe UI", 10F);
            lblMatKhauMoi.Location = new Point(35, 123);
            lblMatKhauMoi.Margin = new Padding(2, 0, 2, 0);
            lblMatKhauMoi.Name = "lblMatKhauMoi";
            lblMatKhauMoi.Size = new Size(98, 19);
            lblMatKhauMoi.TabIndex = 9;
            lblMatKhauMoi.Text = "Mật khẩu mới:";
            // 
            // lblXacNhan
            // 
            lblXacNhan.AutoSize = true;
            lblXacNhan.Font = new Font("Segoe UI", 10F);
            lblXacNhan.Location = new Point(35, 165);
            lblXacNhan.Margin = new Padding(2, 0, 2, 0);
            lblXacNhan.Name = "lblXacNhan";
            lblXacNhan.Size = new Size(128, 19);
            lblXacNhan.TabIndex = 10;
            lblXacNhan.Text = "Xác nhận mật khẩu:";
            // 
            // btnDatLaiMatKhau
            // 
            btnDatLaiMatKhau.BackColor = Color.FromArgb(53, 162, 184);
            btnDatLaiMatKhau.Cursor = Cursors.Hand;
            btnDatLaiMatKhau.FlatAppearance.BorderSize = 0;
            btnDatLaiMatKhau.FlatStyle = FlatStyle.Flat;
            btnDatLaiMatKhau.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnDatLaiMatKhau.ForeColor = Color.White;
            btnDatLaiMatKhau.Location = new Point(190, 235);
            btnDatLaiMatKhau.Margin = new Padding(2);
            btnDatLaiMatKhau.Name = "btnDatLaiMatKhau";
            btnDatLaiMatKhau.Size = new Size(270, 36);
            btnDatLaiMatKhau.TabIndex = 4;
            btnDatLaiMatKhau.Text = "Đặt lại mật khẩu";
            btnDatLaiMatKhau.UseVisualStyleBackColor = false;
            btnDatLaiMatKhau.Click += btnDatLaiMatKhau_Click;
            // 
            // lnkQuayLai
            // 
            lnkQuayLai.AutoSize = true;
            lnkQuayLai.Cursor = Cursors.Hand;
            lnkQuayLai.Font = new Font("Segoe UI", 9.5F);
            lnkQuayLai.LinkColor = Color.FromArgb(53, 162, 184);
            lnkQuayLai.Location = new Point(255, 285);
            lnkQuayLai.Margin = new Padding(2, 0, 2, 0);
            lnkQuayLai.Name = "lnkQuayLai";
            lnkQuayLai.Size = new Size(122, 17);
            lnkQuayLai.TabIndex = 5;
            lnkQuayLai.TabStop = true;
            lnkQuayLai.Text = "Quay lại đăng nhập";
            lnkQuayLai.LinkClicked += lnkQuayLai_LinkClicked;
            // 
            // chkHienMatKhau
            // 
            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.Cursor = Cursors.Hand;
            chkHienMatKhau.Font = new Font("Segoe UI", 9.5F);
            chkHienMatKhau.Location = new Point(190, 198);
            chkHienMatKhau.Margin = new Padding(2);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new Size(111, 21);
            chkHienMatKhau.TabIndex = 3;
            chkHienMatKhau.Text = "Hiện mật khẩu";
            chkHienMatKhau.UseVisualStyleBackColor = true;
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;
            // 
            // FrmForgotPass
            // 
            AcceptButton = btnDatLaiMatKhau;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(514, 335);
            Controls.Add(chkHienMatKhau);
            Controls.Add(lnkQuayLai);
            Controls.Add(btnDatLaiMatKhau);
            Controls.Add(lblXacNhan);
            Controls.Add(lblMatKhauMoi);
            Controls.Add(lblTenDangNhap);
            Controls.Add(lblTitle);
            Controls.Add(txtXacNhanMatKhau);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(txtTenDangNhap);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmForgotPass";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quên Mật Khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenDangNhap;
        private TextBox txtMatKhauMoi;
        private TextBox txtXacNhanMatKhau;
        private Label lblTitle;
        private Label lblTenDangNhap;
        private Label lblMatKhauMoi;
        private Label lblXacNhan;
        private Button btnDatLaiMatKhau;
        private LinkLabel lnkQuayLai;
        private CheckBox chkHienMatKhau;
    }
}
