using System;
using System.Windows.Forms;
using QuanLyThuVien.BLL;
using QuanLyThuVien.DAL.Models;

namespace QuanLyThuVien.GUI.SubViews
{
    public partial class ThemNhaXuatBan : Form
    {
        private readonly QuanLiSach quanLiSach = new();
        private int maNXBDangChon = 0;

        public ThemNhaXuatBan()
        {
            InitializeComponent();
        }

        private void ThemNhaXuatBan_Load(object? sender, EventArgs e)
        {
            LoadGridNXB();
        }

        private void LoadGridNXB()
        {
            dgvNXB.DataSource = null;
            dgvNXB.DataSource = quanLiSach.LayDanhSachNhaXuatBan();

            var colMa = dgvNXB.Columns["MaNXB"];
            if (colMa != null) colMa.HeaderText = "Mã NXB";

            var colTen = dgvNXB.Columns["TenNXB"];
            if (colTen != null) colTen.HeaderText = "Tên Nhà Xuất Bản";

            var colSachs = dgvNXB.Columns["Sachs"];
            if (colSachs != null) colSachs.Visible = false;

            maNXBDangChon = 0;
            txtTenNXB.Clear();
        }

        private void dgvNXB_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvNXB.Rows.Count)
            {
                var row = dgvNXB.Rows[e.RowIndex];
                if (row.Cells["MaNXB"].Value != null && int.TryParse(row.Cells["MaNXB"].Value.ToString(), out int id))
                {
                    maNXBDangChon = id;
                    txtTenNXB.Text = row.Cells["TenNXB"].Value?.ToString() ?? "";
                }
            }
        }

        private void btnLuuNXB_Click(object? sender, EventArgs e)
        {
            string tenNXB = txtTenNXB.Text.Trim();
            if (string.IsNullOrWhiteSpace(tenNXB))
            {
                MessageBox.Show("Vui lòng nhập tên nhà xuất bản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNXB.Focus();
                return;
            }

            var nxb = new NhaXuatBan { TenNXB = tenNXB };
            if (quanLiSach.ThemNhaXuatBan(nxb, out string thongBao))
            {
                MessageBox.Show("Thêm nhà xuất bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridNXB();
            }
            else
            {
                MessageBox.Show(thongBao, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaNXB_Click(object? sender, EventArgs e)
        {
            if (maNXBDangChon <= 0 && dgvNXB.CurrentRow != null)
            {
                if (int.TryParse(dgvNXB.CurrentRow.Cells["MaNXB"].Value?.ToString(), out int id))
                {
                    maNXBDangChon = id;
                    txtTenNXB.Text = dgvNXB.CurrentRow.Cells["TenNXB"].Value?.ToString() ?? "";
                }
            }

            if (maNXBDangChon <= 0)
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản cần xóa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenNXB = txtTenNXB.Text.Trim();
            DialogResult dialog = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhà xuất bản '{tenNXB}' (Mã: {maNXBDangChon}) không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                if (quanLiSach.XoaNhaXuatBan(maNXBDangChon, out string thongBao))
                {
                    MessageBox.Show("Xóa nhà xuất bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGridNXB();
                }
                else
                {
                    MessageBox.Show(thongBao, "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDong_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
