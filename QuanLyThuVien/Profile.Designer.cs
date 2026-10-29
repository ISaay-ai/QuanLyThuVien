using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuVien.GUI
{
    partial class Profile
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
            lblTitle = new Label();
            picAvatar = new PictureBox();
            btnUploadImage = new Button();
            btnDeleteImage = new Button();
            pnlCard = new Panel();
            lblTenDangNhap = new Label();
            txtTenDangNhap = new TextBox();
            lblMatKhau = new Label();
            txtMatKhau = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblGioiTinh = new Label();
            cboGioiTinh = new ComboBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblSDT = new Label();
            txtSDT = new TextBox();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            btnLuu = new Button();
            btnHuy = new Button();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 37, 41);
            lblTitle.Location = new Point(46, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(173, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thông tin cá nhân";
            // 
            // picAvatar
            // 
            picAvatar.BackColor = Color.FromArgb(224, 224, 224);
            picAvatar.Location = new Point(75, 77);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(110, 101);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 0;
            picAvatar.TabStop = false;
            // 
            // btnUploadImage
            // 
            btnUploadImage.BackColor = Color.FromArgb(53, 162, 184);
            btnUploadImage.Cursor = Cursors.Hand;
            btnUploadImage.FlatAppearance.BorderSize = 0;
            btnUploadImage.FlatStyle = FlatStyle.Flat;
            btnUploadImage.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnUploadImage.ForeColor = Color.White;
            btnUploadImage.Location = new Point(232, 120);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(135, 40);
            btnUploadImage.TabIndex = 1;
            btnUploadImage.Text = "Tải ảnh lên";
            btnUploadImage.UseVisualStyleBackColor = false;
            btnUploadImage.Click += this.btnUploadImage_Click;
            // 
            // btnDeleteImage
            // 
            btnDeleteImage.BackColor = Color.White;
            btnDeleteImage.Cursor = Cursors.Hand;
            btnDeleteImage.FlatAppearance.BorderSize = 0;
            btnDeleteImage.FlatStyle = FlatStyle.Flat;
            btnDeleteImage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDeleteImage.ForeColor = Color.FromArgb(220, 53, 69);
            btnDeleteImage.Location = new Point(414, 120);
            btnDeleteImage.Name = "btnDeleteImage";
            btnDeleteImage.Size = new Size(80, 40);
            btnDeleteImage.TabIndex = 2;
            btnDeleteImage.Text = "Xóa ảnh";
            btnDeleteImage.UseVisualStyleBackColor = false;
            btnDeleteImage.Click += this.btnDeleteImage_Click;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.White;
            pnlCard.Controls.Add(lblTenDangNhap);
            pnlCard.Controls.Add(txtTenDangNhap);
            pnlCard.Controls.Add(lblMatKhau);
            pnlCard.Controls.Add(txtMatKhau);
            pnlCard.Controls.Add(lblHoTen);
            pnlCard.Controls.Add(txtHoTen);
            pnlCard.Controls.Add(lblGioiTinh);
            pnlCard.Controls.Add(cboGioiTinh);
            pnlCard.Controls.Add(lblEmail);
            pnlCard.Controls.Add(txtEmail);
            pnlCard.Controls.Add(lblSDT);
            pnlCard.Controls.Add(txtSDT);
            pnlCard.Controls.Add(lblNgaySinh);
            pnlCard.Controls.Add(dtpNgaySinh);
            pnlCard.Controls.Add(lblDiaChi);
            pnlCard.Controls.Add(txtDiaChi);
            pnlCard.Location = new Point(86, 224);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(926, 295);
            pnlCard.TabIndex = 3;
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblTenDangNhap.ForeColor = Color.FromArgb(50, 50, 50);
            lblTenDangNhap.Location = new Point(25, 15);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(109, 17);
            lblTenDangNhap.TabIndex = 0;
            lblTenDangNhap.Text = "Tên đăng nhập *";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BackColor = Color.White;
            txtTenDangNhap.BorderStyle = BorderStyle.FixedSingle;
            txtTenDangNhap.Font = new Font("Segoe UI", 11F);
            txtTenDangNhap.Location = new Point(25, 38);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.ReadOnly = true;
            txtTenDangNhap.Size = new Size(415, 27);
            txtTenDangNhap.TabIndex = 0;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblMatKhau.ForeColor = Color.FromArgb(50, 50, 50);
            lblMatKhau.Location = new Point(475, 15);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(76, 17);
            lblMatKhau.TabIndex = 1;
            lblMatKhau.Text = "Mật khẩu *";
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = Color.White;
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Font = new Font("Segoe UI", 11F);
            txtMatKhau.Location = new Point(475, 38);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(415, 27);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblHoTen.ForeColor = Color.FromArgb(50, 50, 50);
            lblHoTen.Location = new Point(25, 82);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(78, 17);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ và tên *";
            // 
            // txtHoTen
            // 
            txtHoTen.BackColor = Color.White;
            txtHoTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoTen.Font = new Font("Segoe UI", 11F);
            txtHoTen.Location = new Point(25, 105);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(415, 27);
            txtHoTen.TabIndex = 2;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblGioiTinh.ForeColor = Color.FromArgb(50, 50, 50);
            lblGioiTinh.Location = new Point(475, 82);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(59, 17);
            lblGioiTinh.TabIndex = 3;
            lblGioiTinh.Text = "Giới tính";
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.BackColor = Color.White;
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.FlatStyle = FlatStyle.Flat;
            cboGioiTinh.Font = new Font("Segoe UI", 10.5F);
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cboGioiTinh.Location = new Point(475, 105);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(415, 27);
            cboGioiTinh.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(50, 50, 50);
            lblEmail.Location = new Point(25, 149);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(40, 17);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(25, 172);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(415, 27);
            txtEmail.TabIndex = 4;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblSDT.ForeColor = Color.FromArgb(50, 50, 50);
            lblSDT.Location = new Point(475, 149);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(88, 17);
            lblSDT.TabIndex = 5;
            lblSDT.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            txtSDT.BackColor = Color.White;
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Font = new Font("Segoe UI", 11F);
            txtSDT.Location = new Point(475, 172);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(415, 27);
            txtSDT.TabIndex = 5;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblNgaySinh.ForeColor = Color.FromArgb(50, 50, 50);
            lblNgaySinh.Location = new Point(25, 216);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(69, 17);
            lblNgaySinh.TabIndex = 6;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CalendarFont = new Font("Segoe UI", 11F);
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Font = new Font("Segoe UI", 10.5F);
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(25, 239);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(415, 26);
            dtpNgaySinh.TabIndex = 6;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            lblDiaChi.ForeColor = Color.FromArgb(50, 50, 50);
            lblDiaChi.Location = new Point(475, 216);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(48, 17);
            lblDiaChi.TabIndex = 7;
            lblDiaChi.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.BackColor = Color.White;
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Font = new Font("Segoe UI", 11F);
            txtDiaChi.Location = new Point(475, 239);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(415, 27);
            txtDiaChi.TabIndex = 7;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(53, 162, 184);
            btnLuu.Cursor = Cursors.Hand;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(872, 544);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(140, 38);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu thay đổi";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += this.btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Red;
            btnHuy.Cursor = Cursors.Hand;
            btnHuy.FlatAppearance.BorderColor = Color.FromArgb(210, 210, 210);
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(705, 544);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(140, 38);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += this.btnHuy_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1092, 612);
            Controls.Add(lblTitle);
            Controls.Add(picAvatar);
            Controls.Add(btnUploadImage);
            Controls.Add(btnDeleteImage);
            Controls.Add(pnlCard);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Name = "Profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân";
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private PictureBox picAvatar;
        private Button btnUploadImage;
        private Button btnDeleteImage;
        private Panel pnlCard;
        private Label lblTenDangNhap;
        private TextBox txtTenDangNhap;
        private Label lblMatKhau;
        private TextBox txtMatKhau;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblGioiTinh;
        private ComboBox cboGioiTinh;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblSDT;
        private TextBox txtSDT;
        private Label lblNgaySinh;
        private DateTimePicker dtpNgaySinh;
        private Label lblDiaChi;
        private TextBox txtDiaChi;
        private Button btnLuu;
        private Button btnHuy;
    }
}