namespace QuanLyThuVien.GUI.SubViews
{
    partial class ThemNhaXuatBan
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
            this.labelTenNXB = new System.Windows.Forms.Label();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.btnLuuNXB = new System.Windows.Forms.Button();
            this.btnXoaNXB = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.dgvNXB = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).BeginInit();
            this.SuspendLayout();

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(145, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(243, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "QUẢN LÝ NHÀ XUẤT BẢN";

            // labelTenNXB
            this.labelTenNXB.AutoSize = true;
            this.labelTenNXB.Location = new System.Drawing.Point(30, 65);
            this.labelTenNXB.Name = "labelTenNXB";
            this.labelTenNXB.Size = new System.Drawing.Size(107, 17);
            this.labelTenNXB.TabIndex = 1;
            this.labelTenNXB.Text = "Tên nhà xuất bản:";

            // txtTenNXB
            this.txtTenNXB.Location = new System.Drawing.Point(145, 62);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(180, 23);
            this.txtTenNXB.TabIndex = 2;

            // btnLuuNXB
            this.btnLuuNXB.Location = new System.Drawing.Point(335, 60);
            this.btnLuuNXB.Name = "btnLuuNXB";
            this.btnLuuNXB.Size = new System.Drawing.Size(70, 27);
            this.btnLuuNXB.TabIndex = 3;
            this.btnLuuNXB.Text = "Lưu";
            this.btnLuuNXB.UseVisualStyleBackColor = true;
            this.btnLuuNXB.Click += new System.EventHandler(this.btnLuuNXB_Click);

            // btnXoaNXB
            this.btnXoaNXB.Location = new System.Drawing.Point(415, 60);
            this.btnXoaNXB.Name = "btnXoaNXB";
            this.btnXoaNXB.Size = new System.Drawing.Size(70, 27);
            this.btnXoaNXB.TabIndex = 6;
            this.btnXoaNXB.Text = "Xóa";
            this.btnXoaNXB.UseVisualStyleBackColor = true;
            this.btnXoaNXB.Click += new System.EventHandler(this.btnXoaNXB_Click);

            // dgvNXB
            this.dgvNXB.AllowUserToAddRows = false;
            this.dgvNXB.AllowUserToDeleteRows = false;
            this.dgvNXB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNXB.Location = new System.Drawing.Point(30, 105);
            this.dgvNXB.Name = "dgvNXB";
            this.dgvNXB.ReadOnly = true;
            this.dgvNXB.RowHeadersVisible = false;
            this.dgvNXB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNXB.Size = new System.Drawing.Size(460, 210);
            this.dgvNXB.TabIndex = 4;
            this.dgvNXB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNXB_CellClick);

            // btnDong
            this.btnDong.Location = new System.Drawing.Point(395, 330);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(95, 32);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            // ThemNhaXuatBan
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 380);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvNXB);
            this.Controls.Add(this.btnXoaNXB);
            this.Controls.Add(this.btnLuuNXB);
            this.Controls.Add(this.txtTenNXB);
            this.Controls.Add(this.labelTenNXB);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemNhaXuatBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Nhà Xuất Bản";
            this.Load += new System.EventHandler(this.ThemNhaXuatBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTenNXB;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.Button btnLuuNXB;
        private System.Windows.Forms.Button btnXoaNXB;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvNXB;
    }
}
