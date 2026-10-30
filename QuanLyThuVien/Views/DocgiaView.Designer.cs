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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            cboNganh = new ComboBox();
            cmbKhoaHoc = new ComboBox();
            txtSoDienThoai = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnGhi = new Button();
            btnHuyBo = new Button();
            dgvDocGia = new DataGridView();
            radMaSV = new RadioButton();
            radTenSV = new RadioButton();
            txtTimKiem = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBoxSearch = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).BeginInit();
            groupBoxSearch.SuspendLayout();
            SuspendLayout();
            // 
            // txtMaSV
            // 
            txtMaSV.BackColor = Color.FromArgb(245, 245, 245);
            txtMaSV.BorderStyle = BorderStyle.FixedSingle;
            txtMaSV.Font = new Font("Segoe UI", 11F);
            txtMaSV.Location = new Point(152, 138);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.ReadOnly = true;
            txtMaSV.Size = new Size(195, 27);
            txtMaSV.TabIndex = 0;
            // 
            // txtHoTen
            // 
            txtHoTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoTen.Font = new Font("Segoe UI", 11F);
            txtHoTen.Location = new Point(152, 190);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(195, 27);
            txtHoTen.TabIndex = 1;
            // 
            // cboNganh
            // 
            cboNganh.Font = new Font("Segoe UI", 11F);
            cboNganh.FormattingEnabled = true;
            cboNganh.Location = new Point(152, 242);
            cboNganh.Name = "cboNganh";
            cboNganh.Size = new Size(195, 28);
            cboNganh.TabIndex = 2;
            // 
            // cmbKhoaHoc
            // 
            cmbKhoaHoc.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKhoaHoc.Font = new Font("Segoe UI", 11F);
            cmbKhoaHoc.FormattingEnabled = true;
            cmbKhoaHoc.Location = new Point(152, 294);
            cmbKhoaHoc.Name = "cmbKhoaHoc";
            cmbKhoaHoc.Size = new Size(195, 28);
            cmbKhoaHoc.TabIndex = 3;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.BorderStyle = BorderStyle.FixedSingle;
            txtSoDienThoai.Font = new Font("Segoe UI", 11F);
            txtSoDienThoai.Location = new Point(152, 346);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(195, 27);
            txtSoDienThoai.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(42, 138, 98);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(38, 405);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(98, 42);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(53, 162, 184);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(150, 405);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(98, 42);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderColor = Color.FromArgb(200, 200, 200);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(262, 405);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(98, 42);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnGhi
            // 
            btnGhi.BackColor = Color.FromArgb(0, 192, 0);
            btnGhi.Cursor = Cursors.Hand;
            btnGhi.FlatAppearance.BorderColor = Color.FromArgb(225, 225, 225);
            btnGhi.FlatStyle = FlatStyle.Flat;
            btnGhi.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGhi.ForeColor = Color.White;
            btnGhi.Location = new Point(83, 478);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(98, 42);
            btnGhi.TabIndex = 8;
            btnGhi.Text = "Lưu";
            btnGhi.UseVisualStyleBackColor = false;
            btnGhi.Click += btnLuu_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = Color.DarkGray;
            btnHuyBo.Cursor = Cursors.Hand;
            btnHuyBo.FlatAppearance.BorderColor = Color.FromArgb(225, 225, 225);
            btnHuyBo.FlatStyle = FlatStyle.Flat;
            btnHuyBo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuyBo.ForeColor = Color.White;
            btnHuyBo.Location = new Point(230, 478);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(98, 42);
            btnHuyBo.TabIndex = 9;
            btnHuyBo.Text = "Huỷ bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // dgvDocGia
            // 
            dgvDocGia.AllowUserToAddRows = false;
            dgvDocGia.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(248, 248, 255);
            dgvDocGia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvDocGia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDocGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDocGia.BackgroundColor = Color.White;
            dgvDocGia.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDocGia.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(88, 86, 245);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dgvDocGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvDocGia.ColumnHeadersHeight = 36;
            dgvDocGia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(232, 230, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvDocGia.DefaultCellStyle = dataGridViewCellStyle6;
            dgvDocGia.EnableHeadersVisualStyles = false;
            dgvDocGia.GridColor = Color.FromArgb(230, 230, 240);
            dgvDocGia.Location = new Point(416, 138);
            dgvDocGia.MultiSelect = false;
            dgvDocGia.Name = "dgvDocGia";
            dgvDocGia.ReadOnly = true;
            dgvDocGia.RowHeadersVisible = false;
            dgvDocGia.RowTemplate.Height = 30;
            dgvDocGia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDocGia.Size = new Size(515, 440);
            dgvDocGia.TabIndex = 17;
            dgvDocGia.CellClick += dgvDocGia_CellClick;
            // 
            // radMaSV
            // 
            radMaSV.AutoSize = true;
            radMaSV.Font = new Font("Segoe UI", 9.5F);
            radMaSV.Location = new Point(16, 38);
            radMaSV.Name = "radMaSV";
            radMaSV.Size = new Size(102, 21);
            radMaSV.TabIndex = 0;
            radMaSV.TabStop = true;
            radMaSV.Text = "Mã Sinh Viên";
            radMaSV.UseVisualStyleBackColor = true;
            radMaSV.CheckedChanged += radTimKiem_CheckedChanged;
            // 
            // radTenSV
            // 
            radTenSV.AutoSize = true;
            radTenSV.Checked = true;
            radTenSV.Font = new Font("Segoe UI", 9.5F);
            radTenSV.Location = new Point(135, 38);
            radTenSV.Name = "radTenSV";
            radTenSV.Size = new Size(103, 21);
            radTenSV.TabIndex = 1;
            radTenSV.TabStop = true;
            radTenSV.Text = "Tên Sinh Viên";
            radTenSV.UseVisualStyleBackColor = true;
            radTenSV.CheckedChanged += radTimKiem_CheckedChanged;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI", 11F);
            txtTimKiem.Location = new Point(256, 30);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập từ khoá tìm kiếm...";
            txtTimKiem.Size = new Size(240, 27);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = Color.FromArgb(40, 40, 40);
            label1.Location = new Point(20, 138);
            label1.Name = "label1";
            label1.Size = new Size(120, 27);
            label1.TabIndex = 11;
            label1.Text = "Mã Sinh Viên";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.FromArgb(40, 40, 40);
            label2.Location = new Point(20, 190);
            label2.Name = "label2";
            label2.Size = new Size(120, 27);
            label2.TabIndex = 12;
            label2.Text = "Họ và Tên";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.FromArgb(40, 40, 40);
            label3.Location = new Point(20, 242);
            label3.Name = "label3";
            label3.Size = new Size(120, 27);
            label3.TabIndex = 13;
            label3.Text = "Ngành Học";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = Color.FromArgb(40, 40, 40);
            label4.Location = new Point(20, 294);
            label4.Name = "label4";
            label4.Size = new Size(120, 27);
            label4.TabIndex = 14;
            label4.Text = "Khoá Học";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = Color.FromArgb(40, 40, 40);
            label5.Location = new Point(20, 346);
            label5.Name = "label5";
            label5.Size = new Size(120, 27);
            label5.TabIndex = 15;
            label5.Text = "Số Điện Thoại";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxSearch.Controls.Add(radMaSV);
            groupBoxSearch.Controls.Add(radTenSV);
            groupBoxSearch.Controls.Add(txtTimKiem);
            groupBoxSearch.Font = new Font("Segoe UI", 9.5F);
            groupBoxSearch.ForeColor = Color.FromArgb(50, 50, 50);
            groupBoxSearch.Location = new Point(400, 22);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Size = new Size(515, 86);
            groupBoxSearch.TabIndex = 16;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Tìm Kiếm Sinh Viên";
            // 
            // DocgiaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(972, 608);
            Controls.Add(groupBoxSearch);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtMaSV);
            Controls.Add(txtHoTen);
            Controls.Add(cboNganh);
            Controls.Add(cmbKhoaHoc);
            Controls.Add(txtSoDienThoai);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnGhi);
            Controls.Add(btnHuyBo);
            Controls.Add(dgvDocGia);
            Name = "DocgiaView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý độc giả";
            Load += DocgiaView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDocGia).EndInit();
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ComboBox cboNganh;
        private System.Windows.Forms.ComboBox cmbKhoaHoc;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.DataGridView dgvDocGia;
        private System.Windows.Forms.RadioButton radMaSV;
        private System.Windows.Forms.RadioButton radTenSV;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxSearch;
    }
}
