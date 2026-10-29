using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyThuVien.BLL;

namespace QuanLyThuVien.Views
{
    public partial class DocgiaView : Form
    {
        private readonly DocGiaMng docGiaMng = new DocGiaMng();

        public DocgiaView()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            cmbKhoaHoc.Items.AddRange(new string[] { "K61", "K62", "K63" });
            cmbKhoaHoc.SelectedIndex = 2;

            dataGridView1.DataSource = docGiaMng.LayDanhSach();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaSV.Text = row.Cells["MaSV"].Value?.ToString();
                txtHoTen.Text = row.Cells["TenSV"].Value?.ToString();
                txtNganhHoc.Text = row.Cells["NganhHoc"].Value?.ToString();
                cmbKhoaHoc.Text = row.Cells["KhoaHoc"].Value?.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value?.ToString();
            }
        }
    }
}