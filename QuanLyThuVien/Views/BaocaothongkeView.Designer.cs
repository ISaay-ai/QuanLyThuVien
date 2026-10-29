namespace QuanLyThuVien.Views
{
    partial class BaocaothongkeView
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox grpThongKeSach;
        private System.Windows.Forms.Panel pnlSach;
        private System.Windows.Forms.Label lblCountSach;
        private System.Windows.Forms.Label lblTextSach;
        private System.Windows.Forms.Panel pnlLoaiSach;
        private System.Windows.Forms.Label lblCountLoaiSach;
        private System.Windows.Forms.Label lblTextLoaiSach;
        private System.Windows.Forms.Panel pnlTacGia;
        private System.Windows.Forms.Label lblCountTacGia;
        private System.Windows.Forms.Label lblTextTacGia;
        private System.Windows.Forms.Panel pnlNXB;
        private System.Windows.Forms.Label lblCountNXB;
        private System.Windows.Forms.Label lblTextNXB;

        private System.Windows.Forms.GroupBox grpThongKeDocGia;
        private System.Windows.Forms.Panel pnlDocGia;
        private System.Windows.Forms.Label lblCountDocGia;
        private System.Windows.Forms.Label lblTextDocGia;
        private System.Windows.Forms.Panel pnlSachMuon;
        private System.Windows.Forms.Label lblCountSachMuon;
        private System.Windows.Forms.Label lblTextSachMuon;

        private System.Windows.Forms.GroupBox grpThongKeMuonQuaHan;
        private System.Windows.Forms.Button btnDangMuon;
        private System.Windows.Forms.Button btnDaTra;
        private System.Windows.Forms.Button btnDSQuaHan;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Label lblTitleList;
        private System.Windows.Forms.Label lblTongSo;
        private System.Windows.Forms.DataGridView dgvData;

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
            System.Windows.Forms.DataGridViewCellStyle dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvAltRowStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.grpThongKeSach = new System.Windows.Forms.GroupBox();
            this.pnlSach = new System.Windows.Forms.Panel();
            this.lblCountSach = new System.Windows.Forms.Label();
            this.lblTextSach = new System.Windows.Forms.Label();
            this.pnlLoaiSach = new System.Windows.Forms.Panel();
            this.lblCountLoaiSach = new System.Windows.Forms.Label();
            this.lblTextLoaiSach = new System.Windows.Forms.Label();
            this.pnlTacGia = new System.Windows.Forms.Panel();
            this.lblCountTacGia = new System.Windows.Forms.Label();
            this.lblTextTacGia = new System.Windows.Forms.Label();
            this.pnlNXB = new System.Windows.Forms.Panel();
            this.lblCountNXB = new System.Windows.Forms.Label();
            this.lblTextNXB = new System.Windows.Forms.Label();

            this.grpThongKeDocGia = new System.Windows.Forms.GroupBox();
            this.pnlDocGia = new System.Windows.Forms.Panel();
            this.lblCountDocGia = new System.Windows.Forms.Label();
            this.lblTextDocGia = new System.Windows.Forms.Label();
            this.pnlSachMuon = new System.Windows.Forms.Panel();
            this.lblCountSachMuon = new System.Windows.Forms.Label();
            this.lblTextSachMuon = new System.Windows.Forms.Label();

            this.grpThongKeMuonQuaHan = new System.Windows.Forms.GroupBox();
            this.btnDangMuon = new System.Windows.Forms.Button();
            this.btnDaTra = new System.Windows.Forms.Button();
            this.btnDSQuaHan = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.lblTitleList = new System.Windows.Forms.Label();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();

            this.grpThongKeSach.SuspendLayout();
            this.pnlSach.SuspendLayout();
            this.pnlLoaiSach.SuspendLayout();
            this.pnlTacGia.SuspendLayout();
            this.pnlNXB.SuspendLayout();

            this.grpThongKeDocGia.SuspendLayout();
            this.pnlDocGia.SuspendLayout();
            this.pnlSachMuon.SuspendLayout();

            this.grpThongKeMuonQuaHan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();

            // 
            // grpThongKeSach
            // 
            this.grpThongKeSach.Controls.Add(this.pnlSach);
            this.grpThongKeSach.Controls.Add(this.pnlLoaiSach);
            this.grpThongKeSach.Controls.Add(this.pnlTacGia);
            this.grpThongKeSach.Controls.Add(this.pnlNXB);
            this.grpThongKeSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpThongKeSach.Location = new System.Drawing.Point(120, 20);
            this.grpThongKeSach.Name = "grpThongKeSach";
            this.grpThongKeSach.Size = new System.Drawing.Size(760, 150);
            this.grpThongKeSach.TabIndex = 0;
            this.grpThongKeSach.TabStop = false;
            this.grpThongKeSach.Text = "Thống Kê Sách";

            // pnlSach
            this.pnlSach.BackColor = System.Drawing.Color.FromArgb(142, 100, 235);
            this.pnlSach.Controls.Add(this.lblCountSach);
            this.pnlSach.Controls.Add(this.lblTextSach);
            this.pnlSach.Location = new System.Drawing.Point(50, 30);
            this.pnlSach.Name = "pnlSach";
            this.pnlSach.Size = new System.Drawing.Size(130, 100);
            this.pnlSach.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawBookIcon);

            this.lblCountSach.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountSach.ForeColor = System.Drawing.Color.White;
            this.lblCountSach.Location = new System.Drawing.Point(10, 15);
            this.lblCountSach.Size = new System.Drawing.Size(50, 35);
            this.lblCountSach.Text = "9";
            this.lblCountSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblTextSach.BackColor = System.Drawing.Color.FromArgb(120, 40, 220);
            this.lblTextSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTextSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextSach.ForeColor = System.Drawing.Color.Black;
            this.lblTextSach.Height = 30;
            this.lblTextSach.Text = "Sách";
            this.lblTextSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlLoaiSach
            this.pnlLoaiSach.BackColor = System.Drawing.Color.FromArgb(235, 140, 210);
            this.pnlLoaiSach.Controls.Add(this.lblCountLoaiSach);
            this.pnlLoaiSach.Controls.Add(this.lblTextLoaiSach);
            this.pnlLoaiSach.Location = new System.Drawing.Point(220, 30);
            this.pnlLoaiSach.Name = "pnlLoaiSach";
            this.pnlLoaiSach.Size = new System.Drawing.Size(130, 100);
            this.pnlLoaiSach.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawBulbIcon);

            this.lblCountLoaiSach.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountLoaiSach.ForeColor = System.Drawing.Color.White;
            this.lblCountLoaiSach.Location = new System.Drawing.Point(10, 15);
            this.lblCountLoaiSach.Size = new System.Drawing.Size(50, 35);
            this.lblCountLoaiSach.Text = "18";
            this.lblCountLoaiSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblTextLoaiSach.BackColor = System.Drawing.Color.FromArgb(230, 100, 190);
            this.lblTextLoaiSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTextLoaiSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextLoaiSach.ForeColor = System.Drawing.Color.Black;
            this.lblTextLoaiSach.Height = 30;
            this.lblTextLoaiSach.Text = "Loại Sách";
            this.lblTextLoaiSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlTacGia
            this.pnlTacGia.BackColor = System.Drawing.Color.FromArgb(150, 185, 210);
            this.pnlTacGia.Controls.Add(this.lblCountTacGia);
            this.pnlTacGia.Controls.Add(this.lblTextTacGia);
            this.pnlTacGia.Location = new System.Drawing.Point(390, 30);
            this.pnlTacGia.Name = "pnlTacGia";
            this.pnlTacGia.Size = new System.Drawing.Size(130, 100);
            this.pnlTacGia.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawUserCardIcon);

            this.lblCountTacGia.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountTacGia.ForeColor = System.Drawing.Color.White;
            this.lblCountTacGia.Location = new System.Drawing.Point(10, 15);
            this.lblCountTacGia.Size = new System.Drawing.Size(50, 35);
            this.lblCountTacGia.Text = "12";
            this.lblCountTacGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblTextTacGia.BackColor = System.Drawing.Color.FromArgb(120, 175, 180);
            this.lblTextTacGia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTextTacGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextTacGia.ForeColor = System.Drawing.Color.Black;
            this.lblTextTacGia.Height = 30;
            this.lblTextTacGia.Text = "Tác Giả";
            this.lblTextTacGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlNXB
            this.pnlNXB.BackColor = System.Drawing.Color.FromArgb(100, 110, 235);
            this.pnlNXB.Controls.Add(this.lblCountNXB);
            this.pnlNXB.Controls.Add(this.lblTextNXB);
            this.pnlNXB.Location = new System.Drawing.Point(560, 30);
            this.pnlNXB.Name = "pnlNXB";
            this.pnlNXB.Size = new System.Drawing.Size(130, 100);
            this.pnlNXB.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawGreenBookIcon);

            this.lblCountNXB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountNXB.ForeColor = System.Drawing.Color.White;
            this.lblCountNXB.Location = new System.Drawing.Point(10, 15);
            this.lblCountNXB.Size = new System.Drawing.Size(50, 35);
            this.lblCountNXB.Text = "13";
            this.lblCountNXB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblTextNXB.BackColor = System.Drawing.Color.FromArgb(70, 80, 200);
            this.lblTextNXB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTextNXB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextNXB.ForeColor = System.Drawing.Color.Black;
            this.lblTextNXB.Height = 30;
            this.lblTextNXB.Text = "Nhà Xuất Bản";
            this.lblTextNXB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // grpThongKeDocGia
            // 
            this.grpThongKeDocGia.Controls.Add(this.pnlDocGia);
            this.grpThongKeDocGia.Controls.Add(this.pnlSachMuon);
            this.grpThongKeDocGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpThongKeDocGia.Location = new System.Drawing.Point(290, 185);
            this.grpThongKeDocGia.Name = "grpThongKeDocGia";
            this.grpThongKeDocGia.Size = new System.Drawing.Size(420, 140);
            this.grpThongKeDocGia.TabIndex = 1;
            this.grpThongKeDocGia.TabStop = false;
            this.grpThongKeDocGia.Text = "Thống Kê Độc Giả - Số Sách Mượn";

            // pnlDocGia
            this.pnlDocGia.BackColor = System.Drawing.Color.FromArgb(245, 130, 95);
            this.pnlDocGia.Controls.Add(this.lblCountDocGia);
            this.pnlDocGia.Controls.Add(this.lblTextDocGia);
            this.pnlDocGia.Location = new System.Drawing.Point(60, 25);
            this.pnlDocGia.Name = "pnlDocGia";
            this.pnlDocGia.Size = new System.Drawing.Size(130, 100);
            this.pnlDocGia.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawGroupUsersIcon);

            this.lblCountDocGia.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountDocGia.ForeColor = System.Drawing.Color.White;
            this.lblCountDocGia.Location = new System.Drawing.Point(10, 15);
            this.lblCountDocGia.Size = new System.Drawing.Size(50, 35);
            this.lblCountDocGia.Text = "9";
            this.lblCountDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblTextDocGia.BackColor = System.Drawing.Color.FromArgb(235, 90, 60);
            this.lblTextDocGia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTextDocGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextDocGia.ForeColor = System.Drawing.Color.Black;
            this.lblTextDocGia.Height = 30;
            this.lblTextDocGia.Text = "Độc Giả";
            this.lblTextDocGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // pnlSachMuon
            this.pnlSachMuon.BackColor = System.Drawing.Color.FromArgb(160, 215, 230);
            this.pnlSachMuon.Controls.Add(this.lblCountSachMuon);
            this.pnlSachMuon.Controls.Add(this.lblTextSachMuon);
            this.pnlSachMuon.Location = new System.Drawing.Point(230, 25);
            this.pnlSachMuon.Name = "pnlSachMuon";
            this.pnlSachMuon.Size = new System.Drawing.Size(130, 100);
            this.pnlSachMuon.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawAppleBooksIcon);

            this.lblCountSachMuon.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCountSachMuon.ForeColor = System.Drawing.Color.White;
            this.lblCountSachMuon.Location = new System.Drawing.Point(10, 15);
            this.lblCountSachMuon.Size = new System.Drawing.Size(50, 35);
            this.lblCountSachMuon.Text = "11";
            this.lblCountSachMuon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblTextSachMuon.BackColor = System.Drawing.Color.FromArgb(90, 185, 220);
            this.lblTextSachMuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTextSachMuon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTextSachMuon.ForeColor = System.Drawing.Color.Black;
            this.lblTextSachMuon.Height = 30;
            this.lblTextSachMuon.Text = "Sách Mượn";
            this.lblTextSachMuon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // grpThongKeMuonQuaHan
            // 
            this.grpThongKeMuonQuaHan.Controls.Add(this.btnDangMuon);
            this.grpThongKeMuonQuaHan.Controls.Add(this.btnDaTra);
            this.grpThongKeMuonQuaHan.Controls.Add(this.btnDSQuaHan);
            this.grpThongKeMuonQuaHan.Controls.Add(this.btnXuatExcel);
            this.grpThongKeMuonQuaHan.Controls.Add(this.lblTitleList);
            this.grpThongKeMuonQuaHan.Controls.Add(this.lblTongSo);
            this.grpThongKeMuonQuaHan.Controls.Add(this.dgvData);
            this.grpThongKeMuonQuaHan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpThongKeMuonQuaHan.Location = new System.Drawing.Point(40, 335);
            this.grpThongKeMuonQuaHan.Name = "grpThongKeMuonQuaHan";
            this.grpThongKeMuonQuaHan.Size = new System.Drawing.Size(920, 300);
            this.grpThongKeMuonQuaHan.TabIndex = 2;
            this.grpThongKeMuonQuaHan.TabStop = false;
            this.grpThongKeMuonQuaHan.Text = "Thống Kê Sinh Viên Đang Mượn Sách và Quá Hạn";
            this.grpThongKeMuonQuaHan.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // btnDangMuon
            this.btnDangMuon.BackColor = System.Drawing.Color.FromArgb(38, 138, 88);
            this.btnDangMuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangMuon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDangMuon.ForeColor = System.Drawing.Color.White;
            this.btnDangMuon.Location = new System.Drawing.Point(320, 25);
            this.btnDangMuon.Name = "btnDangMuon";
            this.btnDangMuon.Size = new System.Drawing.Size(130, 45);
            this.btnDangMuon.TabIndex = 0;
            this.btnDangMuon.Text = "Đang Mượn";
            this.btnDangMuon.Click += new System.EventHandler(this.btnDangMuon_Click);
            this.btnDangMuon.UseVisualStyleBackColor = false;

            // 
            // btnDaTra
            // 
            this.btnDaTra.BackColor = System.Drawing.Color.FromArgb(108, 117, 137);
            this.btnDaTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaTra.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDaTra.ForeColor = System.Drawing.Color.White;
            this.btnDaTra.Location = new System.Drawing.Point(400, 25);
            this.btnDaTra.Name = "btnDaTra";
            this.btnDaTra.Size = new System.Drawing.Size(120, 45);
            this.btnDaTra.TabIndex = 1;
            this.btnDaTra.Text = "Đã Trả";
            this.btnDaTra.Click += new System.EventHandler(this.btnDaTra_Click);
            this.btnDaTra.UseVisualStyleBackColor = false;

            // btnDSQuaHan
            this.btnDSQuaHan.BackColor = System.Drawing.Color.FromArgb(108, 117, 137);
            this.btnDSQuaHan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSQuaHan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDSQuaHan.ForeColor = System.Drawing.Color.White;
            this.btnDSQuaHan.Location = new System.Drawing.Point(480, 25);
            this.btnDSQuaHan.Name = "btnDSQuaHan";
            this.btnDSQuaHan.Size = new System.Drawing.Size(130, 45);
            this.btnDSQuaHan.TabIndex = 1;
            this.btnDSQuaHan.Text = "DS Quá Hạn";
            this.btnDSQuaHan.Click += new System.EventHandler(this.btnDSQuaHan_Click);
            this.btnDSQuaHan.UseVisualStyleBackColor = false;

            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatExcel.BackColor = System.Drawing.Color.FromArgb(16, 124, 65);
            this.btnXuatExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatExcel.FlatAppearance.BorderSize = 0;
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(755, 25);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnXuatExcel.Size = new System.Drawing.Size(135, 45);
            this.btnXuatExcel.TabIndex = 2;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            this.btnXuatExcel.Paint += new System.Windows.Forms.PaintEventHandler(this.btnXuatExcel_Paint);

            // lblTitleList
            this.lblTitleList.AutoSize = true;
            this.lblTitleList.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleList.Location = new System.Drawing.Point(350, 85);
            this.lblTitleList.Name = "lblTitleList";
            this.lblTitleList.Size = new System.Drawing.Size(150, 20);
            this.lblTitleList.Text = "Danh sách đang mượn";

            // lblTongSo
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTongSo.ForeColor = System.Drawing.Color.Red;
            this.lblTongSo.Location = new System.Drawing.Point(630, 85);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(110, 20);
            this.lblTongSo.Text = "Tổng:    7    Sách";

            // dgvData
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvHeaderStyle.BackColor = System.Drawing.Color.FromArgb(88, 101, 242);
            dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dgvHeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvData.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.Location = new System.Drawing.Point(40, 115);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersVisible = false;
            dgvAltRowStyle.BackColor = System.Drawing.Color.FromArgb(235, 238, 255);
            this.dgvData.RowsDefaultCellStyle = dgvAltRowStyle;
            this.dgvData.Size = new System.Drawing.Size(840, 160);
            this.dgvData.TabIndex = 2;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvData.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // BaocaothongkeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.grpThongKeSach);
            this.Controls.Add(this.grpThongKeDocGia);
            this.Controls.Add(this.grpThongKeMuonQuaHan);
            this.Name = "BaocaothongkeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Thống Kê";
            this.Load += new System.EventHandler(this.BaocaothongkeView_Load);
            this.Resize += new System.EventHandler(this.BaocaothongkeView_Resize);

            this.grpThongKeSach.ResumeLayout(false);
            this.pnlSach.ResumeLayout(false);
            this.pnlLoaiSach.ResumeLayout(false);
            this.pnlTacGia.ResumeLayout(false);
            this.pnlNXB.ResumeLayout(false);

            this.grpThongKeDocGia.ResumeLayout(false);
            this.pnlDocGia.ResumeLayout(false);
            this.pnlSachMuon.ResumeLayout(false);

            this.grpThongKeMuonQuaHan.ResumeLayout(false);
            this.grpThongKeMuonQuaHan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        #region Custom Icon Paint Events

        private void DrawBookIcon(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush bRed = new SolidBrush(Color.Red);
            Brush bBlue = new SolidBrush(Color.Blue);
            Brush bGreen = new SolidBrush(Color.Green);

            g.FillRectangle(bRed, 65, 12, 10, 32);
            g.FillRectangle(bBlue, 77, 12, 10, 32);
            g.FillRectangle(bGreen, 89, 12, 10, 32);

            bRed.Dispose(); bBlue.Dispose(); bGreen.Dispose();
        }

        private void DrawBulbIcon(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (Brush bBook = new SolidBrush(Color.Purple))
            using (Brush bBulb = new SolidBrush(Color.Yellow))
            {
                g.FillRectangle(bBook, 65, 18, 40, 24);
                g.FillEllipse(bBulb, 77, 8, 16, 16);
            }
        }

        private void DrawUserCardIcon(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (Brush bCard = new SolidBrush(Color.Salmon))
            using (Brush bHead = new SolidBrush(Color.White))
            {
                g.FillRectangle(bCard, 65, 10, 35, 36);
                g.FillEllipse(bHead, 75, 16, 15, 15);
            }
        }

        private void DrawGreenBookIcon(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (Brush bBook = new SolidBrush(Color.MediumSeaGreen))
            {
                g.FillRectangle(bBook, 70, 12, 30, 34);
            }
        }

        private void DrawGroupUsersIcon(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (Brush bScreen = new SolidBrush(Color.RoyalBlue))
            using (Brush bUser = new SolidBrush(Color.Yellow))
            {
                g.FillRectangle(bScreen, 65, 10, 42, 32);
                g.FillEllipse(bUser, 73, 16, 8, 8);
                g.FillEllipse(bUser, 82, 16, 8, 8);
                g.FillEllipse(bUser, 91, 16, 8, 8);
            }
        }

        private void DrawAppleBooksIcon(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using (Brush bBook = new SolidBrush(Color.DarkGreen))
            using (Brush bApple = new SolidBrush(Color.Red))
            {
                g.FillRectangle(bBook, 65, 20, 42, 22);
                g.FillEllipse(bApple, 80, 8, 12, 12);
            }
        }

        #endregion
    }
}