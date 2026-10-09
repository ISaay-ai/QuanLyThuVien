namespace QuanLyThuVien
{
    partial class FrmForgotPass
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            REGISTER = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            LoginNowLbl = new LinkLabel();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(215, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(363, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(215, 197);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(363, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(262, 276);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(316, 31);
            textBox3.TabIndex = 6;
            // 
            // REGISTER
            // 
            REGISTER.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            REGISTER.Location = new Point(215, 38);
            REGISTER.Name = "REGISTER";
            REGISTER.Size = new Size(253, 52);
            REGISTER.TabIndex = 7;
            REGISTER.Text = "Đổi mật khẩu";
            REGISTER.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 132);
            label1.Name = "label1";
            label1.Size = new Size(139, 25);
            label1.TabIndex = 8;
            label1.Text = "Mã số sinh viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 203);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 9;
            label2.Text = "Mật khẩu mới:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 276);
            label3.Name = "label3";
            label3.Size = new Size(196, 25);
            label3.TabIndex = 10;
            label3.Text = "Nhập lại mật khẩu mới:";
            // 
            // button1
            // 
            button1.Location = new Point(208, 339);
            button1.Name = "button1";
            button1.Size = new Size(260, 55);
            button1.TabIndex = 11;
            button1.Text = "Đặt lại mật khẩu";
            button1.UseVisualStyleBackColor = true;
            // 
            // LoginNowLbl
            // 
            LoginNowLbl.AutoSize = true;
            LoginNowLbl.Location = new Point(244, 421);
            LoginNowLbl.Name = "LoginNowLbl";
            LoginNowLbl.Size = new Size(167, 25);
            LoginNowLbl.TabIndex = 18;
            LoginNowLbl.TabStop = true;
            LoginNowLbl.Text = "Quay lại đăng nhập";
            // 
            // FrmForgotPass
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 474);
            Controls.Add(LoginNowLbl);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(REGISTER);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FrmForgotPass";
            Text = "Quên mật khẩu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label REGISTER;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private LinkLabel LoginNowLbl;
    }
}