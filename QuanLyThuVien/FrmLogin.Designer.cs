using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            lblTenDangNhap = new Label();
            lblMatKhau = new Label();
            btnDangNhap = new Button();
            lnkQuenMatKhau = new LinkLabel();
            chkHienMatKhau = new CheckBox();
            lblTitleLogin = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 11F);
            txtTenDangNhap.Location = new Point(67, 260);
            txtTenDangNhap.Margin = new Padding(2);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "Nhập tên đăng nhập...";
            txtTenDangNhap.Size = new Size(297, 27);
            txtTenDangNhap.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 11F);
            txtMatKhau.Location = new Point(67, 345);
            txtMatKhau.Margin = new Padding(2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PlaceholderText = "Nhập mật khẩu...";
            txtMatKhau.Size = new Size(297, 27);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 10F);
            lblTenDangNhap.Location = new Point(67, 230);
            lblTenDangNhap.Margin = new Padding(2, 0, 2, 0);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(103, 19);
            lblTenDangNhap.TabIndex = 3;
            lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 10F);
            lblMatKhau.Location = new Point(67, 315);
            lblMatKhau.Margin = new Padding(2, 0, 2, 0);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(71, 19);
            lblMatKhau.TabIndex = 4;
            lblMatKhau.Text = "Mật khẩu:";
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.FromArgb(53, 162, 184);
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.FlatAppearance.BorderSize = 0;
            btnDangNhap.FlatStyle = FlatStyle.Flat;
            btnDangNhap.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(67, 450);
            btnDangNhap.Margin = new Padding(2);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(297, 40);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // lnkQuenMatKhau
            // 
            lnkQuenMatKhau.AutoSize = true;
            lnkQuenMatKhau.Font = new Font("Segoe UI", 9.5F);
            lnkQuenMatKhau.LinkColor = Color.FromArgb(53, 162, 184);
            lnkQuenMatKhau.Location = new Point(265, 395);
            lnkQuenMatKhau.Margin = new Padding(2, 0, 2, 0);
            lnkQuenMatKhau.Name = "lnkQuenMatKhau";
            lnkQuenMatKhau.Size = new Size(102, 17);
            lnkQuenMatKhau.TabIndex = 3;
            lnkQuenMatKhau.TabStop = true;
            lnkQuenMatKhau.Text = "Quên mật khẩu?";
            lnkQuenMatKhau.LinkClicked += lnkQuenMatKhau_LinkClicked;
            // 
            // chkHienMatKhau
            // 
            chkHienMatKhau.AutoSize = true;
            chkHienMatKhau.Cursor = Cursors.Hand;
            chkHienMatKhau.Font = new Font("Segoe UI", 9.5F);
            chkHienMatKhau.Location = new Point(67, 394);
            chkHienMatKhau.Margin = new Padding(2);
            chkHienMatKhau.Name = "chkHienMatKhau";
            chkHienMatKhau.Size = new Size(110, 21);
            chkHienMatKhau.TabIndex = 2;
            chkHienMatKhau.Text = "Hiện mật khẩu";
            chkHienMatKhau.UseVisualStyleBackColor = true;
            chkHienMatKhau.CheckedChanged += chkHienMatKhau_CheckedChanged;
            // 
            // lblTitleLogin
            // 
            lblTitleLogin.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitleLogin.ForeColor = Color.FromArgb(53, 162, 184);
            lblTitleLogin.Location = new Point(67, 90);
            lblTitleLogin.Margin = new Padding(2, 0, 2, 0);
            lblTitleLogin.Name = "lblTitleLogin";
            lblTitleLogin.Size = new Size(297, 45);
            lblTitleLogin.TabIndex = 1;
            lblTitleLogin.Text = "ĐĂNG NHẬP";
            lblTitleLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(53, 162, 184);
            panel1.Location = new Point(444, -15);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 587);
            panel1.TabIndex = 10;
            // 
            // FrmLogin
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(883, 560);
            Controls.Add(panel1);
            Controls.Add(chkHienMatKhau);
            Controls.Add(lnkQuenMatKhau);
            Controls.Add(btnDangNhap);
            Controls.Add(lblMatKhau);
            Controls.Add(lblTenDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(lblTitleLogin);
            Controls.Add(txtTenDangNhap);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập - Hệ Thống Quản Lý Thư Viện";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private Label lblTenDangNhap;
        private Label lblMatKhau;
        private Button btnDangNhap;
        private LinkLabel lnkQuenMatKhau;
        private CheckBox chkHienMatKhau;
        private Label lblTitleLogin;
        private Panel panel1;
    }
}
