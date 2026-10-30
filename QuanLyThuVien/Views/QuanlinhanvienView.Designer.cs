using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuVien.Views
{
    partial class QuanlinhanvienView
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgvNhanVien = new DataGridView();
            groupBox1 = new GroupBox();
            cboGioiTinh = new ComboBox();
            btnXoa = new Button();
            btnDoiMK = new Button();
            btnDangKy = new Button();
            btnHuy = new Button();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            txtMK = new TextBox();
            txtTenLogIn = new TextBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtHoTen = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(248, 248, 255);
            dgvNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNhanVien.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(88, 86, 245);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvNhanVien.ColumnHeadersHeight = 36;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(232, 230, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle6;
            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.GridColor = Color.FromArgb(230, 230, 240);
            dgvNhanVien.Location = new Point(94, 425);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.RowTemplate.Height = 32;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(954, 260);
            dgvNhanVien.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(cboGioiTinh);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnDoiMK);
            groupBox1.Controls.Add(btnDangKy);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(lblNgaySinh);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(txtMK);
            groupBox1.Controls.Add(txtTenLogIn);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.ForeColor = Color.FromArgb(50, 50, 50);
            groupBox1.Location = new Point(94, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(954, 354);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đăng Ký";
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.Font = new Font("Segoe UI", 11F);
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioiTinh.Location = new Point(225, 168);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(225, 28);
            cboGioiTinh.TabIndex = 7;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderColor = Color.FromArgb(215, 215, 215);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(683, 291);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(155, 48);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnDoiMK
            // 
            btnDoiMK.BackColor = Color.FromArgb(53, 162, 184);
            btnDoiMK.Cursor = Cursors.Hand;
            btnDoiMK.FlatAppearance.BorderColor = Color.FromArgb(215, 215, 215);
            btnDoiMK.FlatStyle = FlatStyle.Flat;
            btnDoiMK.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoiMK.ForeColor = Color.White;
            btnDoiMK.Location = new Point(98, 291);
            btnDoiMK.Name = "btnDoiMK";
            btnDoiMK.Size = new Size(155, 48);
            btnDoiMK.TabIndex = 13;
            btnDoiMK.Text = "Đổi Mật Khẩu";
            btnDoiMK.UseVisualStyleBackColor = false;
            btnDoiMK.Click += btnDoiMK_Click;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.FromArgb(0, 192, 0);
            btnDangKy.Cursor = Cursors.Hand;
            btnDangKy.FlatAppearance.BorderColor = Color.FromArgb(215, 215, 215);
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(295, 291);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(155, 48);
            btnDangKy.TabIndex = 14;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = SystemColors.ControlDark;
            btnHuy.Cursor = Cursors.Hand;
            btnHuy.FlatAppearance.BorderColor = Color.FromArgb(215, 215, 215);
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(480, 291);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(155, 48);
            btnHuy.TabIndex = 15;
            btnHuy.Text = "Huỷ";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Font = new Font("Segoe UI", 11F);
            lblNgaySinh.Location = new Point(75, 222);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(130, 25);
            lblNgaySinh.TabIndex = 5;
            lblNgaySinh.Text = "Ngày Sinh";
            lblNgaySinh.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Font = new Font("Segoe UI", 11F);
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(225, 219);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(225, 27);
            dtpNgaySinh.TabIndex = 6;
            // 
            // txtMK
            // 
            txtMK.BorderStyle = BorderStyle.FixedSingle;
            txtMK.Font = new Font("Segoe UI", 11F);
            txtMK.Location = new Point(630, 157);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(225, 27);
            txtMK.TabIndex = 12;
            txtMK.UseSystemPasswordChar = true;
            // 
            // txtTenLogIn
            // 
            txtTenLogIn.BorderStyle = BorderStyle.FixedSingle;
            txtTenLogIn.Font = new Font("Segoe UI", 11F);
            txtTenLogIn.Location = new Point(225, 46);
            txtTenLogIn.Name = "txtTenLogIn";
            txtTenLogIn.Size = new Size(225, 27);
            txtTenLogIn.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Font = new Font("Segoe UI", 11F);
            txtDiaChi.Location = new Point(630, 106);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(225, 27);
            txtDiaChi.TabIndex = 10;
            // 
            // txtSDT
            // 
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Font = new Font("Segoe UI", 11F);
            txtSDT.Location = new Point(630, 46);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(225, 27);
            txtSDT.TabIndex = 8;
            // 
            // txtHoTen
            // 
            txtHoTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoTen.Font = new Font("Segoe UI", 11F);
            txtHoTen.Location = new Point(225, 106);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(225, 27);
            txtHoTen.TabIndex = 4;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(98, 106);
            label7.Name = "label7";
            label7.Size = new Size(107, 25);
            label7.TabIndex = 3;
            label7.Text = "Tên Nhân Viên";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(485, 157);
            label6.Name = "label6";
            label6.Size = new Size(125, 25);
            label6.TabIndex = 11;
            label6.Text = "Mật Khẩu";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(480, 106);
            label5.Name = "label5";
            label5.Size = new Size(125, 25);
            label5.TabIndex = 9;
            label5.Text = "Địa Chỉ";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(485, 48);
            label4.Name = "label4";
            label4.Size = new Size(125, 25);
            label4.TabIndex = 7;
            label4.Text = "Số Điện Thoại";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(75, 171);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 5;
            label3.Text = "Giới Tính";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(75, 48);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // QuanlinhanvienView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1155, 739);
            Controls.Add(groupBox1);
            Controls.Add(dgvNhanVien);
            Name = "QuanlinhanvienView";
            Text = "Quản lý nhân viên";
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        #region Định dạng DataGridView Nhân viên

        public void DinhDangCotNhanVien()
        {
            if (dgvNhanVien.Columns["MatKhau"] != null)
                dgvNhanVien.Columns["MatKhau"].Visible = false;

            if (dgvNhanVien.Columns["PhieuMuons"] != null)
                dgvNhanVien.Columns["PhieuMuons"].Visible = false;

            if (dgvNhanVien.Columns["PhieuPhat"] != null)
                dgvNhanVien.Columns["PhieuPhat"].Visible = false;

            if (dgvNhanVien.Columns["MaTK"] != null)
            {
                dgvNhanVien.Columns["MaTK"].HeaderText = "Mã TK";
                dgvNhanVien.Columns["MaTK"].FillWeight = 40;
            }
            if (dgvNhanVien.Columns["TenDangNhap"] != null)
            {
                dgvNhanVien.Columns["TenDangNhap"].HeaderText = "Tên Đăng Nhập";
                dgvNhanVien.Columns["TenDangNhap"].FillWeight = 85;
            }
            if (dgvNhanVien.Columns["HoTen"] != null)
            {
                dgvNhanVien.Columns["HoTen"].HeaderText = "Họ và Tên";
                dgvNhanVien.Columns["HoTen"].FillWeight = 110;
            }
            if (dgvNhanVien.Columns["GioiTinh"] != null)
            {
                dgvNhanVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
                dgvNhanVien.Columns["GioiTinh"].FillWeight = 50;
            }
            if (dgvNhanVien.Columns["NgaySinh"] != null)
            {
                dgvNhanVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                dgvNhanVien.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvNhanVien.Columns["NgaySinh"].FillWeight = 75;
            }
            if (dgvNhanVien.Columns["SDT"] != null)
            {
                dgvNhanVien.Columns["SDT"].HeaderText = "Số Điện Thoại";
                dgvNhanVien.Columns["SDT"].FillWeight = 85;
            }
            if (dgvNhanVien.Columns["DiaChi"] != null)
            {
                dgvNhanVien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgvNhanVien.Columns["DiaChi"].FillWeight = 110;
            }
            if (dgvNhanVien.Columns["VaiTro"] != null)
            {
                dgvNhanVien.Columns["VaiTro"].HeaderText = "Vai Trò";
                dgvNhanVien.Columns["VaiTro"].FillWeight = 60;
            }
        }

        #endregion

        private DataGridView dgvNhanVien;
        private GroupBox groupBox1;
        private ComboBox cboGioiTinh;
        private Button btnXoa;
        private Button btnDoiMK;
        private Button btnDangKy;
        private Button btnHuy;
        private Label lblNgaySinh;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtMK;
        private TextBox txtTenLogIn;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private TextBox txtHoTen;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
