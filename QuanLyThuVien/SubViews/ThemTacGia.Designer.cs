namespace QuanLyThuVien.GUI.SubViews
{
    partial class ThemTacGia
    {
        private System.ComponentModel.IContainer components = null;

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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTenTacGia = new System.Windows.Forms.Label();
            this.txtTenTacGia = new System.Windows.Forms.TextBox();
            this.btnLuuTacGia = new System.Windows.Forms.Button();
            this.btnXoaTacGia = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.dgvTacGia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).BeginInit();
            this.SuspendLayout();

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(175, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(176, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "QUẢN LÝ TÁC GIẢ";

            // labelTenTacGia
            this.labelTenTacGia.AutoSize = true;
            this.labelTenTacGia.Location = new System.Drawing.Point(30, 65);
            this.labelTenTacGia.Name = "labelTenTacGia";
            this.labelTenTacGia.Size = new System.Drawing.Size(86, 17);
            this.labelTenTacGia.TabIndex = 1;
            this.labelTenTacGia.Text = "Tên tác giả:";

            // txtTenTacGia
            this.txtTenTacGia.Location = new System.Drawing.Point(135, 62);
            this.txtTenTacGia.Name = "txtTenTacGia";
            this.txtTenTacGia.Size = new System.Drawing.Size(190, 23);
            this.txtTenTacGia.TabIndex = 2;

            // btnLuuTacGia
            this.btnLuuTacGia.Location = new System.Drawing.Point(335, 60);
            this.btnLuuTacGia.Name = "btnLuuTacGia";
            this.btnLuuTacGia.Size = new System.Drawing.Size(70, 27);
            this.btnLuuTacGia.TabIndex = 3;
            this.btnLuuTacGia.Text = "Lưu";
            this.btnLuuTacGia.UseVisualStyleBackColor = true;
            this.btnLuuTacGia.Click += new System.EventHandler(this.btnLuuTacGia_Click);

            // btnXoaTacGia
            this.btnXoaTacGia.Location = new System.Drawing.Point(415, 60);
            this.btnXoaTacGia.Name = "btnXoaTacGia";
            this.btnXoaTacGia.Size = new System.Drawing.Size(70, 27);
            this.btnXoaTacGia.TabIndex = 6;
            this.btnXoaTacGia.Text = "Xóa";
            this.btnXoaTacGia.UseVisualStyleBackColor = true;
            this.btnXoaTacGia.Click += new System.EventHandler(this.btnXoaTacGia_Click);

            // dgvTacGia
            this.dgvTacGia.AllowUserToAddRows = false;
            this.dgvTacGia.AllowUserToDeleteRows = false;
            this.dgvTacGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTacGia.Location = new System.Drawing.Point(30, 105);
            this.dgvTacGia.Name = "dgvTacGia";
            this.dgvTacGia.ReadOnly = true;
            this.dgvTacGia.RowHeadersVisible = false;
            this.dgvTacGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTacGia.Size = new System.Drawing.Size(460, 210);
            this.dgvTacGia.TabIndex = 4;
            this.dgvTacGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTacGia_CellClick);

            // btnDong
            this.btnDong.Location = new System.Drawing.Point(395, 330);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(95, 32);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            // ThemTacGia
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 380);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvTacGia);
            this.Controls.Add(this.btnXoaTacGia);
            this.Controls.Add(this.btnLuuTacGia);
            this.Controls.Add(this.txtTenTacGia);
            this.Controls.Add(this.labelTenTacGia);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Tác Giả";
            this.Load += new System.EventHandler(this.ThemTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTacGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTenTacGia;
        private System.Windows.Forms.TextBox txtTenTacGia;
        private System.Windows.Forms.Button btnLuuTacGia;
        private System.Windows.Forms.Button btnXoaTacGia;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvTacGia;
    }
}
