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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaocaothongkeView));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            grpThongKeSach = new GroupBox();
            pnlSach = new Panel();
            pictureBox1 = new PictureBox();
            lblCountSach = new Label();
            lblTextSach = new Label();
            pnlLoaiSach = new Panel();
            pictureBox2 = new PictureBox();
            lblCountLoaiSach = new Label();
            lblTextLoaiSach = new Label();
            pnlTacGia = new Panel();
            pictureBox3 = new PictureBox();
            lblCountTacGia = new Label();
            lblTextTacGia = new Label();
            pnlNXB = new Panel();
            pictureBox4 = new PictureBox();
            lblCountNXB = new Label();
            lblTextNXB = new Label();
            grpThongKeDocGia = new GroupBox();
            pnlDocGia = new Panel();
            pictureBox5 = new PictureBox();
            lblCountDocGia = new Label();
            lblTextDocGia = new Label();
            pnlSachMuon = new Panel();
            pictureBox6 = new PictureBox();
            lblCountSachMuon = new Label();
            lblTextSachMuon = new Label();
            grpThongKeMuonQuaHan = new GroupBox();
            btnDangMuon = new Button();
            btnDaTra = new Button();
            btnDSQuaHan = new Button();
            btnXuatExcel = new Button();
            lblTitleList = new Label();
            lblTongSo = new Label();
            dgvData = new DataGridView();
            grpThongKeSach.SuspendLayout();
            pnlSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlLoaiSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlTacGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlNXB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            grpThongKeDocGia.SuspendLayout();
            pnlDocGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            pnlSachMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            grpThongKeMuonQuaHan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // grpThongKeSach
            // 
            grpThongKeSach.Controls.Add(pnlSach);
            grpThongKeSach.Controls.Add(pnlLoaiSach);
            grpThongKeSach.Controls.Add(pnlTacGia);
            grpThongKeSach.Controls.Add(pnlNXB);
            grpThongKeSach.Font = new Font("Segoe UI", 10F);
            grpThongKeSach.Location = new Point(120, 20);
            grpThongKeSach.Name = "grpThongKeSach";
            grpThongKeSach.Size = new Size(760, 150);
            grpThongKeSach.TabIndex = 0;
            grpThongKeSach.TabStop = false;
            grpThongKeSach.Text = "Thống Kê Sách";
            // 
            // pnlSach
            // 
            pnlSach.BackColor = Color.FromArgb(142, 100, 235);
            pnlSach.Controls.Add(pictureBox1);
            pnlSach.Controls.Add(lblCountSach);
            pnlSach.Controls.Add(lblTextSach);
            pnlSach.Location = new Point(50, 30);
            pnlSach.Name = "pnlSach";
            pnlSach.Size = new Size(130, 100);
            pnlSach.TabIndex = 0;
            pnlSach.Paint += DrawBookIcon;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(66, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblCountSach
            // 
            lblCountSach.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCountSach.ForeColor = Color.White;
            lblCountSach.Location = new Point(10, 15);
            lblCountSach.Name = "lblCountSach";
            lblCountSach.Size = new Size(50, 35);
            lblCountSach.TabIndex = 0;
            lblCountSach.Text = "0";
            lblCountSach.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTextSach
            // 
            lblTextSach.BackColor = Color.FromArgb(120, 40, 220);
            lblTextSach.Dock = DockStyle.Bottom;
            lblTextSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTextSach.ForeColor = Color.White;
            lblTextSach.Location = new Point(0, 70);
            lblTextSach.Name = "lblTextSach";
            lblTextSach.Size = new Size(130, 30);
            lblTextSach.TabIndex = 1;
            lblTextSach.Text = "Sách";
            lblTextSach.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLoaiSach
            // 
            pnlLoaiSach.BackColor = Color.FromArgb(235, 140, 210);
            pnlLoaiSach.Controls.Add(pictureBox2);
            pnlLoaiSach.Controls.Add(lblCountLoaiSach);
            pnlLoaiSach.Controls.Add(lblTextLoaiSach);
            pnlLoaiSach.Location = new Point(220, 30);
            pnlLoaiSach.Name = "pnlLoaiSach";
            pnlLoaiSach.Size = new Size(130, 100);
            pnlLoaiSach.TabIndex = 1;
            pnlLoaiSach.Paint += DrawBulbIcon;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(76, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // lblCountLoaiSach
            // 
            lblCountLoaiSach.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCountLoaiSach.ForeColor = Color.White;
            lblCountLoaiSach.Location = new Point(10, 15);
            lblCountLoaiSach.Name = "lblCountLoaiSach";
            lblCountLoaiSach.Size = new Size(50, 35);
            lblCountLoaiSach.TabIndex = 0;
            lblCountLoaiSach.Text = "0";
            lblCountLoaiSach.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTextLoaiSach
            // 
            lblTextLoaiSach.BackColor = Color.FromArgb(230, 100, 190);
            lblTextLoaiSach.Dock = DockStyle.Bottom;
            lblTextLoaiSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTextLoaiSach.ForeColor = Color.White;
            lblTextLoaiSach.Location = new Point(0, 70);
            lblTextLoaiSach.Name = "lblTextLoaiSach";
            lblTextLoaiSach.Size = new Size(130, 30);
            lblTextLoaiSach.TabIndex = 1;
            lblTextLoaiSach.Text = "Loại Sách";
            lblTextLoaiSach.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTacGia
            // 
            pnlTacGia.BackColor = Color.FromArgb(150, 185, 210);
            pnlTacGia.Controls.Add(pictureBox3);
            pnlTacGia.Controls.Add(lblCountTacGia);
            pnlTacGia.Controls.Add(lblTextTacGia);
            pnlTacGia.Location = new Point(390, 30);
            pnlTacGia.Name = "pnlTacGia";
            pnlTacGia.Size = new Size(130, 100);
            pnlTacGia.TabIndex = 2;
            pnlTacGia.Paint += DrawUserCardIcon;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(70, 15);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // lblCountTacGia
            // 
            lblCountTacGia.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCountTacGia.ForeColor = Color.White;
            lblCountTacGia.Location = new Point(10, 15);
            lblCountTacGia.Name = "lblCountTacGia";
            lblCountTacGia.Size = new Size(50, 35);
            lblCountTacGia.TabIndex = 0;
            lblCountTacGia.Text = "0";
            lblCountTacGia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTextTacGia
            // 
            lblTextTacGia.BackColor = Color.FromArgb(120, 175, 180);
            lblTextTacGia.Dock = DockStyle.Bottom;
            lblTextTacGia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTextTacGia.ForeColor = Color.White;
            lblTextTacGia.Location = new Point(0, 70);
            lblTextTacGia.Name = "lblTextTacGia";
            lblTextTacGia.Size = new Size(130, 30);
            lblTextTacGia.TabIndex = 1;
            lblTextTacGia.Text = "Tác Giả";
            lblTextTacGia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlNXB
            // 
            pnlNXB.BackColor = Color.FromArgb(100, 110, 235);
            pnlNXB.Controls.Add(pictureBox4);
            pnlNXB.Controls.Add(lblCountNXB);
            pnlNXB.Controls.Add(lblTextNXB);
            pnlNXB.Location = new Point(560, 30);
            pnlNXB.Name = "pnlNXB";
            pnlNXB.Size = new Size(130, 100);
            pnlNXB.TabIndex = 3;
            pnlNXB.Paint += DrawGreenBookIcon;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(66, 15);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(51, 52);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // lblCountNXB
            // 
            lblCountNXB.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCountNXB.ForeColor = Color.White;
            lblCountNXB.Location = new Point(10, 15);
            lblCountNXB.Name = "lblCountNXB";
            lblCountNXB.Size = new Size(50, 35);
            lblCountNXB.TabIndex = 0;
            lblCountNXB.Text = "0";
            lblCountNXB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTextNXB
            // 
            lblTextNXB.BackColor = Color.FromArgb(70, 80, 200);
            lblTextNXB.Dock = DockStyle.Bottom;
            lblTextNXB.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTextNXB.ForeColor = Color.White;
            lblTextNXB.Location = new Point(0, 70);
            lblTextNXB.Name = "lblTextNXB";
            lblTextNXB.Size = new Size(130, 30);
            lblTextNXB.TabIndex = 1;
            lblTextNXB.Text = "Nhà Xuất Bản";
            lblTextNXB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpThongKeDocGia
            // 
            grpThongKeDocGia.Controls.Add(pnlDocGia);
            grpThongKeDocGia.Controls.Add(pnlSachMuon);
            grpThongKeDocGia.Font = new Font("Segoe UI", 10F);
            grpThongKeDocGia.Location = new Point(290, 185);
            grpThongKeDocGia.Name = "grpThongKeDocGia";
            grpThongKeDocGia.Size = new Size(420, 140);
            grpThongKeDocGia.TabIndex = 1;
            grpThongKeDocGia.TabStop = false;
            grpThongKeDocGia.Text = "Thống Kê Độc Giả - Số Sách Mượn";
            // 
            // pnlDocGia
            // 
            pnlDocGia.BackColor = Color.FromArgb(245, 130, 95);
            pnlDocGia.Controls.Add(pictureBox5);
            pnlDocGia.Controls.Add(lblCountDocGia);
            pnlDocGia.Controls.Add(lblTextDocGia);
            pnlDocGia.Location = new Point(60, 25);
            pnlDocGia.Name = "pnlDocGia";
            pnlDocGia.Size = new Size(130, 100);
            pnlDocGia.TabIndex = 0;
            pnlDocGia.Paint += DrawGroupUsersIcon;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(66, 15);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(51, 52);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // lblCountDocGia
            // 
            lblCountDocGia.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCountDocGia.ForeColor = Color.White;
            lblCountDocGia.Location = new Point(10, 15);
            lblCountDocGia.Name = "lblCountDocGia";
            lblCountDocGia.Size = new Size(50, 35);
            lblCountDocGia.TabIndex = 0;
            lblCountDocGia.Text = "0";
            lblCountDocGia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTextDocGia
            // 
            lblTextDocGia.BackColor = Color.FromArgb(235, 90, 60);
            lblTextDocGia.Dock = DockStyle.Bottom;
            lblTextDocGia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTextDocGia.ForeColor = Color.White;
            lblTextDocGia.Location = new Point(0, 70);
            lblTextDocGia.Name = "lblTextDocGia";
            lblTextDocGia.Size = new Size(130, 30);
            lblTextDocGia.TabIndex = 1;
            lblTextDocGia.Text = "Độc Giả";
            lblTextDocGia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlSachMuon
            // 
            pnlSachMuon.BackColor = Color.FromArgb(160, 215, 230);
            pnlSachMuon.Controls.Add(pictureBox6);
            pnlSachMuon.Controls.Add(lblCountSachMuon);
            pnlSachMuon.Controls.Add(lblTextSachMuon);
            pnlSachMuon.Location = new Point(230, 25);
            pnlSachMuon.Name = "pnlSachMuon";
            pnlSachMuon.Size = new Size(130, 100);
            pnlSachMuon.TabIndex = 1;
            pnlSachMuon.Paint += DrawAppleBooksIcon;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(69, 15);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(51, 52);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 4;
            pictureBox6.TabStop = false;
            // 
            // lblCountSachMuon
            // 
            lblCountSachMuon.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCountSachMuon.ForeColor = Color.White;
            lblCountSachMuon.Location = new Point(10, 15);
            lblCountSachMuon.Name = "lblCountSachMuon";
            lblCountSachMuon.Size = new Size(50, 35);
            lblCountSachMuon.TabIndex = 0;
            lblCountSachMuon.Text = "0";
            lblCountSachMuon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTextSachMuon
            // 
            lblTextSachMuon.BackColor = Color.FromArgb(90, 185, 220);
            lblTextSachMuon.Dock = DockStyle.Bottom;
            lblTextSachMuon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTextSachMuon.ForeColor = Color.White;
            lblTextSachMuon.Location = new Point(0, 70);
            lblTextSachMuon.Name = "lblTextSachMuon";
            lblTextSachMuon.Size = new Size(130, 30);
            lblTextSachMuon.TabIndex = 1;
            lblTextSachMuon.Text = "Sách Mượn";
            lblTextSachMuon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpThongKeMuonQuaHan
            // 
            grpThongKeMuonQuaHan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpThongKeMuonQuaHan.Controls.Add(btnDangMuon);
            grpThongKeMuonQuaHan.Controls.Add(btnDaTra);
            grpThongKeMuonQuaHan.Controls.Add(btnDSQuaHan);
            grpThongKeMuonQuaHan.Controls.Add(btnXuatExcel);
            grpThongKeMuonQuaHan.Controls.Add(lblTitleList);
            grpThongKeMuonQuaHan.Controls.Add(lblTongSo);
            grpThongKeMuonQuaHan.Controls.Add(dgvData);
            grpThongKeMuonQuaHan.Font = new Font("Segoe UI", 10F);
            grpThongKeMuonQuaHan.Location = new Point(40, 335);
            grpThongKeMuonQuaHan.Name = "grpThongKeMuonQuaHan";
            grpThongKeMuonQuaHan.Size = new Size(920, 411);
            grpThongKeMuonQuaHan.TabIndex = 2;
            grpThongKeMuonQuaHan.TabStop = false;
            grpThongKeMuonQuaHan.Text = "Thống Kê Sinh Viên Đang Mượn Sách và Quá Hạn";
            // 
            // btnDangMuon
            // 
            btnDangMuon.BackColor = Color.FromArgb(53, 162, 184);
            btnDangMuon.FlatStyle = FlatStyle.Flat;
            btnDangMuon.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDangMuon.ForeColor = Color.White;
            btnDangMuon.Location = new Point(217, 24);
            btnDangMuon.Name = "btnDangMuon";
            btnDangMuon.Size = new Size(130, 45);
            btnDangMuon.TabIndex = 0;
            btnDangMuon.Text = "Đang Mượn";
            btnDangMuon.UseVisualStyleBackColor = false;
            btnDangMuon.Click += btnDangMuon_Click;
            // 
            // btnDaTra
            // 
            btnDaTra.BackColor = Color.Green;
            btnDaTra.FlatStyle = FlatStyle.Flat;
            btnDaTra.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDaTra.ForeColor = Color.White;
            btnDaTra.Location = new Point(378, 25);
            btnDaTra.Name = "btnDaTra";
            btnDaTra.Size = new Size(120, 45);
            btnDaTra.TabIndex = 1;
            btnDaTra.Text = "Đã Trả";
            btnDaTra.UseVisualStyleBackColor = false;
            btnDaTra.Click += btnDaTra_Click;
            // 
            // btnDSQuaHan
            // 
            btnDSQuaHan.BackColor = Color.FromArgb(192, 0, 0);
            btnDSQuaHan.FlatStyle = FlatStyle.Flat;
            btnDSQuaHan.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDSQuaHan.ForeColor = Color.White;
            btnDSQuaHan.Location = new Point(540, 25);
            btnDSQuaHan.Name = "btnDSQuaHan";
            btnDSQuaHan.Size = new Size(130, 45);
            btnDSQuaHan.TabIndex = 1;
            btnDSQuaHan.Text = "DS Quá Hạn";
            btnDSQuaHan.UseVisualStyleBackColor = false;
            btnDSQuaHan.Click += btnDSQuaHan_Click;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXuatExcel.BackColor = Color.FromArgb(192, 192, 0);
            btnXuatExcel.Cursor = Cursors.Hand;
            btnXuatExcel.FlatAppearance.BorderSize = 0;
            btnXuatExcel.FlatStyle = FlatStyle.Flat;
            btnXuatExcel.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnXuatExcel.ForeColor = Color.White;
            btnXuatExcel.Location = new Point(755, 25);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Padding = new Padding(26, 0, 0, 0);
            btnXuatExcel.Size = new Size(135, 45);
            btnXuatExcel.TabIndex = 2;
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.TextAlign = ContentAlignment.MiddleLeft;
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += btnXuatExcel_Click;
            btnXuatExcel.Paint += btnXuatExcel_Paint;
            // 
            // lblTitleList
            // 
            lblTitleList.AutoSize = true;
            lblTitleList.Font = new Font("Segoe UI", 10.5F);
            lblTitleList.Location = new Point(42, 85);
            lblTitleList.Name = "lblTitleList";
            lblTitleList.Size = new Size(148, 19);
            lblTitleList.TabIndex = 3;
            lblTitleList.Text = "Danh sách đang mượn";
            // 
            // lblTongSo
            // 
            lblTongSo.AutoSize = true;
            lblTongSo.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblTongSo.ForeColor = Color.Red;
            lblTongSo.Location = new Point(755, 85);
            lblTongSo.Name = "lblTongSo";
            lblTongSo.Size = new Size(118, 19);
            lblTongSo.TabIndex = 4;
            lblTongSo.Text = "Tổng:    7    Sách";
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.ReadOnly = true;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.MultiSelect = false;
            dgvData.AllowUserToResizeRows = false;
            dgvData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.BackgroundColor = Color.White;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(88, 101, 242);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.EnableHeadersVisualStyles = false;
            dgvData.Location = new Point(40, 115);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 238, 255);
            dgvData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvData.Size = new Size(840, 271);
            dgvData.TabIndex = 2;
            // 
            // BaocaothongkeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 761);
            Controls.Add(grpThongKeSach);
            Controls.Add(grpThongKeDocGia);
            Controls.Add(grpThongKeMuonQuaHan);
            Name = "BaocaothongkeView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo Cáo Thống Kê";
            Load += BaocaothongkeView_Load;
            Resize += BaocaothongkeView_Resize;
            grpThongKeSach.ResumeLayout(false);
            pnlSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlLoaiSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlTacGia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlNXB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            grpThongKeDocGia.ResumeLayout(false);
            pnlDocGia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            pnlSachMuon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            grpThongKeMuonQuaHan.ResumeLayout(false);
            grpThongKeMuonQuaHan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
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

        #region Giao diện đồ họa, Căn chỉnh Layout & Định dạng DataGridView

        public void CanChinhGiaoDien()
        {
            grpThongKeSach.Left = Math.Max(10, (this.ClientSize.Width - grpThongKeSach.Width) / 2);
            grpThongKeDocGia.Left = Math.Max(10, (this.ClientSize.Width - grpThongKeDocGia.Width) / 2);

            int mid = grpThongKeMuonQuaHan.ClientSize.Width / 2;
            btnDangMuon.Left = mid - 195;
            btnDaTra.Left = mid - 60;
            btnDSQuaHan.Left = mid + 75;

            lblTitleList.Left = Math.Max(40, mid - 190);
            lblTongSo.Left = mid + 50;

            if (btnXuatExcel != null)
            {
                btnXuatExcel.Left = grpThongKeMuonQuaHan.ClientSize.Width - btnXuatExcel.Width - 25;
            }
        }

        public void CapNhatGiaoDienNut(CheDoXem cheDo)
        {
            _currentCheDo = cheDo;
            Color colorInactive = Color.FromArgb(108, 117, 137);

            btnDangMuon.BackColor = (cheDo == CheDoXem.DangMuon) ? Color.FromArgb(38, 138, 88) : colorInactive;
            btnDaTra.BackColor = (cheDo == CheDoXem.DaTra) ? Color.FromArgb(40, 110, 180) : colorInactive;
            btnDSQuaHan.BackColor = (cheDo == CheDoXem.QuaHan) ? Color.FromArgb(220, 53, 69) : colorInactive;

            btnDangMuon.ForeColor = Color.White;
            btnDaTra.ForeColor = Color.White;
            btnDSQuaHan.ForeColor = Color.White;

            switch (cheDo)
            {
                case CheDoXem.DangMuon:
                    lblTitleList.Text = "Danh sách sách đang mượn";
                    lblTitleList.ForeColor = Color.FromArgb(40, 40, 40);
                    lblTongSo.ForeColor = Color.FromArgb(38, 138, 88);
                    break;
                case CheDoXem.DaTra:
                    lblTitleList.Text = "Danh sách sách đã trả";
                    lblTitleList.ForeColor = Color.FromArgb(40, 40, 40);
                    lblTongSo.ForeColor = Color.FromArgb(40, 110, 180);
                    break;
                case CheDoXem.QuaHan:
                    lblTitleList.Text = "Danh sách sách mượn quá hạn";
                    lblTitleList.ForeColor = Color.FromArgb(180, 40, 40);
                    lblTongSo.ForeColor = Color.FromArgb(220, 53, 69);
                    break;
            }
        }

        public void DinhDangCot(CheDoXem cheDo)
        {
            if (dgvData.Columns["SoLuong"] is DataGridViewColumn colSL) colSL.Visible = false;
            if (dgvData.Columns["SoLanGiaHan"] is DataGridViewColumn colGH) colGH.Visible = false;

            if (dgvData.Columns["MaPM"] is DataGridViewColumn cMaPM)
            {
                cMaPM.HeaderText = "Mã PM";
                cMaPM.FillWeight = 45;
                cMaPM.DisplayIndex = 0;
            }
            if (dgvData.Columns["MaSV"] is DataGridViewColumn cMaSV)
            {
                cMaSV.HeaderText = "Mã SV";
                cMaSV.FillWeight = 50;
                cMaSV.DisplayIndex = 1;
            }
            if (dgvData.Columns["TenDocGia"] is DataGridViewColumn cTenSV)
            {
                cTenSV.HeaderText = "Tên Độc Giả";
                cTenSV.FillWeight = 110;
                cTenSV.DisplayIndex = 2;
            }
            if (dgvData.Columns["MaSach"] is DataGridViewColumn cMaSach)
            {
                cMaSach.HeaderText = "Mã Sách";
                cMaSach.FillWeight = 50;
                cMaSach.DisplayIndex = 3;
            }
            if (dgvData.Columns["TenSach"] is DataGridViewColumn cTenSach)
            {
                cTenSach.HeaderText = "Tên Sách";
                cTenSach.FillWeight = 125;
                cTenSach.DisplayIndex = 4;
            }
            if (dgvData.Columns["NgayMuon"] is DataGridViewColumn cNgayMuon)
            {
                cNgayMuon.HeaderText = "Ngày Mượn";
                cNgayMuon.DefaultCellStyle.Format = "dd/MM/yyyy";
                cNgayMuon.FillWeight = 70;
                cNgayMuon.DisplayIndex = 5;
            }
            if (dgvData.Columns["HanTra"] is DataGridViewColumn cHanTra)
            {
                cHanTra.HeaderText = "Hạn Trả";
                cHanTra.DefaultCellStyle.Format = "dd/MM/yyyy";
                cHanTra.FillWeight = 70;
                cHanTra.DisplayIndex = 6;
            }
            if (dgvData.Columns["NgayTra"] is DataGridViewColumn cNgayTra)
            {
                cNgayTra.HeaderText = "Ngày Trả";
                cNgayTra.DefaultCellStyle.Format = "dd/MM/yyyy";
                cNgayTra.FillWeight = 70;
                cNgayTra.Visible = true;
                cNgayTra.DisplayIndex = 7;
            }
            if (dgvData.Columns["TinhTrangSach"] is DataGridViewColumn cTinhTrang)
            {
                cTinhTrang.HeaderText = "Tình Trạng";
                cTinhTrang.FillWeight = 75;
                cTinhTrang.DisplayIndex = 8;
            }
            if (dgvData.Columns["TrangThai"] is DataGridViewColumn cTrangThai)
            {
                cTrangThai.HeaderText = "Trạng Thái";
                cTrangThai.FillWeight = 75;
                cTrangThai.DisplayIndex = 9;
            }
            if (dgvData.Columns["GhiChu"] is DataGridViewColumn cGhiChu)
            {
                cGhiChu.HeaderText = "Ghi Chú";
                cGhiChu.FillWeight = 130;
                cGhiChu.Visible = true;
                cGhiChu.DisplayIndex = 10;
            }
            if (dgvData.Columns["SoNgayQuaHan"] is DataGridViewColumn cSoNgayQuaHan)
            {
                bool isQuaHan = (cheDo == CheDoXem.QuaHan);
                cSoNgayQuaHan.Visible = isQuaHan;
                if (isQuaHan)
                {
                    cSoNgayQuaHan.HeaderText = "Trễ Hạn (Ngày)";
                    cSoNgayQuaHan.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    cSoNgayQuaHan.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                    cSoNgayQuaHan.DefaultCellStyle.ForeColor = Color.FromArgb(220, 53, 69);
                    cSoNgayQuaHan.FillWeight = 70;
                    cSoNgayQuaHan.DisplayIndex = 11;
                }
            }

            if (cheDo == CheDoXem.QuaHan)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(180, 30, 30);
                    row.DefaultCellStyle.SelectionForeColor = Color.Yellow;
                }
            }
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}