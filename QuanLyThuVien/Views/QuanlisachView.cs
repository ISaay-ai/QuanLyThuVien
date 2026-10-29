using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien.Views
{
    public partial class QuanlisachView : Form
    {
        public QuanlisachView()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Thêm dữ liệu mẫu cho các ComboBox (có thể thay thế bằng gọi BLL sau)
            cmbTacGia.Items.AddRange(new string[] { "maichi", "TG1", "TG5", "vancu" });
            cmbNhaXuatBan.Items.AddRange(new string[] { "NhaVan", "tuoitre", "hongduc", "laodong" });
            cmbLoaiSach.Items.AddRange(new string[] { "thieunhi", "tieuthuyet", "tailieu", "L1", "L4" });
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaSach.Text = row.Cells["MaSach"].Value?.ToString();
                txtTenSach.Text = row.Cells["TenSach"].Value?.ToString();
                cmbTacGia.Text = row.Cells["MaTacGia"].Value?.ToString();
                cmbNhaXuatBan.Text = row.Cells["MaXB"].Value?.ToString();
                cmbLoaiSach.Text = row.Cells["MaLoai"].Value?.ToString();
                txtSoTrang.Text = row.Cells["SoTrang"].Value?.ToString();
                txtGiaBan.Text = row.Cells["GiaBan"].Value?.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value?.ToString();
            }
        }
    }
}