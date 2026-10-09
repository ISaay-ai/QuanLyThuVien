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
            LOGIN = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label4 = new Label();
            ForgotPassLbl = new LinkLabel();
            ShowPassBox = new CheckBox();
            SignUpLbl = new LinkLabel();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(96, 200);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(422, 31);
            textBox1.TabIndex = 0;
            // 
            // LOGIN
            // 
            LOGIN.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LOGIN.Location = new Point(194, 48);
            LOGIN.Name = "LOGIN";
            LOGIN.Size = new Size(253, 52);
            LOGIN.TabIndex = 1;
            LOGIN.Text = "Đăng nhập";
            LOGIN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(96, 292);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(422, 31);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 145);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 3;
            label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 254);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu:";
            // 
            // button1
            // 
            button1.Location = new Point(96, 411);
            button1.Name = "button1";
            button1.Size = new Size(422, 59);
            button1.TabIndex = 5;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(147, 498);
            label4.Name = "label4";
            label4.Size = new Size(163, 25);
            label4.TabIndex = 7;
            label4.Text = "Chưa có tài khoản?";
            // 
            // ForgotPassLbl
            // 
            ForgotPassLbl.AutoSize = true;
            ForgotPassLbl.Location = new Point(376, 343);
            ForgotPassLbl.Name = "ForgotPassLbl";
            ForgotPassLbl.Size = new Size(142, 25);
            ForgotPassLbl.TabIndex = 8;
            ForgotPassLbl.TabStop = true;
            ForgotPassLbl.Text = "Quên mật khẩu?";
            // 
            // ShowPassBox
            // 
            ShowPassBox.AutoSize = true;
            ShowPassBox.Location = new Point(96, 339);
            ShowPassBox.Name = "ShowPassBox";
            ShowPassBox.Size = new Size(153, 29);
            ShowPassBox.TabIndex = 9;
            ShowPassBox.Text = "Hiện mật khẩu";
            ShowPassBox.UseVisualStyleBackColor = true;
            // 
            // SignUpLbl
            // 
            SignUpLbl.AutoSize = true;
            SignUpLbl.Location = new Point(346, 498);
            SignUpLbl.Name = "SignUpLbl";
            SignUpLbl.Size = new Size(119, 25);
            SignUpLbl.TabIndex = 10;
            SignUpLbl.TabStop = true;
            SignUpLbl.Text = "Tạo tài khoản";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 575);
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
            Name = "FrmLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label LOGIN;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label4;
        private LinkLabel ForgotPassLbl;
        private CheckBox ShowPassBox;
        private LinkLabel SignUpLbl;
    }
}
