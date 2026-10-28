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
            dgvNhanVien = new DataGridView();
            groupBox1 = new GroupBox();
            txtEmail = new TextBox();
            label8 = new Label();
            btnXoa = new Button();
            btnDoiMK = new Button();
            btnDangKy = new Button();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            txtMK = new TextBox();
            txtTenLogIn = new TextBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtHoTen = new TextBox();
            label7 = new Label();
            label1 = new Label();
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
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(265, 575);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.Size = new Size(954, 180);
            dgvNhanVien.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnDoiMK);
            groupBox1.Controls.Add(btnDangKy);
            groupBox1.Controls.Add(rdoNu);
            groupBox1.Controls.Add(rdoNam);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txtMK);
            groupBox1.Controls.Add(txtTenLogIn);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(265, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(954, 434);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đăng Ký";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(373, 171);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(169, 23);
            txtEmail.TabIndex = 20;
            // 
            // label8
            // 
            label8.Location = new Point(325, 174);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 19;
            label8.Text = "Email";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(650, 266);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(200, 58);
            btnXoa.TabIndex = 18;
            btnXoa.Text = "XÓA";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnDoiMK
            // 
            btnDoiMK.Location = new Point(373, 266);
            btnDoiMK.Name = "btnDoiMK";
            btnDoiMK.Size = new Size(200, 58);
            btnDoiMK.TabIndex = 17;
            btnDoiMK.Text = "ĐỔI MẬT KHẨU";
            btnDoiMK.UseVisualStyleBackColor = true;
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(102, 266);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(200, 58);
            btnDangKy.TabIndex = 16;
            btnDangKy.Text = "ĐĂNG KÝ";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(208, 172);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(41, 19);
            rdoNu.TabIndex = 15;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(106, 172);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(51, 19);
            rdoNam.TabIndex = 14;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(102, 106);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // txtMK
            // 
            txtMK.Location = new Point(650, 109);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(232, 23);
            txtMK.TabIndex = 12;
            // 
            // txtTenLogIn
            // 
            txtTenLogIn.Location = new Point(679, 24);
            txtTenLogIn.Name = "txtTenLogIn";
            txtTenLogIn.Size = new Size(203, 23);
            txtTenLogIn.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(373, 109);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(169, 23);
            txtDiaChi.TabIndex = 10;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(373, 24);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(169, 23);
            txtSDT.TabIndex = 9;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(102, 29);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(200, 23);
            txtHoTen.TabIndex = 8;
            // 
            // label7
            // 
            label7.Location = new Point(38, 32);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 7;
            label7.Text = "Họ Tên Nhân Viên";
            // 
            // label1
            // 
            label1.Location = new Point(34, 112);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 6;
            label1.Text = "Ngày Sinh";
            // 
            // label6
            // 
            label6.Location = new Point(582, 112);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 5;
            label6.Text = "Mật Khẩu";
            // 
            // label5
            // 
            label5.Location = new Point(325, 112);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 4;
            label5.Text = "Địa Chỉ";
            // 
            // label4
            // 
            label4.Location = new Point(325, 27);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 3;
            label4.Text = "SĐT";
            // 
            // label3
            // 
            label3.Location = new Point(34, 174);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 2;
            label3.Text = "Giới Tính";
            // 
            // label2
            // 
            label2.Location = new Point(582, 27);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên Đăng Nhập";
            // 
            // QuanlinhanvienView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 807);
            Controls.Add(groupBox1);
            Controls.Add(dgvNhanVien);
            Name = "QuanlinhanvienView";
            Text = "QuanlinhanvienView";
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvNhanVien;
        private GroupBox groupBox1;
        private TextBox txtEmail;
        private Label label8;
        private Button btnXoa;
        private Button btnDoiMK;
        private Button btnDangKy;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private DateTimePicker dateTimePicker1;
        private TextBox txtMK;
        private TextBox txtTenLogIn;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private TextBox txtHoTen;
        private Label label7;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}