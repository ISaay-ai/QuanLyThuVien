using QuanLyThuVien.BLL;
using QuanLyThuVien.DAL;
using QuanLyThuVien.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Linq;

namespace QuanLyThuVien.GUI
{
    public partial class FrmQuanLyNhanVien : Form
    {
        private readonly EmployeeMng _employeeMng = new();

        public FrmQuanLyNhanVien()
        {
            InitializeComponent();
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            btnDangKy.Click += btnDangKy_Click;
            btnXoa.Click += btnXoa_Click;
            LoadNhanVien();
        }

        private void LoadNhanVien()
        {
            using var context = new AppDbContext();
            var data = context.TaiKhoans
                .Select(x => new
                {
                    MaTK = x.MaTK,
                    TenDangNhap = x.TenDangNhap,
                    HoTen = x.HoTen,
                    SoDienThoai = x.SDT,
                    GioiTinh = x.GioiTinh,
                    DiaChi = x.DiaChi,
                    VaiTro = x.VaiTro
                })
                .ToList();

            dgvNhanVien.DataSource = data;

            if (dgvNhanVien.Columns.Contains("MaTK"))
                dgvNhanVien.Columns["MaTK"].HeaderText = "Mã TK";
            if (dgvNhanVien.Columns.Contains("TenDangNhap"))
                dgvNhanVien.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
            if (dgvNhanVien.Columns.Contains("HoTen"))
                dgvNhanVien.Columns["HoTen"].HeaderText = "Họ tên";
            if (dgvNhanVien.Columns.Contains("SoDienThoai"))
                dgvNhanVien.Columns["SoDienThoai"].HeaderText = "SĐT";
            if (dgvNhanVien.Columns.Contains("GioiTinh"))
                dgvNhanVien.Columns["GioiTinh"].HeaderText = "Giới tính";
            if (dgvNhanVien.Columns.Contains("DiaChi"))
                dgvNhanVien.Columns["DiaChi"].HeaderText = "Địa chỉ";
            if (dgvNhanVien.Columns.Contains("VaiTro"))
                dgvNhanVien.Columns["VaiTro"].HeaderText = "Vai trò";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maTaiKhoanText = txtMaNV.Text.Trim();

            if (string.IsNullOrWhiteSpace(maTaiKhoanText))
            {
                MessageBox.Show("Vui lòng nhập Mã NV/TK cần xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool result = false;

            if (int.TryParse(maTaiKhoanText, out int maTk))
            {
                result = _employeeMng.XoaTaiKhoan(maTk);
            }
            else
            {
                result = _employeeMng.XoaTaiKhoan(maTaiKhoanText);
            }

            if (result)
            {
                MessageBox.Show("Xoá tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanVien();
                txtMaNV.Clear();
                txtTenNhanVien.Clear();
                txtSoDienThoai.Clear();
                txtDiaChi.Clear();
                txtMatKhau.Clear();
                cbGioiTinh.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Xoá tài khoản thất bại. Không tìm thấy tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtMaNV.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string hoTen = txtTenNhanVien.Text.Trim();
            string gioiTinh = cbGioiTinh.SelectedItem?.ToString();
            string soDienThoai = txtSoDienThoai.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            if (string.IsNullOrWhiteSpace(tenDangNhap) ||
                string.IsNullOrWhiteSpace(matKhau) ||
                string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã NV/TK, mật khẩu và tên nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool result = _employeeMng.DangKy(
                tenDangNhap: tenDangNhap,
                matKhau: matKhau,
                hoTen: hoTen,
                gioiTinh: gioiTinh,
                sdt: soDienThoai,
                email: null,
                diaChi: diaChi,
                vaiTro: "NhanVien");

            if (result)
            {
                MessageBox.Show("Đăng ký tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanVien();
                txtMaNV.Clear();
                txtTenNhanVien.Clear();
                txtSoDienThoai.Clear();
                txtDiaChi.Clear();
                txtMatKhau.Clear();
                cbGioiTinh.SelectedIndex = -1;
                txtMaNV.Focus();
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại. Tài khoản đã tồn tại hoặc dữ liệu không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string maTaiKhoanText = txtMaNV.Text.Trim();
            string matKhauMoi = txtMatKhau.Text.Trim();

            if (string.IsNullOrWhiteSpace(maTaiKhoanText) || string.IsNullOrWhiteSpace(matKhauMoi))
            {
                MessageBox.Show("Vui lòng nhập Mã NV/TK và mật khẩu mới.", "Thông báo");
                return;
            }

            TaiKhoan? taiKhoan = null;

            using (var context = new AppDbContext())
            {
                if (int.TryParse(maTaiKhoanText, out int maTk))
                {
                    taiKhoan = context.TaiKhoans.FirstOrDefault(x => x.MaTK == maTk);
                }
                else
                {
                    taiKhoan = context.TaiKhoans.FirstOrDefault(x => x.TenDangNhap == maTaiKhoanText);
                }
            }

            if (taiKhoan == null)
            {
                MessageBox.Show("Không tìm thấy tài khoản tương ứng.", "Thông báo");
                return;
            }

            bool result = _employeeMng.DoiMatKhau(taiKhoan.MaTK, taiKhoan.MatKhau, matKhauMoi);

            if (result)
            {
                MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo");
                txtMatKhau.Clear();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại.", "Thông báo");
            }
        }
    }
}
