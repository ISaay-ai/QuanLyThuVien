namespace QuanLyThuVien.GUI
{
    partial class FrmQuanLyNhanVien
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
            pnlTitle = new Panel();
            lblTitle = new Label();
            pnlFooter = new Panel();
            lblFooter = new Label();
            pnlBody = new Panel();
            gbDangKy = new GroupBox();
            btnXoa = new Button();
            btnDangKy = new Button();
            btnDoiMatKhau = new Button();
            cbGioiTinh = new ComboBox();
            txtMatKhau = new TextBox();
            txtDiaChi = new TextBox();
            txtSoDienThoai = new TextBox();
            txtTenNhanVien = new TextBox();
            txtMaNV = new TextBox();
            lblMatKhau = new Label();
            lblDiaChi = new Label();
            lblSoDienThoai = new Label();
            lblGioiTinh = new Label();
            lblTenNhanVien = new Label();
            lblMaNV = new Label();
            dgvNhanVien = new DataGridView();
            colMaNV = new DataGridViewTextBoxColumn();
            colTenNV = new DataGridViewTextBoxColumn();
            colSDT = new DataGridViewTextBoxColumn();
            colGioiTinh = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            pnlTitle.SuspendLayout();
            pnlFooter.SuspendLayout();
            pnlBody.SuspendLayout();
            gbDangKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.Teal;
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(884, 35);
            pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(884, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản Lý Nhân Viên";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.Teal;
            pnlFooter.Controls.Add(lblFooter);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 526);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(884, 35);
            pnlFooter.TabIndex = 1;
            // 
            // lblFooter
            // 
            lblFooter.Dock = DockStyle.Fill;
            lblFooter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFooter.ForeColor = Color.White;
            lblFooter.Location = new Point(0, 0);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(884, 35);
            lblFooter.TabIndex = 0;
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(248, 249, 250);
            pnlBody.Controls.Add(gbDangKy);
            pnlBody.Controls.Add(dgvNhanVien);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 35);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(20);
            pnlBody.Size = new Size(884, 491);
            pnlBody.TabIndex = 2;
            // 
            // gbDangKy
            // 
            gbDangKy.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbDangKy.BackColor = Color.Transparent;
            gbDangKy.Controls.Add(btnXoa);
            gbDangKy.Controls.Add(btnDangKy);
            gbDangKy.Controls.Add(btnDoiMatKhau);
            gbDangKy.Controls.Add(cbGioiTinh);
            gbDangKy.Controls.Add(txtMatKhau);
            gbDangKy.Controls.Add(txtDiaChi);
            gbDangKy.Controls.Add(txtSoDienThoai);
            gbDangKy.Controls.Add(txtTenNhanVien);
            gbDangKy.Controls.Add(txtMaNV);
            gbDangKy.Controls.Add(lblMatKhau);
            gbDangKy.Controls.Add(lblDiaChi);
            gbDangKy.Controls.Add(lblSoDienThoai);
            gbDangKy.Controls.Add(lblGioiTinh);
            gbDangKy.Controls.Add(lblTenNhanVien);
            gbDangKy.Controls.Add(lblMaNV);
            gbDangKy.Font = new Font("Segoe UI", 9.5F);
            gbDangKy.Location = new Point(20, 15);
            gbDangKy.Name = "gbDangKy";
            gbDangKy.Size = new Size(844, 215);
            gbDangKy.TabIndex = 0;
            gbDangKy.TabStop = false;
            gbDangKy.Text = "Đăng Ký";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.White;
            btnXoa.FlatAppearance.BorderColor = Color.Silver;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F);
            btnXoa.ForeColor = Color.SeaGreen;
            btnXoa.Location = new Point(565, 158);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(125, 38);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.White;
            btnDangKy.FlatAppearance.BorderColor = Color.Silver;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 10F);
            btnDangKy.ForeColor = Color.SeaGreen;
            btnDangKy.Location = new Point(355, 158);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(125, 38);
            btnDangKy.TabIndex = 13;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = false;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.BackColor = Color.White;
            btnDoiMatKhau.FlatAppearance.BorderColor = Color.Silver;
            btnDoiMatKhau.FlatStyle = FlatStyle.Flat;
            btnDoiMatKhau.Font = new Font("Segoe UI", 10F);
            btnDoiMatKhau.ForeColor = Color.SeaGreen;
            btnDoiMatKhau.Location = new Point(145, 158);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(125, 38);
            btnDoiMatKhau.TabIndex = 12;
            btnDoiMatKhau.Text = "Đổi Mật Khẩu";
            btnDoiMatKhau.UseVisualStyleBackColor = false;
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // cbGioiTinh
            // 
            cbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGioiTinh.FormattingEnabled = true;
            cbGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbGioiTinh.Location = new Point(145, 112);
            cbGioiTinh.Name = "cbGioiTinh";
            cbGioiTinh.Size = new Size(230, 25);
            cbGioiTinh.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(535, 112);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(230, 24);
            txtMatKhau.TabIndex = 11;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(535, 72);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(230, 24);
            txtDiaChi.TabIndex = 9;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(535, 32);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(230, 24);
            txtSoDienThoai.TabIndex = 7;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(145, 72);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(230, 24);
            txtTenNhanVien.TabIndex = 3;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(145, 32);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(230, 24);
            txtMaNV.TabIndex = 1;
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(435, 115);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(64, 17);
            lblMatKhau.TabIndex = 10;
            lblMatKhau.Text = "Mật Khẩu";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(435, 75);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(49, 17);
            lblDiaChi.TabIndex = 8;
            lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Location = new Point(435, 35);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(89, 17);
            lblSoDienThoai.TabIndex = 6;
            lblSoDienThoai.Text = "Số Điện Thoại";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(45, 115);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(59, 17);
            lblGioiTinh.TabIndex = 4;
            lblGioiTinh.Text = "Giới Tính";
            // 
            // lblTenNhanVien
            // 
            lblTenNhanVien.AutoSize = true;
            lblTenNhanVien.Location = new Point(45, 75);
            lblTenNhanVien.Name = "lblTenNhanVien";
            lblTenNhanVien.Size = new Size(92, 17);
            lblTenNhanVien.TabIndex = 2;
            lblTenNhanVien.Text = "Tên Nhân Viên";
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Location = new Point(45, 35);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(77, 17);
            lblMaNV.TabIndex = 0;
            lblMaNV.Text = "Mã NV - TK";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = Color.White;
            dgvNhanVien.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(70, 80, 250);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNhanVien.ColumnHeadersHeight = 32;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { colMaNV, colTenNV, colSDT, colGioiTinh, colDiaChi });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(215, 220, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.Location = new Point(20, 245);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.ReadOnly = true;
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(844, 226);
            dgvNhanVien.TabIndex = 1;
            // 
            // colMaNV
            // 
            colMaNV.HeaderText = "MaNhanVien";
            colMaNV.Name = "colMaNV";
            colMaNV.ReadOnly = true;
            // 
            // colTenNV
            // 
            colTenNV.HeaderText = "TenNhanVien";
            colTenNV.Name = "colTenNV";
            colTenNV.ReadOnly = true;
            // 
            // colSDT
            // 
            colSDT.HeaderText = "SoDienThoai";
            colSDT.Name = "colSDT";
            colSDT.ReadOnly = true;
            // 
            // colGioiTinh
            // 
            colGioiTinh.HeaderText = "GioiTinh";
            colGioiTinh.Name = "colGioiTinh";
            colGioiTinh.ReadOnly = true;
            // 
            // colDiaChi
            // 
            colDiaChi.HeaderText = "DiaChi";
            colDiaChi.Name = "colDiaChi";
            colDiaChi.ReadOnly = true;
            // 
            // FrmQuanLyNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(pnlBody);
            Controls.Add(pnlFooter);
            Controls.Add(pnlTitle);
            Name = "FrmQuanLyNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Nhân Viên";
            pnlTitle.ResumeLayout(false);
            pnlFooter.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            gbDangKy.ResumeLayout(false);
            gbDangKy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.GroupBox gbDangKy;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
    }
}