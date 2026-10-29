using System;
using System.Windows.Forms;
using QuanLyThuVien.BLL;
using QuanLyThuVien.DAL.Models;

namespace QuanLyThuVien.GUI.SubViews
{
    public partial class ThemTacGia : Form
    {
        private readonly QuanLiSach quanLiSach = new();
        private int maTacGiaDangChon = 0;

        public ThemTacGia()
        {
            InitializeComponent();
        }

        private void ThemTacGia_Load(object? sender, EventArgs e)
        {
            LoadGridTacGia();
        }

        private void LoadGridTacGia()
        {
            dgvTacGia.DataSource = null;
            dgvTacGia.DataSource = quanLiSach.LayDanhSachTacGia();

            var colMa = dgvTacGia.Columns["MaTacGia"];
            if (colMa != null) colMa.HeaderText = "Mã Tác Giả";

            var colTen = dgvTacGia.Columns["TenTacGia"];
            if (colTen != null) colTen.HeaderText = "Tên Tác Giả";

            var colSachs = dgvTacGia.Columns["Sachs"];
            if (colSachs != null) colSachs.Visible = false;

            maTacGiaDangChon = 0;
            txtTenTacGia.Clear();
        }

        private void dgvTacGia_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvTacGia.Rows.Count)
            {
                var row = dgvTacGia.Rows[e.RowIndex];
                if (row.Cells["MaTacGia"].Value != null && int.TryParse(row.Cells["MaTacGia"].Value.ToString(), out int id))
                {
                    maTacGiaDangChon = id;
                    txtTenTacGia.Text = row.Cells["TenTacGia"].Value?.ToString() ?? "";
                }
            }
        }

        private void btnLuuTacGia_Click(object? sender, EventArgs e)
        {
            string tenTacGia = txtTenTacGia.Text.Trim();
            if (string.IsNullOrWhiteSpace(tenTacGia))
            {
                MessageBox.Show("Vui lòng nhập tên tác giả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTacGia.Focus();
                return;
            }

            var tg = new TacGia { TenTacGia = tenTacGia };
            if (quanLiSach.ThemTacGia(tg, out string thongBao))
            {
                MessageBox.Show("Thêm tác giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridTacGia();
            }
            else
            {
                MessageBox.Show(thongBao, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaTacGia_Click(object? sender, EventArgs e)
        {
            if (maTacGiaDangChon <= 0 && dgvTacGia.CurrentRow != null)
            {
                if (int.TryParse(dgvTacGia.CurrentRow.Cells["MaTacGia"].Value?.ToString(), out int id))
                {
                    maTacGiaDangChon = id;
                    txtTenTacGia.Text = dgvTacGia.CurrentRow.Cells["TenTacGia"].Value?.ToString() ?? "";
                }
            }

            if (maTacGiaDangChon <= 0)
            {
                MessageBox.Show("Vui lòng chọn tác giả cần xóa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenTacGia = txtTenTacGia.Text.Trim();
            DialogResult dialog = MessageBox.Show($"Bạn có chắc chắn muốn xóa tác giả '{tenTacGia}' (Mã: {maTacGiaDangChon}) không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                if (quanLiSach.XoaTacGia(maTacGiaDangChon, out string thongBao))
                {
                    MessageBox.Show("Xóa tác giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadGridTacGia();
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
