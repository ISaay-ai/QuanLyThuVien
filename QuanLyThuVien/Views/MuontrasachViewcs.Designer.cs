using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyThuVien.Views
{
    partial class MuontrasachViewcs
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox gbThongTinSV;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.TextBox txtTenSV;

        private System.Windows.Forms.GroupBox gbThongTinSach;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label lblTenTG;
        private System.Windows.Forms.TextBox txtTenTG;
        private System.Windows.Forms.Label lblSLCon;
        private System.Windows.Forms.TextBox txtSLCon;

        private System.Windows.Forms.GroupBox gbTimKiem;
        private System.Windows.Forms.RadioButton rbMaSV;
        private System.Windows.Forms.RadioButton rbMaSach;
        private System.Windows.Forms.TextBox txtTimKiem;

        private System.Windows.Forms.GroupBox gbPhieuMuon;
        private System.Windows.Forms.Label lblMaPM;
        private System.Windows.Forms.TextBox txtMaPM;
        private System.Windows.Forms.Label lblPMTenSach;
        private System.Windows.Forms.ComboBox cbPMTenSach;
        private System.Windows.Forms.Label lblPMMaSV;
        private System.Windows.Forms.ComboBox cbPMMaSV;
        private System.Windows.Forms.Label lblNgayMuon;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Label lblTinhTrangSach;
        private System.Windows.Forms.TextBox txtTinhTrangSach;

        private System.Windows.Forms.Button btnMuon;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuyBo;

        private System.Windows.Forms.DataGridView dgvMuonTra;

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
            gbThongTinSV = new GroupBox();
            lblMaSV = new Label();
            txtMaSV = new TextBox();
            lblTenSV = new Label();
            txtTenSV = new TextBox();
            gbThongTinSach = new GroupBox();
            lblMaSach = new Label();
            txtMaSach = new TextBox();
            lblTenSach = new Label();
            txtTenSach = new TextBox();
            lblTenTG = new Label();
            txtTenTG = new TextBox();
            lblSLCon = new Label();
            txtSLCon = new TextBox();
            gbTimKiem = new GroupBox();
            rbMaSV = new RadioButton();
            rbMaSach = new RadioButton();
            txtTimKiem = new TextBox();
            gbPhieuMuon = new GroupBox();
            lblMaPM = new Label();
            txtMaPM = new TextBox();
            lblPMTenSach = new Label();
            cbPMTenSach = new ComboBox();
            lblPMMaSV = new Label();
            cbPMMaSV = new ComboBox();
            lblNgayMuon = new Label();
            dtpNgayMuon = new DateTimePicker();
            lblNgayTra = new Label();
            dtpNgayTra = new DateTimePicker();
            lblTinhTrangSach = new Label();
            txtTinhTrangSach = new TextBox();
            btnMuon = new Button();
            btnGiaHan = new Button();
            btnTraSach = new Button();
            btnLuu = new Button();
            btnHuyBo = new Button();
            dgvMuonTra = new DataGridView();
            gbThongTinSV.SuspendLayout();
            gbThongTinSach.SuspendLayout();
            gbTimKiem.SuspendLayout();
            gbPhieuMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMuonTra).BeginInit();
            SuspendLayout();
            // 
            // gbThongTinSV
            // 
            gbThongTinSV.Controls.Add(lblMaSV);
            gbThongTinSV.Controls.Add(txtMaSV);
            gbThongTinSV.Controls.Add(lblTenSV);
            gbThongTinSV.Controls.Add(txtTenSV);
            gbThongTinSV.Font = new Font("Segoe UI", 9.5F);
            gbThongTinSV.Location = new Point(12, 12);
            gbThongTinSV.Name = "gbThongTinSV";
            gbThongTinSV.Size = new Size(280, 100);
            gbThongTinSV.TabIndex = 0;
            gbThongTinSV.TabStop = false;
            gbThongTinSV.Text = "Thông Tin Sinh Viên";
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(15, 30);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(46, 17);
            lblMaSV.TabIndex = 0;
            lblMaSV.Text = "Mã SV";
            // 
            // txtMaSV
            // 
            txtMaSV.BackColor = SystemColors.ControlLight;
            txtMaSV.Location = new Point(90, 27);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.ReadOnly = true;
            txtMaSV.Size = new Size(170, 24);
            txtMaSV.TabIndex = 1;
            // 
            // lblTenSV
            // 
            lblTenSV.AutoSize = true;
            lblTenSV.Location = new Point(15, 65);
            lblTenSV.Name = "lblTenSV";
            lblTenSV.Size = new Size(47, 17);
            lblTenSV.TabIndex = 2;
            lblTenSV.Text = "Tên SV";
            // 
            // txtTenSV
            // 
            txtTenSV.BackColor = SystemColors.ControlLight;
            txtTenSV.Location = new Point(90, 62);
            txtTenSV.Name = "txtTenSV";
            txtTenSV.ReadOnly = true;
            txtTenSV.Size = new Size(170, 24);
            txtTenSV.TabIndex = 3;
            // 
            // gbThongTinSach
            // 
            gbThongTinSach.Controls.Add(lblMaSach);
            gbThongTinSach.Controls.Add(txtMaSach);
            gbThongTinSach.Controls.Add(lblTenSach);
            gbThongTinSach.Controls.Add(txtTenSach);
            gbThongTinSach.Controls.Add(lblTenTG);
            gbThongTinSach.Controls.Add(txtTenTG);
            gbThongTinSach.Controls.Add(lblSLCon);
            gbThongTinSach.Controls.Add(txtSLCon);
            gbThongTinSach.Font = new Font("Segoe UI", 9.5F);
            gbThongTinSach.Location = new Point(12, 125);
            gbThongTinSach.Name = "gbThongTinSach";
            gbThongTinSach.Size = new Size(280, 180);
            gbThongTinSach.TabIndex = 2;
            gbThongTinSach.TabStop = false;
            gbThongTinSach.Text = "Thông Tin Sách";
            // 
            // lblMaSach
            // 
            lblMaSach.AutoSize = true;
            lblMaSach.Location = new Point(15, 30);
            lblMaSach.Name = "lblMaSach";
            lblMaSach.Size = new Size(58, 17);
            lblMaSach.TabIndex = 0;
            lblMaSach.Text = "Mã Sách";
            // 
            // txtMaSach
            // 
            txtMaSach.BackColor = SystemColors.ControlLight;
            txtMaSach.Location = new Point(90, 27);
            txtMaSach.Name = "txtMaSach";
            txtMaSach.ReadOnly = true;
            txtMaSach.Size = new Size(170, 24);
            txtMaSach.TabIndex = 1;
            // 
            // lblTenSach
            // 
            lblTenSach.AutoSize = true;
            lblTenSach.Location = new Point(15, 68);
            lblTenSach.Name = "lblTenSach";
            lblTenSach.Size = new Size(59, 17);
            lblTenSach.TabIndex = 2;
            lblTenSach.Text = "Tên Sách";
            // 
            // txtTenSach
            // 
            txtTenSach.BackColor = SystemColors.ControlLight;
            txtTenSach.Location = new Point(90, 65);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.ReadOnly = true;
            txtTenSach.Size = new Size(170, 24);
            txtTenSach.TabIndex = 3;
            // 
            // lblTenTG
            // 
            lblTenTG.AutoSize = true;
            lblTenTG.Location = new Point(15, 105);
            lblTenTG.Name = "lblTenTG";
            lblTenTG.Size = new Size(47, 17);
            lblTenTG.TabIndex = 4;
            lblTenTG.Text = "Tên TG";
            // 
            // txtTenTG
            // 
            txtTenTG.BackColor = SystemColors.ControlLight;
            txtTenTG.Location = new Point(90, 102);
            txtTenTG.Name = "txtTenTG";
            txtTenTG.ReadOnly = true;
            txtTenTG.Size = new Size(170, 24);
            txtTenTG.TabIndex = 5;
            // 
            // lblSLCon
            // 
            lblSLCon.AutoSize = true;
            lblSLCon.Location = new Point(15, 142);
            lblSLCon.Name = "lblSLCon";
            lblSLCon.Size = new Size(48, 17);
            lblSLCon.TabIndex = 6;
            lblSLCon.Text = "SL Còn";
            // 
            // txtSLCon
            // 
            txtSLCon.BackColor = SystemColors.ControlLight;
            txtSLCon.Location = new Point(90, 139);
            txtSLCon.Name = "txtSLCon";
            txtSLCon.ReadOnly = true;
            txtSLCon.Size = new Size(170, 24);
            txtSLCon.TabIndex = 7;
            // 
            // gbTimKiem
            // 
            gbTimKiem.Controls.Add(rbMaSV);
            gbTimKiem.Controls.Add(rbMaSach);
            gbTimKiem.Controls.Add(txtTimKiem);
            gbTimKiem.Font = new Font("Segoe UI", 9.5F);
            gbTimKiem.Location = new Point(310, 12);
            gbTimKiem.Name = "gbTimKiem";
            gbTimKiem.Size = new Size(560, 100);
            gbTimKiem.TabIndex = 1;
            gbTimKiem.TabStop = false;
            gbTimKiem.Text = "Tìm Kiếm";
            // 
            // rbMaSV
            // 
            rbMaSV.AutoSize = true;
            rbMaSV.Checked = true;
            rbMaSV.Location = new Point(30, 42);
            rbMaSV.Name = "rbMaSV";
            rbMaSV.Size = new Size(64, 21);
            rbMaSV.TabIndex = 0;
            rbMaSV.TabStop = true;
            rbMaSV.Text = "Mã SV";
            rbMaSV.UseVisualStyleBackColor = true;
            rbMaSV.CheckedChanged += rbTimKiem_CheckedChanged;
            // 
            // rbMaSach
            // 
            rbMaSach.AutoSize = true;
            rbMaSach.Location = new Point(115, 42);
            rbMaSach.Name = "rbMaSach";
            rbMaSach.Size = new Size(76, 21);
            rbMaSach.TabIndex = 1;
            rbMaSach.Text = "Mã Sách";
            rbMaSach.UseVisualStyleBackColor = true;
            rbMaSach.CheckedChanged += rbTimKiem_CheckedChanged;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 10F);
            txtTimKiem.Location = new Point(210, 40);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập mã SV/tên SV hoặc mã/tên sách...";
            txtTimKiem.Size = new Size(325, 25);
            txtTimKiem.TabIndex = 2;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // gbPhieuMuon
            // 
            gbPhieuMuon.Controls.Add(lblMaPM);
            gbPhieuMuon.Controls.Add(txtMaPM);
            gbPhieuMuon.Controls.Add(lblPMTenSach);
            gbPhieuMuon.Controls.Add(cbPMTenSach);
            gbPhieuMuon.Controls.Add(lblPMMaSV);
            gbPhieuMuon.Controls.Add(cbPMMaSV);
            gbPhieuMuon.Controls.Add(lblNgayMuon);
            gbPhieuMuon.Controls.Add(dtpNgayMuon);
            gbPhieuMuon.Controls.Add(lblNgayTra);
            gbPhieuMuon.Controls.Add(dtpNgayTra);
            gbPhieuMuon.Controls.Add(lblTinhTrangSach);
            gbPhieuMuon.Controls.Add(txtTinhTrangSach);
            gbPhieuMuon.Font = new Font("Segoe UI", 9.5F);
            gbPhieuMuon.Location = new Point(310, 125);
            gbPhieuMuon.Name = "gbPhieuMuon";
            gbPhieuMuon.Size = new Size(560, 180);
            gbPhieuMuon.TabIndex = 3;
            gbPhieuMuon.TabStop = false;
            gbPhieuMuon.Text = "Phiếu Mượn";
            // 
            // lblMaPM
            // 
            lblMaPM.AutoSize = true;
            lblMaPM.Location = new Point(20, 30);
            lblMaPM.Name = "lblMaPM";
            lblMaPM.Size = new Size(50, 17);
            lblMaPM.TabIndex = 0;
            lblMaPM.Text = "Mã PM";
            // 
            // txtMaPM
            // 
            txtMaPM.BackColor = SystemColors.ControlLight;
            txtMaPM.Location = new Point(90, 27);
            txtMaPM.Name = "txtMaPM";
            txtMaPM.ReadOnly = true;
            txtMaPM.Size = new Size(180, 24);
            txtMaPM.TabIndex = 1;
            // 
            // lblPMTenSach
            // 
            lblPMTenSach.AutoSize = true;
            lblPMTenSach.Location = new Point(20, 75);
            lblPMTenSach.Name = "lblPMTenSach";
            lblPMTenSach.Size = new Size(59, 17);
            lblPMTenSach.TabIndex = 2;
            lblPMTenSach.Text = "Tên Sách";
            // 
            // cbPMTenSach
            // 
            cbPMTenSach.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPMTenSach.FormattingEnabled = true;
            cbPMTenSach.Location = new Point(90, 72);
            cbPMTenSach.Name = "cbPMTenSach";
            cbPMTenSach.Size = new Size(180, 25);
            cbPMTenSach.TabIndex = 3;
            cbPMTenSach.SelectedIndexChanged += cbPMTenSach_SelectedIndexChanged;
            // 
            // lblPMMaSV
            // 
            lblPMMaSV.AutoSize = true;
            lblPMMaSV.Location = new Point(20, 120);
            lblPMMaSV.Name = "lblPMMaSV";
            lblPMMaSV.Size = new Size(46, 17);
            lblPMMaSV.TabIndex = 4;
            lblPMMaSV.Text = "Mã SV";
            // 
            // cbPMMaSV
            // 
            cbPMMaSV.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPMMaSV.FormattingEnabled = true;
            cbPMMaSV.Location = new Point(90, 117);
            cbPMMaSV.Name = "cbPMMaSV";
            cbPMMaSV.Size = new Size(180, 25);
            cbPMMaSV.TabIndex = 5;
            cbPMMaSV.SelectedIndexChanged += cbPMMaSV_SelectedIndexChanged;
            // 
            // lblNgayMuon
            // 
            lblNgayMuon.AutoSize = true;
            lblNgayMuon.Location = new Point(295, 30);
            lblNgayMuon.Name = "lblNgayMuon";
            lblNgayMuon.Size = new Size(78, 17);
            lblNgayMuon.TabIndex = 6;
            lblNgayMuon.Text = "Ngày Mượn";
            // 
            // dtpNgayMuon
            // 
            dtpNgayMuon.Format = DateTimePickerFormat.Short;
            dtpNgayMuon.Location = new Point(380, 27);
            dtpNgayMuon.Name = "dtpNgayMuon";
            dtpNgayMuon.Size = new Size(155, 24);
            dtpNgayMuon.TabIndex = 7;
            // 
            // lblNgayTra
            // 
            lblNgayTra.AutoSize = true;
            lblNgayTra.Location = new Point(295, 75);
            lblNgayTra.Name = "lblNgayTra";
            lblNgayTra.Size = new Size(53, 17);
            lblNgayTra.TabIndex = 8;
            lblNgayTra.Text = "Hạn Trả";
            // 
            // dtpNgayTra
            // 
            dtpNgayTra.Format = DateTimePickerFormat.Short;
            dtpNgayTra.Location = new Point(380, 72);
            dtpNgayTra.Name = "dtpNgayTra";
            dtpNgayTra.Size = new Size(155, 24);
            dtpNgayTra.TabIndex = 9;
            // 
            // lblTinhTrangSach
            // 
            lblTinhTrangSach.AutoSize = true;
            lblTinhTrangSach.Location = new Point(295, 120);
            lblTinhTrangSach.Name = "lblTinhTrangSach";
            lblTinhTrangSach.Size = new Size(69, 17);
            lblTinhTrangSach.TabIndex = 10;
            lblTinhTrangSach.Text = "Tình Trạng";
            // 
            // txtTinhTrangSach
            // 
            txtTinhTrangSach.BackColor = SystemColors.ControlLight;
            txtTinhTrangSach.Location = new Point(380, 117);
            txtTinhTrangSach.Name = "txtTinhTrangSach";
            txtTinhTrangSach.ReadOnly = true;
            txtTinhTrangSach.Size = new Size(155, 24);
            txtTinhTrangSach.TabIndex = 11;
            // 
            // btnMuon
            // 
            btnMuon.BackColor = Color.LimeGreen;
            btnMuon.Cursor = Cursors.Hand;
            btnMuon.FlatStyle = FlatStyle.Flat;
            btnMuon.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMuon.ForeColor = Color.White;
            btnMuon.Location = new Point(70, 320);
            btnMuon.Name = "btnMuon";
            btnMuon.Size = new Size(110, 36);
            btnMuon.TabIndex = 4;
            btnMuon.Text = "Mượn";
            btnMuon.UseVisualStyleBackColor = false;
            btnMuon.Click += btnMuon_Click;
            // 
            // btnGiaHan
            // 
            btnGiaHan.BackColor = Color.FromArgb(53, 162, 184);
            btnGiaHan.Cursor = Cursors.Hand;
            btnGiaHan.FlatStyle = FlatStyle.Flat;
            btnGiaHan.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGiaHan.ForeColor = Color.White;
            btnGiaHan.Location = new Point(230, 320);
            btnGiaHan.Name = "btnGiaHan";
            btnGiaHan.Size = new Size(110, 36);
            btnGiaHan.TabIndex = 5;
            btnGiaHan.Text = "Gia Hạn";
            btnGiaHan.UseVisualStyleBackColor = false;
            btnGiaHan.Click += btnGiaHan_Click;
            // 
            // btnTraSach
            // 
            btnTraSach.BackColor = Color.FromArgb(192, 0, 0);
            btnTraSach.Cursor = Cursors.Hand;
            btnTraSach.FlatStyle = FlatStyle.Flat;
            btnTraSach.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTraSach.ForeColor = Color.White;
            btnTraSach.Location = new Point(390, 320);
            btnTraSach.Name = "btnTraSach";
            btnTraSach.Size = new Size(110, 36);
            btnTraSach.TabIndex = 6;
            btnTraSach.Text = "Trả Sách";
            btnTraSach.UseVisualStyleBackColor = false;
            btnTraSach.Click += btnTraSach_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(0, 192, 0);
            btnLuu.Cursor = Cursors.Hand;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(550, 320);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(110, 36);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.BackColor = SystemColors.ControlDark;
            btnHuyBo.Cursor = Cursors.Hand;
            btnHuyBo.FlatStyle = FlatStyle.Flat;
            btnHuyBo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuyBo.ForeColor = Color.White;
            btnHuyBo.Location = new Point(710, 320);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(110, 36);
            btnHuyBo.TabIndex = 8;
            btnHuyBo.Text = "Huỷ Bỏ";
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // dgvMuonTra
            // 
            dgvMuonTra.AllowUserToAddRows = false;
            dgvMuonTra.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(248, 248, 255);
            dgvMuonTra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvMuonTra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMuonTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMuonTra.BorderStyle = BorderStyle.None;
            dgvMuonTra.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMuonTra.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(88, 86, 245);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dgvMuonTra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvMuonTra.ColumnHeadersHeight = 36;
            dgvMuonTra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.Padding = new Padding(6, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(232, 230, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvMuonTra.DefaultCellStyle = dataGridViewCellStyle6;
            dgvMuonTra.EnableHeadersVisualStyles = false;
            dgvMuonTra.GridColor = Color.White;
            dgvMuonTra.Location = new Point(12, 372);
            dgvMuonTra.MultiSelect = false;
            dgvMuonTra.Name = "dgvMuonTra";
            dgvMuonTra.ReadOnly = true;
            dgvMuonTra.RowHeadersVisible = false;
            dgvMuonTra.RowTemplate.Height = 30;
            dgvMuonTra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMuonTra.Size = new Size(858, 206);
            dgvMuonTra.TabIndex = 9;
            dgvMuonTra.CellClick += dgvMuonTra_CellClick;
            // 
            // MuontrasachViewcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(885, 590);
            Controls.Add(dgvMuonTra);
            Controls.Add(btnHuyBo);
            Controls.Add(btnLuu);
            Controls.Add(btnTraSach);
            Controls.Add(btnGiaHan);
            Controls.Add(btnMuon);
            Controls.Add(gbPhieuMuon);
            Controls.Add(gbThongTinSach);
            Controls.Add(gbTimKiem);
            Controls.Add(gbThongTinSV);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MuontrasachViewcs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Mượn Trả Sách";
            gbThongTinSV.ResumeLayout(false);
            gbThongTinSV.PerformLayout();
            gbThongTinSach.ResumeLayout(false);
            gbThongTinSach.PerformLayout();
            gbTimKiem.ResumeLayout(false);
            gbTimKiem.PerformLayout();
            gbPhieuMuon.ResumeLayout(false);
            gbPhieuMuon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMuonTra).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
