namespace QuanLyThuVien
{
    partial class FrmRegister
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
            REGISTER = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            RegisterBtn = new Button();
            label7 = new Label();
            LoginNowLbl = new LinkLabel();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // REGISTER
            // 
            REGISTER.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            REGISTER.Location = new Point(198, 18);
            REGISTER.Margin = new Padding(2, 0, 2, 0);
            REGISTER.Name = "REGISTER";
            REGISTER.Size = new Size(177, 31);
            REGISTER.TabIndex = 2;
            REGISTER.Text = "Tạo tài khoản";
            REGISTER.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(214, 83);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 23);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 137);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 4;
            label1.Text = "Tên nhân viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 86);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 5;
            label2.Text = "Mã số nhân viên:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(214, 134);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 23);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 305);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 7;
            label3.Text = "Địa chỉ:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "K16", "K17", "K18", "K19", "K20", "K21", "K22", "K23", "K24", "K25", "K26", "K27" });
            comboBox1.Location = new Point(214, 367);
            comboBox1.Margin = new Padding(2, 2, 2, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(96, 23);
            comboBox1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 370);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 10;
            label4.Text = "Giới tính:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(214, 182);
            textBox3.Margin = new Padding(2, 2, 2, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(207, 23);
            textBox3.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 252);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(79, 15);
            label5.TabIndex = 12;
            label5.Text = "Số điện thoại:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(214, 302);
            textBox4.Margin = new Padding(2, 2, 2, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(207, 23);
            textBox4.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 185);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 14;
            label6.Text = "Mật khẩu:";
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.White;
            RegisterBtn.Location = new Point(144, 445);
            RegisterBtn.Margin = new Padding(2, 2, 2, 2);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(309, 41);
            RegisterBtn.TabIndex = 15;
            RegisterBtn.Text = "Tạo tài khoản";
            RegisterBtn.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(159, 507);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 16;
            label7.Text = "Đã có tài khoản?";
            // 
            // LoginNowLbl
            // 
            LoginNowLbl.AutoSize = true;
            LoginNowLbl.Location = new Point(327, 507);
            LoginNowLbl.Margin = new Padding(2, 0, 2, 0);
            LoginNowLbl.Name = "LoginNowLbl";
            LoginNowLbl.Size = new Size(94, 15);
            LoginNowLbl.TabIndex = 17;
            LoginNowLbl.TabStop = true;
            LoginNowLbl.Text = "Đăng nhập ngay";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(214, 244);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(207, 23);
            textBox5.TabIndex = 18;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 589);
            Controls.Add(textBox5);
            Controls.Add(LoginNowLbl);
            Controls.Add(label7);
            Controls.Add(RegisterBtn);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(REGISTER);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FrmRegister";
            Text = "Tạo tài khoản";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label REGISTER;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private Button RegisterBtn;
        private Label label7;
        private LinkLabel LoginNowLbl;
        private TextBox textBox5;
    }
}