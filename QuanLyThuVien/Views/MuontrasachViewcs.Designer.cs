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
            this.gbThongTinSV = new System.Windows.Forms.GroupBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.txtTenSV = new System.Windows.Forms.TextBox();

            this.gbThongTinSach = new System.Windows.Forms.GroupBox();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.lblTenTG = new System.Windows.Forms.Label();
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.lblSLCon = new System.Windows.Forms.Label();
            this.txtSLCon = new System.Windows.Forms.TextBox();

            this.gbTimKiem = new System.Windows.Forms.GroupBox();
            this.rbMaSV = new System.Windows.Forms.RadioButton();
            this.rbMaSach = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();

            this.gbPhieuMuon = new System.Windows.Forms.GroupBox();
            this.lblMaPM = new System.Windows.Forms.Label();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.lblPMTenSach = new System.Windows.Forms.Label();
            this.cbPMTenSach = new System.Windows.Forms.ComboBox();
            this.lblPMMaSV = new System.Windows.Forms.Label();
            this.cbPMMaSV = new System.Windows.Forms.ComboBox();
            this.lblNgayMuon = new System.Windows.Forms.Label();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.lblTinhTrangSach = new System.Windows.Forms.Label();
            this.txtTinhTrangSach = new System.Windows.Forms.TextBox();

            this.btnMuon = new System.Windows.Forms.Button();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.dgvMuonTra = new System.Windows.Forms.DataGridView();

            this.gbThongTinSV.SuspendLayout();
            this.gbThongTinSach.SuspendLayout();
            this.gbTimKiem.SuspendLayout();
            this.gbPhieuMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuonTra)).BeginInit();
            this.SuspendLayout();

            // gbThongTinSV
            this.gbThongTinSV.Controls.Add(this.lblMaSV);
            this.gbThongTinSV.Controls.Add(this.txtMaSV);
            this.gbThongTinSV.Controls.Add(this.lblTenSV);
            this.gbThongTinSV.Controls.Add(this.txtTenSV);
            this.gbThongTinSV.Location = new System.Drawing.Point(12, 12);
            this.gbThongTinSV.Name = "gbThongTinSV";
            this.gbThongTinSV.Size = new System.Drawing.Size(280, 100);
            this.gbThongTinSV.TabStop = false;
            this.gbThongTinSV.Text = "Thông Tin Sinh Viên";

            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(15, 30);
            this.lblMaSV.Text = "Mã SV";

            this.txtMaSV.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaSV.Location = new System.Drawing.Point(90, 27);
            this.txtMaSV.Size = new System.Drawing.Size(170, 20);
            this.txtMaSV.Enabled = false;

            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Location = new System.Drawing.Point(15, 65);
            this.lblTenSV.Text = "Tên SV";

            this.txtTenSV.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTenSV.Location = new System.Drawing.Point(90, 62);
            this.txtTenSV.Size = new System.Drawing.Size(170, 20);
            this.txtTenSV.Enabled = false;

            // gbTimKiem
            this.gbTimKiem.Controls.Add(this.rbMaSV);
            this.gbTimKiem.Controls.Add(this.rbMaSach);
            this.gbTimKiem.Controls.Add(this.txtTimKiem);
            this.gbTimKiem.Location = new System.Drawing.Point(310, 12);
            this.gbTimKiem.Name = "gbTimKiem";
            this.gbTimKiem.Size = new System.Drawing.Size(560, 100);
            this.gbTimKiem.TabStop = false;
            this.gbTimKiem.Text = "Tìm Kiếm";

            this.rbMaSV.AutoSize = true;
            this.rbMaSV.Location = new System.Drawing.Point(30, 45);
            this.rbMaSV.Text = "Mã SV";

            this.rbMaSach.AutoSize = true;
            this.rbMaSach.Location = new System.Drawing.Point(110, 45);
            this.rbMaSach.Text = "Mã Sách";

            this.txtTimKiem.Location = new System.Drawing.Point(210, 43);
            this.txtTimKiem.Size = new System.Drawing.Size(320, 20);

            // gbThongTinSach
            this.gbThongTinSach.Controls.Add(this.lblMaSach);
            this.gbThongTinSach.Controls.Add(this.txtMaSach);
            this.gbThongTinSach.Controls.Add(this.lblTenSach);
            this.gbThongTinSach.Controls.Add(this.txtTenSach);
            this.gbThongTinSach.Controls.Add(this.lblTenTG);
            this.gbThongTinSach.Controls.Add(this.txtTenTG);
            this.gbThongTinSach.Controls.Add(this.lblSLCon);
            this.gbThongTinSach.Controls.Add(this.txtSLCon);
            this.gbThongTinSach.Location = new System.Drawing.Point(12, 130);
            this.gbThongTinSach.Name = "gbThongTinSach";
            this.gbThongTinSach.Size = new System.Drawing.Size(280, 170);
            this.gbThongTinSach.TabStop = false;
            this.gbThongTinSach.Text = "Thông Tin Sách";

            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Location = new System.Drawing.Point(15, 30);
            this.lblMaSach.Text = "Mã Sách";

            this.txtMaSach.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaSach.Location = new System.Drawing.Point(90, 27);
            this.txtMaSach.Size = new System.Drawing.Size(170, 20);
            this.txtMaSach.Enabled = false;

            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Location = new System.Drawing.Point(15, 65);
            this.lblTenSach.Text = "Tên Sách";

            this.txtTenSach.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTenSach.Location = new System.Drawing.Point(90, 62);
            this.txtTenSach.Size = new System.Drawing.Size(170, 20);
            this.txtTenSach.Enabled = false;

            this.lblTenTG.AutoSize = true;
            this.lblTenTG.Location = new System.Drawing.Point(15, 100);
            this.lblTenTG.Text = "Tên TG";

            this.txtTenTG.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTenTG.Location = new System.Drawing.Point(90, 97);
            this.txtTenTG.Size = new System.Drawing.Size(170, 20);
            this.txtTenTG.Enabled = false;

            this.lblSLCon.AutoSize = true;
            this.lblSLCon.Location = new System.Drawing.Point(15, 135);
            this.lblSLCon.Text = "SL Còn";

            this.txtSLCon.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSLCon.Location = new System.Drawing.Point(90, 132);
            this.txtSLCon.Size = new System.Drawing.Size(170, 20);
            this.txtSLCon.Enabled = false;

            // gbPhieuMuon
            this.gbPhieuMuon.Controls.Add(this.lblMaPM);
            this.gbPhieuMuon.Controls.Add(this.txtMaPM);
            this.gbPhieuMuon.Controls.Add(this.lblPMTenSach);
            this.gbPhieuMuon.Controls.Add(this.cbPMTenSach);
            this.gbPhieuMuon.Controls.Add(this.lblPMMaSV);
            this.gbPhieuMuon.Controls.Add(this.cbPMMaSV);
            this.gbPhieuMuon.Controls.Add(this.lblNgayMuon);
            this.gbPhieuMuon.Controls.Add(this.dtpNgayMuon);
            this.gbPhieuMuon.Controls.Add(this.lblNgayTra);
            this.gbPhieuMuon.Controls.Add(this.dtpNgayTra);
            this.gbPhieuMuon.Controls.Add(this.lblTinhTrangSach);
            this.gbPhieuMuon.Controls.Add(this.txtTinhTrangSach);
            this.gbPhieuMuon.Location = new System.Drawing.Point(310, 130);
            this.gbPhieuMuon.Name = "gbPhieuMuon";
            this.gbPhieuMuon.Size = new System.Drawing.Size(560, 170);
            this.gbPhieuMuon.TabStop = false;
            this.gbPhieuMuon.Text = "Phiếu Mượn";

            this.lblMaPM.AutoSize = true;
            this.lblMaPM.Location = new System.Drawing.Point(20, 30);
            this.lblMaPM.Text = "Mã PM";

            this.txtMaPM.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaPM.Location = new System.Drawing.Point(90, 27);
            this.txtMaPM.Size = new System.Drawing.Size(180, 20);
            this.txtMaPM.Enabled = false;

            this.lblPMTenSach.AutoSize = true;
            this.lblPMTenSach.Location = new System.Drawing.Point(20, 75);
            this.lblPMTenSach.Text = "Tên Sách";

            this.cbPMTenSach.FormattingEnabled = true;
            this.cbPMTenSach.Location = new System.Drawing.Point(90, 72);
            this.cbPMTenSach.Size = new System.Drawing.Size(180, 21);

            this.lblPMMaSV.AutoSize = true;
            this.lblPMMaSV.Location = new System.Drawing.Point(20, 120);
            this.lblPMMaSV.Text = "Mã SV";

            this.cbPMMaSV.FormattingEnabled = true;
            this.cbPMMaSV.Location = new System.Drawing.Point(90, 117);
            this.cbPMMaSV.Size = new System.Drawing.Size(180, 21);

            this.lblNgayMuon.AutoSize = true;
            this.lblNgayMuon.Location = new System.Drawing.Point(295, 30);
            this.lblNgayMuon.Text = "Ngày Mượn";

            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuon.Location = new System.Drawing.Point(380, 27);
            this.dtpNgayMuon.Size = new System.Drawing.Size(155, 20);

            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Location = new System.Drawing.Point(295, 75);
            this.lblNgayTra.Text = "Ngày Trả";

            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTra.Location = new System.Drawing.Point(380, 72);
            this.dtpNgayTra.Size = new System.Drawing.Size(155, 20);

            this.lblTinhTrangSach.AutoSize = true;
            this.lblTinhTrangSach.Location = new System.Drawing.Point(295, 120);
            this.lblTinhTrangSach.Text = "Tình Trạng Sách";

            this.txtTinhTrangSach.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTinhTrangSach.Location = new System.Drawing.Point(380, 117);
            this.txtTinhTrangSach.Size = new System.Drawing.Size(155, 20);
            this.txtTinhTrangSach.Enabled = false;

            // Buttons
            this.btnMuon.Location = new System.Drawing.Point(100, 320);
            this.btnMuon.Size = new System.Drawing.Size(90, 30);
            this.btnMuon.Text = "Mượn";
            this.btnMuon.UseVisualStyleBackColor = true;

            this.btnGiaHan.Location = new System.Drawing.Point(260, 320);
            this.btnGiaHan.Size = new System.Drawing.Size(90, 30);
            this.btnGiaHan.Text = "Gia Hạn";
            this.btnGiaHan.UseVisualStyleBackColor = true;

            this.btnTraSach.Location = new System.Drawing.Point(420, 320);
            this.btnTraSach.Size = new System.Drawing.Size(90, 30);
            this.btnTraSach.Text = "Trả Sách";
            this.btnTraSach.UseVisualStyleBackColor = true;

            this.btnLuu.Location = new System.Drawing.Point(580, 320);
            this.btnLuu.Size = new System.Drawing.Size(90, 30);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;

            this.btnHuyBo.Location = new System.Drawing.Point(740, 320);
            this.btnHuyBo.Size = new System.Drawing.Size(90, 30);
            this.btnHuyBo.Text = "Huỷ Bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;

            // DataGridView
            this.dgvMuonTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuonTra.Location = new System.Drawing.Point(12, 370);
            this.dgvMuonTra.Size = new System.Drawing.Size(858, 200);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 590);

            this.Controls.Add(this.dgvMuonTra);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTraSach);
            this.Controls.Add(this.btnGiaHan);
            this.Controls.Add(this.btnMuon);
            this.Controls.Add(this.gbPhieuMuon);
            this.Controls.Add(this.gbThongTinSach);
            this.Controls.Add(this.gbTimKiem);
            this.Controls.Add(this.gbThongTinSV);

            this.Name = "MuontrasachViewcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Mượn Trả Sách";

            this.gbThongTinSV.ResumeLayout(false);
            this.gbThongTinSV.PerformLayout();
            this.gbThongTinSach.ResumeLayout(false);
            this.gbThongTinSach.PerformLayout();
            this.gbTimKiem.ResumeLayout(false);
            this.gbTimKiem.PerformLayout();
            this.gbPhieuMuon.ResumeLayout(false);
            this.gbPhieuMuon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuonTra)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}