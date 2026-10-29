namespace QuanLyThuVien.GUI.Views
{
    partial class TrasachView
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblTextSoNgayTre = new System.Windows.Forms.Label();
            this.lblSoNgayTre = new System.Windows.Forms.Label();
            this.dtpNgayTraThucTe = new System.Windows.Forms.DateTimePicker();
            this.lblNgayTraThucTe = new System.Windows.Forms.Label();
            this.dtpNgayHenTra = new System.Windows.Forms.DateTimePicker();
            this.lblNgayHenTra = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.lblMaPM = new System.Windows.Forms.Label();
            this.chkCoViPham = new System.Windows.Forms.CheckBox();
            this.pnlPhat = new System.Windows.Forms.Panel();
            this.txtLyDo = new System.Windows.Forms.TextBox();
            this.lblLyDo = new System.Windows.Forms.Label();
            this.txtTienPhat = new System.Windows.Forms.TextBox();
            this.lblTienPhat = new System.Windows.Forms.Label();
            this.cboQuyDinhPhat = new System.Windows.Forms.ComboBox();
            this.lblQuyDinh = new System.Windows.Forms.Label();
            this.btnXacNhanTra = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            this.pnlPhat.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(584, 45);
            this.pnlHeader.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(180, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(225, 25);
            this.lblTitle.Text = "XÁC NHẬN TRẢ SÁCH";

            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.lblTextSoNgayTre);
            this.grpThongTin.Controls.Add(this.lblSoNgayTre);
            this.grpThongTin.Controls.Add(this.dtpNgayTraThucTe);
            this.grpThongTin.Controls.Add(this.lblNgayTraThucTe);
            this.grpThongTin.Controls.Add(this.dtpNgayHenTra);
            this.grpThongTin.Controls.Add(this.lblNgayHenTra);
            this.grpThongTin.Controls.Add(this.txtMaSach);
            this.grpThongTin.Controls.Add(this.lblMaSach);
            this.grpThongTin.Controls.Add(this.txtMaSV);
            this.grpThongTin.Controls.Add(this.lblMaSV);
            this.grpThongTin.Controls.Add(this.txtMaPM);
            this.grpThongTin.Controls.Add(this.lblMaPM);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.grpThongTin.Location = new System.Drawing.Point(12, 55);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(560, 140);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông Tin Trả Sách";

            // lblMaPM
            this.lblMaPM.AutoSize = true;
            this.lblMaPM.Location = new System.Drawing.Point(15, 30);
            this.lblMaPM.Name = "lblMaPM";
            this.lblMaPM.Size = new System.Drawing.Size(53, 17);
            this.lblMaPM.Text = "Mã PM:";

            // txtMaPM
            this.txtMaPM.Location = new System.Drawing.Point(85, 27);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.ReadOnly = true;
            this.txtMaPM.Size = new System.Drawing.Size(170, 24);
            this.txtMaPM.TabIndex = 0;

            // lblMaSV
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(15, 65);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(49, 17);
            this.lblMaSV.Text = "Mã SV:";

            // txtMaSV
            this.txtMaSV.Location = new System.Drawing.Point(85, 62);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.ReadOnly = true;
            this.txtMaSV.Size = new System.Drawing.Size(170, 24);
            this.txtMaSV.TabIndex = 1;

            // lblMaSach
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Location = new System.Drawing.Point(15, 100);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(61, 17);
            this.lblMaSach.Text = "Mã Sách:";

            // txtMaSach
            this.txtMaSach.Location = new System.Drawing.Point(85, 97);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.ReadOnly = true;
            this.txtMaSach.Size = new System.Drawing.Size(170, 24);
            this.txtMaSach.TabIndex = 2;

            // lblNgayHenTra
            this.lblNgayHenTra.AutoSize = true;
            this.lblNgayHenTra.Location = new System.Drawing.Point(280, 30);
            this.lblNgayHenTra.Name = "lblNgayHenTra";
            this.lblNgayHenTra.Size = new System.Drawing.Size(59, 17);
            this.lblNgayHenTra.Text = "Hạn Trả:";

            // dtpNgayHenTra
            this.dtpNgayHenTra.Enabled = false;
            this.dtpNgayHenTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHenTra.Location = new System.Drawing.Point(370, 27);
            this.dtpNgayHenTra.Name = "dtpNgayHenTra";
            this.dtpNgayHenTra.Size = new System.Drawing.Size(175, 24);
            this.dtpNgayHenTra.TabIndex = 3;

            // lblNgayTraThucTe
            this.lblNgayTraThucTe.AutoSize = true;
            this.lblNgayTraThucTe.Location = new System.Drawing.Point(280, 65);
            this.lblNgayTraThucTe.Name = "lblNgayTraThucTe";
            this.lblNgayTraThucTe.Size = new System.Drawing.Size(65, 17);
            this.lblNgayTraThucTe.Text = "Ngày Trả:";

            // dtpNgayTraThucTe
            this.dtpNgayTraThucTe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTraThucTe.Location = new System.Drawing.Point(370, 62);
            this.dtpNgayTraThucTe.Name = "dtpNgayTraThucTe";
            this.dtpNgayTraThucTe.Size = new System.Drawing.Size(175, 24);
            this.dtpNgayTraThucTe.TabIndex = 4;

            // lblTextSoNgayTre
            this.lblTextSoNgayTre.AutoSize = true;
            this.lblTextSoNgayTre.Location = new System.Drawing.Point(280, 100);
            this.lblTextSoNgayTre.Name = "lblTextSoNgayTre";
            this.lblTextSoNgayTre.Size = new System.Drawing.Size(56, 17);
            this.lblTextSoNgayTre.Text = "Trễ Hạn:";

            // lblSoNgayTre
            this.lblSoNgayTre.AutoSize = true;
            this.lblSoNgayTre.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSoNgayTre.ForeColor = System.Drawing.Color.Red;
            this.lblSoNgayTre.Location = new System.Drawing.Point(370, 100);
            this.lblSoNgayTre.Name = "lblSoNgayTre";
            this.lblSoNgayTre.Size = new System.Drawing.Size(48, 17);
            this.lblSoNgayTre.Text = "0 ngày";

            // 
            // chkCoViPham
            // 
            this.chkCoViPham.AutoSize = true;
            this.chkCoViPham.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.chkCoViPham.ForeColor = System.Drawing.Color.DarkRed;
            this.chkCoViPham.Location = new System.Drawing.Point(12, 205);
            this.chkCoViPham.Name = "chkCoViPham";
            this.chkCoViPham.Size = new System.Drawing.Size(250, 21);
            this.chkCoViPham.TabIndex = 2;
            this.chkCoViPham.Text = "Có Vi Phạm (Xử Lý & Tính Tiền Phạt)";
            this.chkCoViPham.UseVisualStyleBackColor = true;

            // 
            // pnlPhat
            // 
            this.pnlPhat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPhat.Controls.Add(this.txtLyDo);
            this.pnlPhat.Controls.Add(this.lblLyDo);
            this.pnlPhat.Controls.Add(this.txtTienPhat);
            this.pnlPhat.Controls.Add(this.lblTienPhat);
            this.pnlPhat.Controls.Add(this.cboQuyDinhPhat);
            this.pnlPhat.Controls.Add(this.lblQuyDinh);
            this.pnlPhat.Enabled = false;
            this.pnlPhat.Location = new System.Drawing.Point(12, 232);
            this.pnlPhat.Name = "pnlPhat";
            this.pnlPhat.Size = new System.Drawing.Size(560, 125);
            this.pnlPhat.TabIndex = 3;

            // lblQuyDinh
            this.lblQuyDinh.AutoSize = true;
            this.lblQuyDinh.Location = new System.Drawing.Point(12, 15);
            this.lblQuyDinh.Name = "lblQuyDinh";
            this.lblQuyDinh.Size = new System.Drawing.Size(64, 15);
            this.lblQuyDinh.Text = "Quy Định:";

            // cboQuyDinhPhat
            this.cboQuyDinhPhat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuyDinhPhat.FormattingEnabled = true;
            this.cboQuyDinhPhat.Location = new System.Drawing.Point(82, 12);
            this.cboQuyDinhPhat.Name = "cboQuyDinhPhat";
            this.cboQuyDinhPhat.Size = new System.Drawing.Size(462, 23);
            this.cboQuyDinhPhat.TabIndex = 0;

            // lblTienPhat
            this.lblTienPhat.AutoSize = true;
            this.lblTienPhat.Location = new System.Drawing.Point(12, 48);
            this.lblTienPhat.Name = "lblTienPhat";
            this.lblTienPhat.Size = new System.Drawing.Size(61, 15);
            this.lblTienPhat.Text = "Tiền Phạt:";

            // txtTienPhat
            this.txtTienPhat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtTienPhat.ForeColor = System.Drawing.Color.DarkRed;
            this.txtTienPhat.Location = new System.Drawing.Point(82, 45);
            this.txtTienPhat.Name = "txtTienPhat";
            this.txtTienPhat.ReadOnly = true;
            this.txtTienPhat.Size = new System.Drawing.Size(200, 25);
            this.txtTienPhat.TabIndex = 1;

            // lblLyDo
            this.lblLyDo.AutoSize = true;
            this.lblLyDo.Location = new System.Drawing.Point(12, 80);
            this.lblLyDo.Name = "lblLyDo";
            this.lblLyDo.Size = new System.Drawing.Size(53, 15);
            this.lblLyDo.Text = "Ghi Chú:";

            // txtLyDo
            this.txtLyDo.Location = new System.Drawing.Point(82, 77);
            this.txtLyDo.Multiline = true;
            this.txtLyDo.Name = "txtLyDo";
            this.txtLyDo.Size = new System.Drawing.Size(462, 35);
            this.txtLyDo.TabIndex = 2;

            // 
            // btnXacNhanTra
            // 
            this.btnXacNhanTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXacNhanTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhanTra.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXacNhanTra.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanTra.Location = new System.Drawing.Point(320, 370);
            this.btnXacNhanTra.Name = "btnXacNhanTra";
            this.btnXacNhanTra.Size = new System.Drawing.Size(130, 35);
            this.btnXacNhanTra.TabIndex = 4;
            this.btnXacNhanTra.Text = "✓ Hoàn Thành";
            this.btnXacNhanTra.UseVisualStyleBackColor = false;

            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Gray;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(460, 370);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(112, 35);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "✕ Hủy Bỏ";
            this.btnHuy.UseVisualStyleBackColor = false;

            // 
            // TrasachView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 420);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhanTra);
            this.Controls.Add(this.pnlPhat);
            this.Controls.Add(this.chkCoViPham);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrasachView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xác Nhận Trả Sách";

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.pnlPhat.ResumeLayout(false);
            this.pnlPhat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaPM;
        private System.Windows.Forms.TextBox txtMaPM;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label lblNgayHenTra;
        private System.Windows.Forms.DateTimePicker dtpNgayHenTra;
        private System.Windows.Forms.Label lblNgayTraThucTe;
        private System.Windows.Forms.DateTimePicker dtpNgayTraThucTe;
        private System.Windows.Forms.Label lblTextSoNgayTre;
        private System.Windows.Forms.Label lblSoNgayTre;
        private System.Windows.Forms.CheckBox chkCoViPham;
        private System.Windows.Forms.Panel pnlPhat;
        private System.Windows.Forms.Label lblQuyDinh;
        private System.Windows.Forms.ComboBox cboQuyDinhPhat;
        private System.Windows.Forms.Label lblTienPhat;
        private System.Windows.Forms.TextBox txtTienPhat;
        private System.Windows.Forms.Label lblLyDo;
        private System.Windows.Forms.TextBox txtLyDo;
        private System.Windows.Forms.Button btnXacNhanTra;
        private System.Windows.Forms.Button btnHuy;
    }
}