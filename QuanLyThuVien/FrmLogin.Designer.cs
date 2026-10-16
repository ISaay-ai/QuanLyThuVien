namespace QuanLyThuVien
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label4 = new Label();
            ForgotPassLbl = new LinkLabel();
            ShowPassBox = new CheckBox();
            SignUpLbl = new LinkLabel();
            LOGIN = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 120);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(297, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(67, 175);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(297, 23);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 87);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 3;
            label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 152);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu:";
            // 
            // button1
            // 
            button1.Location = new Point(67, 247);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(295, 35);
            button1.TabIndex = 5;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 299);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 7;
            label4.Text = "Chưa có tài khoản?";
            // 
            // ForgotPassLbl
            // 
            ForgotPassLbl.AutoSize = true;
            ForgotPassLbl.Location = new Point(263, 206);
            ForgotPassLbl.Margin = new Padding(2, 0, 2, 0);
            ForgotPassLbl.Name = "ForgotPassLbl";
            ForgotPassLbl.Size = new Size(94, 15);
            ForgotPassLbl.TabIndex = 8;
            ForgotPassLbl.TabStop = true;
            ForgotPassLbl.Text = "Quên mật khẩu?";
            // 
            // ShowPassBox
            // 
            ShowPassBox.AutoSize = true;
            ShowPassBox.Location = new Point(67, 203);
            ShowPassBox.Margin = new Padding(2, 2, 2, 2);
            ShowPassBox.Name = "ShowPassBox";
            ShowPassBox.Size = new Size(104, 19);
            ShowPassBox.TabIndex = 9;
            ShowPassBox.Text = "Hiện mật khẩu";
            ShowPassBox.UseVisualStyleBackColor = true;
            // 
            // SignUpLbl
            // 
            SignUpLbl.AutoSize = true;
            SignUpLbl.Location = new Point(242, 299);
            SignUpLbl.Margin = new Padding(2, 0, 2, 0);
            SignUpLbl.Name = "SignUpLbl";
            SignUpLbl.Size = new Size(79, 15);
            SignUpLbl.TabIndex = 10;
            SignUpLbl.TabStop = true;
            SignUpLbl.Text = "Tạo tài khoản";
            // 
            // LOGIN
            // 
            LOGIN.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LOGIN.Location = new Point(136, 29);
            LOGIN.Margin = new Padding(2, 0, 2, 0);
            LOGIN.Name = "LOGIN";
            LOGIN.Size = new Size(177, 31);
            LOGIN.TabIndex = 1;
            LOGIN.Text = "Đăng nhập";
            LOGIN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 345);
            Controls.Add(SignUpLbl);
            Controls.Add(ShowPassBox);
            Controls.Add(ForgotPassLbl);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(LOGIN);
            Controls.Add(textBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FrmLogin";
            Text = "Đăng Nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label4;
        private LinkLabel ForgotPassLbl;
        private CheckBox ShowPassBox;
        private LinkLabel SignUpLbl;
        private Label LOGIN;
    }
}
