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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvNhanVien = new DataGridView();
            groupBox1 = new GroupBox();
            cboGioiTinh = new ComboBox();
            btnXoa = new Button();
            btnDoiMK = new Button();
            btnDangKy = new Button();
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
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 248, 255);
            dgvNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = Color.White;
            dgvNhanVien.BorderStyle = BorderStyle.None;
            dgvNhanVien.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNhanVien.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(88, 86, 245);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvNhanVien.ColumnHeadersHeight = 36;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(232, 230, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.GridColor = Color.FromArgb(230, 230, 240);
            dgvNhanVien.Location = new Point(94, 425);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.RowTemplate.Height = 32;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(954, 260);
            dgvNhanVien.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(250, 250, 250);
            groupBox1.Controls.Add(cboGioiTinh);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnDoiMK);
            groupBox1.Controls.Add(btnDangKy);
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
            groupBox1.Size = new Size(954, 345);
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
            cboGioiTinh.Location = new Point(225, 166);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(225, 28);
            cboGioiTinh.TabIndex = 6;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.White;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderColor = Color.FromArgb(215, 215, 215);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 11.5F);
            btnXoa.ForeColor = Color.FromArgb(42, 138, 98);
            btnXoa.Location = new Point(610, 245);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(165, 50);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnDoiMK
            // 
            btnDoiMK.BackColor = Color.White;
            btnDoiMK.Cursor = Cursors.Hand;
            btnDoiMK.FlatAppearance.BorderColor = Color.FromArgb(215, 215, 215);
            btnDoiMK.FlatStyle = FlatStyle.Flat;
            btnDoiMK.Font = new Font("Segoe UI", 11.5F);
            btnDoiMK.ForeColor = Color.FromArgb(42, 138, 98);
            btnDoiMK.Location = new Point(200, 245);
            btnDoiMK.Name = "btnDoiMK";
            btnDoiMK.Size = new Size(165, 50);
            btnDoiMK.TabIndex = 13;
            btnDoiMK.Text = "Đổi Mật Khẩu";
            btnDoiMK.UseVisualStyleBackColor = false;
            btnDoiMK.Click += btnDoiMK_Click;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.White;
            btnDangKy.Cursor = Cursors.Hand;
            btnDangKy.FlatAppearance.BorderColor = Color.FromArgb(215, 215, 215);
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 11.5F);
            btnDangKy.ForeColor = Color.FromArgb(42, 138, 98);
            btnDangKy.Location = new Point(405, 245);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(165, 50);
            btnDangKy.TabIndex = 14;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // txtMK
            // 
            txtMK.BorderStyle = BorderStyle.FixedSingle;
            txtMK.Font = new Font("Segoe UI", 11F);
            txtMK.Location = new Point(630, 166);
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
            label7.Location = new Point(75, 108);
            label7.Name = "label7";
            label7.Size = new Size(130, 25);
            label7.TabIndex = 3;
            label7.Text = "Tên Nhân Viên";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(485, 168);
            label6.Name = "label6";
            label6.Size = new Size(125, 25);
            label6.TabIndex = 11;
            label6.Text = "Mật Khẩu";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(485, 108);
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
            label3.Location = new Point(75, 168);
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
            label2.Text = "Mã NV - TK";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // QuanlinhanvienView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
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

        private DataGridView dgvNhanVien;
        private GroupBox groupBox1;
        private ComboBox cboGioiTinh;
        private Button btnXoa;
        private Button btnDoiMK;
        private Button btnDangKy;
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
