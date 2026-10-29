namespace QuanLyThuVien.Views
{
    partial class QuanlisachView
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

        private void InitializeComponent()
        {
            txtMaSach = new TextBox();
            txtTenSach = new TextBox();
            cmbTacGia = new ComboBox();
            btnThemTacGia = new Button();
            cmbNhaXuatBan = new ComboBox();
            btnThemNhaXuatBan = new Button();
            cmbLoaiSach = new ComboBox();
            btnThemTheLoai = new Button();
            txtSoTrang = new TextBox();
            txtGiaBan = new TextBox();
            txtSoLuong = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnGhi = new Button();
            btnHuyBo = new Button();
            btnTrangChu = new Button();
            dataGridView1 = new DataGridView();
            textBoxSearch = new TextBox();
            groupBoxSearch = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBoxSearch.SuspendLayout();
            SuspendLayout();
            // 
            // txtMaSach
            // 
            txtMaSach.Location = new Point(128, 159);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.ReadOnly = true;
            txtMaSach.Size = new Size(176, 23);
            txtMaSach.TabIndex = 0;
            // 
            // txtTenSach
            // 
            txtTenSach.Location = new Point(128, 202);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(176, 23);
            txtTenSach.TabIndex = 1;
            // 
            // cmbTacGia
            // 
            cmbTacGia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTacGia.FormattingEnabled = true;
            cmbTacGia.Location = new Point(128, 244);
            cmbTacGia.Name = "cmbTacGia";
            cmbTacGia.Size = new Size(140, 23);
            cmbTacGia.TabIndex = 2;
            // 
            // btnThemTacGia
            // 
            btnThemTacGia.Location = new Point(273, 243);
            btnThemTacGia.Name = "btnThemTacGia";
            btnThemTacGia.Size = new Size(31, 24);
            btnThemTacGia.TabIndex = 16;
            btnThemTacGia.Text = "+";
            btnThemTacGia.UseVisualStyleBackColor = true;
            btnThemTacGia.Click += btnThemTacGia_Click;
            // 
            // cmbNhaXuatBan
            // 
            cmbNhaXuatBan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNhaXuatBan.FormattingEnabled = true;
            cmbNhaXuatBan.Location = new Point(128, 286);
            cmbNhaXuatBan.Name = "cmbNhaXuatBan";
            cmbNhaXuatBan.Size = new Size(140, 23);
            cmbNhaXuatBan.TabIndex = 3;
            // 
            // btnThemNhaXuatBan
            // 
            btnThemNhaXuatBan.Location = new Point(273, 285);
            btnThemNhaXuatBan.Name = "btnThemNhaXuatBan";
            btnThemNhaXuatBan.Size = new Size(31, 24);
            btnThemNhaXuatBan.TabIndex = 17;
            btnThemNhaXuatBan.Text = "+";
            btnThemNhaXuatBan.UseVisualStyleBackColor = true;
            btnThemNhaXuatBan.Click += btnThemNhaXuatBan_Click;
            // 
            // cmbLoaiSach
            // 
            cmbLoaiSach.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLoaiSach.FormattingEnabled = true;
            cmbLoaiSach.Location = new Point(128, 328);
            cmbLoaiSach.Name = "cmbLoaiSach";
            cmbLoaiSach.Size = new Size(140, 23);
            cmbLoaiSach.TabIndex = 4;
            // 
            // btnThemTheLoai
            // 
            btnThemTheLoai.Location = new Point(273, 327);
            btnThemTheLoai.Name = "btnThemTheLoai";
            btnThemTheLoai.Size = new Size(31, 24);
            btnThemTheLoai.TabIndex = 18;
            btnThemTheLoai.Text = "+";
            btnThemTheLoai.UseVisualStyleBackColor = true;
            btnThemTheLoai.Click += btnThemTheLoai_Click;
            // 
            // txtSoTrang
            // 
            txtSoTrang.Location = new Point(128, 370);
            txtSoTrang.Name = "txtSoTrang";
            txtSoTrang.Size = new Size(176, 23);
            txtSoTrang.TabIndex = 5;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(128, 412);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(176, 23);
            txtGiaBan.TabIndex = 6;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(128, 455);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(176, 23);
            txtSoLuong.TabIndex = 7;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(32, 504);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(70, 33);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(120, 504);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(70, 33);
            btnSua.TabIndex = 9;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(207, 504);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(83, 33);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnGhi
            // 
            btnGhi.Location = new Point(32, 551);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(70, 33);
            btnGhi.TabIndex = 11;
            btnGhi.Text = "Ghi";
            btnGhi.UseVisualStyleBackColor = true;
            btnGhi.Click += btnGhi_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(120, 551);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(70, 33);
            btnHuyBo.TabIndex = 12;
            btnHuyBo.Text = "Huỷ bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.Location = new Point(207, 551);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(83, 33);
            btnTrangChu.TabIndex = 13;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = true;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.FromArgb(230, 230, 240);
            dataGridView1.Location = new Point(324, 70);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(525, 579);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch.Location = new Point(13, 19);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(499, 23);
            textBoxSearch.TabIndex = 0;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxSearch.Controls.Add(textBoxSearch);
            groupBoxSearch.Location = new Point(324, 14);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Size = new Size(525, 47);
            groupBoxSearch.TabIndex = 15;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Tìm kiếm theo Tên sách, Tác giả, Thể loại, NXB";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 162);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 26;
            label1.Text = "Mã Sách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 204);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 25;
            label2.Text = "Tên Sách";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 246);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 24;
            label3.Text = "Tác Giả";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 289);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 23;
            label4.Text = "Nhà Xuất Bản";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 331);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 22;
            label5.Text = "Loại Sách";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 373);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 21;
            label6.Text = "Năm XB";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 415);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 20;
            label7.Text = "Giá Bìa";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 457);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 19;
            label8.Text = "Số Lượng";
            // 
            // QuanlisachView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(866, 668);
            Controls.Add(groupBoxSearch);
            Controls.Add(dataGridView1);
            Controls.Add(btnTrangChu);
            Controls.Add(btnHuyBo);
            Controls.Add(btnGhi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtSoLuong);
            Controls.Add(txtGiaBan);
            Controls.Add(txtSoTrang);
            Controls.Add(btnThemTheLoai);
            Controls.Add(cmbLoaiSach);
            Controls.Add(btnThemNhaXuatBan);
            Controls.Add(cmbNhaXuatBan);
            Controls.Add(btnThemTacGia);
            Controls.Add(cmbTacGia);
            Controls.Add(txtTenSach);
            Controls.Add(txtMaSach);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "QuanlisachView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Sách";
            Load += QuanlisachView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.ComboBox cmbTacGia;
        private System.Windows.Forms.Button btnThemTacGia;
        private System.Windows.Forms.ComboBox cmbNhaXuatBan;
        private System.Windows.Forms.Button btnThemNhaXuatBan;
        private System.Windows.Forms.ComboBox cmbLoaiSach;
        private System.Windows.Forms.Button btnThemTheLoai;
        private System.Windows.Forms.TextBox txtSoTrang;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
