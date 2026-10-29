using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuVien.Views
{
    partial class DocgiaView
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
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle altRowStyle = new DataGridViewCellStyle();

            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            txtNganhHoc = new TextBox();
            cmbKhoaHoc = new ComboBox();
            txtSoDienThoai = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnGhi = new Button();
            btnHuyBo = new Button();
            dataGridView1 = new DataGridView();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBoxSearch = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBoxSearch = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxSearch.SuspendLayout();
            SuspendLayout();
            // 
            // CỤM NHÃN & Ô NHẬP LIỆU BÊN TRÁI (5 HÀNG)
            // 
            // Hàng 1: Mã Sinh Viên
            // 
            label1.AutoSize = false;
            label1.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular);
            label1.ForeColor = Color.FromArgb(40, 40, 40);
            label1.Location = new Point(20, 138);
            label1.Name = "label1";
            label1.Size = new Size(120, 27);
            label1.TabIndex = 11;
            label1.Text = "Mã Sinh Viên";
            label1.TextAlign = ContentAlignment.MiddleRight;

            txtMaSV.BorderStyle = BorderStyle.FixedSingle;
            txtMaSV.Font = new Font("Segoe UI", 11F);
            txtMaSV.Location = new Point(152, 138);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(195, 27);
            txtMaSV.TabIndex = 0;
            // 
            // Hàng 2: Họ và Tên
            // 
            label2.AutoSize = false;
            label2.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular);
            label2.ForeColor = Color.FromArgb(40, 40, 40);
            label2.Location = new Point(20, 190);
            label2.Name = "label2";
            label2.Size = new Size(120, 27);
            label2.TabIndex = 12;
            label2.Text = "Họ và Tên";
            label2.TextAlign = ContentAlignment.MiddleRight;

            txtHoTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoTen.Font = new Font("Segoe UI", 11F);
            txtHoTen.Location = new Point(152, 190);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(195, 27);
            txtHoTen.TabIndex = 1;
            // 
            // Hàng 3: Ngành Học
            // 
            label3.AutoSize = false;
            label3.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular);
            label3.ForeColor = Color.FromArgb(40, 40, 40);
            label3.Location = new Point(20, 242);
            label3.Name = "label3";
            label3.Size = new Size(120, 27);
            label3.TabIndex = 13;
            label3.Text = "Ngành Học";
            label3.TextAlign = ContentAlignment.MiddleRight;

            txtNganhHoc.BorderStyle = BorderStyle.FixedSingle;
            txtNganhHoc.Font = new Font("Segoe UI", 11F);
            txtNganhHoc.Location = new Point(152, 242);
            txtNganhHoc.Name = "txtNganhHoc";
            txtNganhHoc.Size = new Size(195, 27);
            txtNganhHoc.TabIndex = 2;
            // 
            // Hàng 4: Khoá Học
            // 
            label4.AutoSize = false;
            label4.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular);
            label4.ForeColor = Color.FromArgb(40, 40, 40);
            label4.Location = new Point(20, 294);
            label4.Name = "label4";
            label4.Size = new Size(120, 27);
            label4.TabIndex = 14;
            label4.Text = "Khoá Học";
            label4.TextAlign = ContentAlignment.MiddleRight;

            cmbKhoaHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKhoaHoc.FlatStyle = FlatStyle.Standard;
            cmbKhoaHoc.Font = new Font("Segoe UI", 11F);
            cmbKhoaHoc.FormattingEnabled = true;
            cmbKhoaHoc.Location = new Point(152, 294);
            cmbKhoaHoc.Name = "cmbKhoaHoc";
            cmbKhoaHoc.Size = new Size(195, 28);
            cmbKhoaHoc.TabIndex = 3;
            // 
            // Hàng 5: Số Điện Thoại
            // 
            label5.AutoSize = false;
            label5.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular);
            label5.ForeColor = Color.FromArgb(40, 40, 40);
            label5.Location = new Point(20, 346);
            label5.Name = "label5";
            label5.Size = new Size(120, 27);
            label5.TabIndex = 15;
            label5.Text = "Số Điện Thoại";
            label5.TextAlign = ContentAlignment.MiddleRight;

            txtSoDienThoai.BorderStyle = BorderStyle.FixedSingle;
            txtSoDienThoai.Font = new Font("Segoe UI", 11F);
            txtSoDienThoai.Location = new Point(152, 346);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(195, 27);
            txtSoDienThoai.TabIndex = 4;
            // 
            // CỤM NÚT CHỨC NĂNG (2 HÀNG)
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.White;
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 11F);
            btnThem.ForeColor = Color.FromArgb(42, 138, 98);
            btnThem.Location = new Point(38, 405);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(98, 42);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.White;
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 11F);
            btnSua.ForeColor = Color.FromArgb(42, 138, 98);
            btnSua.Location = new Point(150, 405);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(98, 42);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.White;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 11F);
            btnXoa.ForeColor = Color.FromArgb(42, 138, 98);
            btnXoa.Location = new Point(262, 405);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(98, 42);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnGhi
            // 
            btnGhi.BackColor = Color.FromArgb(248, 248, 248);
            btnGhi.Cursor = Cursors.Hand;
            btnGhi.FlatAppearance.BorderColor = Color.FromArgb(225, 225, 225);
            btnGhi.FlatStyle = FlatStyle.Flat;
            btnGhi.Font = new Font("Segoe UI", 11F);
            btnGhi.ForeColor = Color.FromArgb(64, 64, 64);
            btnGhi.Location = new Point(94, 463);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(98, 42);
            btnGhi.TabIndex = 8;
            btnGhi.Text = "Ghi";
            btnGhi.UseVisualStyleBackColor = false;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.FromArgb(248, 248, 248);
            btnHuyBo.Cursor = Cursors.Hand;
            btnHuyBo.FlatAppearance.BorderColor = Color.FromArgb(225, 225, 225);
            btnHuyBo.FlatStyle = FlatStyle.Flat;
            btnHuyBo.Font = new Font("Segoe UI", 11F);
            btnHuyBo.ForeColor = Color.FromArgb(64, 64, 64);
            btnHuyBo.Location = new Point(206, 463);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(98, 42);
            btnHuyBo.TabIndex = 9;
            btnHuyBo.Text = "Huỷ bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            // 
            // KHUNG TÌM KIẾM & BẢNG DỮ LIỆU BÊN PHẢI
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Controls.Add(radioButton1);
            groupBoxSearch.Controls.Add(radioButton2);
            groupBoxSearch.Controls.Add(textBoxSearch);
            groupBoxSearch.Font = new Font("Segoe UI", 9.5F);
            groupBoxSearch.ForeColor = Color.FromArgb(50, 50, 50);
            groupBoxSearch.Location = new Point(400, 22);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Size = new Size(515, 86);
            groupBoxSearch.TabIndex = 10;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Tìm Kiếm Sinh Viên";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 9.5F);
            radioButton1.Location = new Point(16, 38);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(99, 21);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Mã Sinh Viên";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Font = new Font("Segoe UI", 9.5F);
            radioButton2.Location = new Point(135, 38);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(101, 21);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Tên Sinh Viên";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Font = new Font("Segoe UI", 11F);
            textBoxSearch.Location = new Point(256, 26);
            textBoxSearch.Multiline = true;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(235, 42);
            textBoxSearch.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 36;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(230, 230, 240);
            dataGridView1.Location = new Point(400, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(515, 440);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;

            // Style cho Header của dataGridView1
            headerStyle.BackColor = Color.FromArgb(88, 86, 245);
            headerStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            headerStyle.ForeColor = Color.White;
            headerStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            headerStyle.SelectionForeColor = Color.White;
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.Padding = new Padding(6, 0, 0, 0);
            dataGridView1.ColumnHeadersDefaultCellStyle = headerStyle;

            // Style cho các dòng dữ liệu
            cellStyle.BackColor = Color.White;
            cellStyle.Font = new Font("Segoe UI", 9.5F);
            cellStyle.ForeColor = Color.FromArgb(64, 64, 64);
            cellStyle.SelectionBackColor = Color.FromArgb(232, 230, 255);
            cellStyle.SelectionForeColor = Color.FromArgb(64, 64, 64);
            cellStyle.Padding = new Padding(6, 0, 0, 0);
            dataGridView1.DefaultCellStyle = cellStyle;

            altRowStyle.BackColor = Color.FromArgb(248, 248, 255);
            dataGridView1.AlternatingRowsDefaultCellStyle = altRowStyle;
            // 
            // DocgiaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(944, 608);
            Controls.Add(groupBoxSearch);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtMaSV);
            Controls.Add(txtHoTen);
            Controls.Add(txtNganhHoc);
            Controls.Add(cmbKhoaHoc);
            Controls.Add(txtSoDienThoai);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnGhi);
            Controls.Add(btnHuyBo);
            Controls.Add(dataGridView1);
            Name = "DocgiaView";
            Text = "Quản lý độc giả";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtNganhHoc;
        private System.Windows.Forms.ComboBox cmbKhoaHoc;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxSearch;
    }
}