namespace QuanLyThuVien.GUI.SubViews
{
    partial class ThemTheLoai
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
            this.labelTenTheLoai = new System.Windows.Forms.Label();
            this.txtTenTheLoai = new System.Windows.Forms.TextBox();
            this.btnLuuTheLoai = new System.Windows.Forms.Button();
            this.btnXoaTheLoai = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.dgvTheLoai = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).BeginInit();
            this.SuspendLayout();

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(170, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(185, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "QUẢN LÝ THỂ LOẠI";

            // labelTenTheLoai
            this.labelTenTheLoai.AutoSize = true;
            this.labelTenTheLoai.Location = new System.Drawing.Point(30, 65);
            this.labelTenTheLoai.Name = "labelTenTheLoai";
            this.labelTenTheLoai.Size = new System.Drawing.Size(89, 17);
            this.labelTenTheLoai.TabIndex = 1;
            this.labelTenTheLoai.Text = "Tên thể loại:";

            // txtTenTheLoai
            this.txtTenTheLoai.Location = new System.Drawing.Point(135, 62);
            this.txtTenTheLoai.Name = "txtTenTheLoai";
            this.txtTenTheLoai.Size = new System.Drawing.Size(190, 23);
            this.txtTenTheLoai.TabIndex = 2;

            // btnLuuTheLoai
            this.btnLuuTheLoai.Location = new System.Drawing.Point(335, 60);
            this.btnLuuTheLoai.Name = "btnLuuTheLoai";
            this.btnLuuTheLoai.Size = new System.Drawing.Size(70, 27);
            this.btnLuuTheLoai.TabIndex = 3;
            this.btnLuuTheLoai.Text = "Lưu";
            this.btnLuuTheLoai.UseVisualStyleBackColor = true;
            this.btnLuuTheLoai.Click += new System.EventHandler(this.btnLuuTheLoai_Click);

            // btnXoaTheLoai
            this.btnXoaTheLoai.Location = new System.Drawing.Point(415, 60);
            this.btnXoaTheLoai.Name = "btnXoaTheLoai";
            this.btnXoaTheLoai.Size = new System.Drawing.Size(70, 27);
            this.btnXoaTheLoai.TabIndex = 6;
            this.btnXoaTheLoai.Text = "Xóa";
            this.btnXoaTheLoai.UseVisualStyleBackColor = true;
            this.btnXoaTheLoai.Click += new System.EventHandler(this.btnXoaTheLoai_Click);

            // dgvTheLoai
            this.dgvTheLoai.AllowUserToAddRows = false;
            this.dgvTheLoai.AllowUserToDeleteRows = false;
            this.dgvTheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheLoai.Location = new System.Drawing.Point(30, 105);
            this.dgvTheLoai.Name = "dgvTheLoai";
            this.dgvTheLoai.ReadOnly = true;
            this.dgvTheLoai.RowHeadersVisible = false;
            this.dgvTheLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTheLoai.Size = new System.Drawing.Size(460, 210);
            this.dgvTheLoai.TabIndex = 4;
            this.dgvTheLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTheLoai_CellClick);

            // btnDong
            this.btnDong.Location = new System.Drawing.Point(395, 330);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(95, 32);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            // ThemTheLoai
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 380);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvTheLoai);
            this.Controls.Add(this.btnXoaTheLoai);
            this.Controls.Add(this.btnLuuTheLoai);
            this.Controls.Add(this.txtTenTheLoai);
            this.Controls.Add(this.labelTenTheLoai);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemTheLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Thể Loại";
            this.Load += new System.EventHandler(this.ThemTheLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTenTheLoai;
        private System.Windows.Forms.TextBox txtTenTheLoai;
        private System.Windows.Forms.Button btnLuuTheLoai;
        private System.Windows.Forms.Button btnXoaTheLoai;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvTheLoai;
    }
}
