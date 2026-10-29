using System;
using System.Windows.Forms;
using QuanLyThuVien.BLL;
using QuanLyThuVien.DAL.Models;

namespace QuanLyThuVien.GUI.SubViews
{
    public partial class ThemTheLoai : Form
    {
        private readonly QuanLiSach quanLiSach = new();
        private int maTheLoaiDangChon = 0;

        public ThemTheLoai()
        {
            InitializeComponent();
        }

        private void ThemTheLoai_Load(object? sender, EventArgs e)
        {
            LoadGridTheLoai();
        }

        private void LoadGridTheLoai()
        {
            dgvTheLoai.DataSource = null;
            dgvTheLoai.DataSource = quanLiSach.LayDanhSachTheLoai();

            var colMa = dgvTheLoai.Columns["MaTheLoai"];
            if (colMa != null) colMa.HeaderText = "Mã Thể Loại";

            var colTen = dgvTheLoai.Columns["TenTheLoai"];
            if (colTen != null) colTen.HeaderText = "Tên Thể Loại";

            var colSachs = dgvTheLoai.Columns["Sachs"];
            if (colSachs != null) colSachs.Visible = false;

            maTheLoaiDangChon = 0;
            txtTenTheLoai.Clear();
        }

        private void dgvTheLoai_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvTheLoai.Rows.Count)
            {
                var row = dgvTheLoai.Rows[e.RowIndex];
                if (row.Cells["MaTheLoai"].Value != null && int.TryParse(row.Cells["MaTheLoai"].Value.ToString(), out int id))
                {
                    maTheLoaiDangChon = id;
                    txtTenTheLoai.Text = row.Cells["TenTheLoai"].Value?.ToString() ?? "";
                }
            }
        }

        private void btnLuuTheLoai_Click(object? sender, EventArgs e)
        {
            string tenTheLoai = txtTenTheLoai.Text.Trim();
            if (string.IsNullOrWhiteSpace(tenTheLoai))
            {
                MessageBox.Show("Vui lòng nhập tên thể loại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTheLoai.Focus();
                return;
            }

            var tl = new TheLoai { TenTheLoai = tenTheLoai };
            if (quanLiSach.ThemTheLoai(tl, out string thongBao))
            {
                MessageBox.Show("Thêm thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridTheLoai();
            }
            else
            {
                MessageBox.Show(thongBao, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaTheLoai_Click(object? sender, EventArgs e)
        {
            if (maTheLoaiDangChon <= 0 && dgvTheLoai.CurrentRow != null)
            {
                if (int.TryParse(dgvTheLoai.CurrentRow.Cells["MaTheLoai"].Value?.ToString(), out int id))
                {
                    maTheLoaiDangChon = id;
                    txtTenTheLoai.Text = dgvTheLoai.CurrentRow.Cells["TenTheLoai"].Value?.ToString() ?? "";
                }
            }

            if (maTheLoaiDangChon <= 0)
            {
                MessageBox.Show("Vui lòng chọn thể loại cần xóa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenTheLoai = txtTenTheLoai.Text.Trim();
            DialogResult dialog = MessageBox.Show($"Bạn có chắc chắn muốn xóa thể loại '{tenTheLoai}' (Mã: {maTheLoaiDangChon}) không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                if (quanLiSach.XoaTheLoai(maTheLoaiDangChon, out string thongBao))
                {
                    MessageBox.Show("Xóa thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGridTheLoai();
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
