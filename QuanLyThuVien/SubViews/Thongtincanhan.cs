using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyThuVien.BLL;
using QuanLyThuVien.DAL;
using QuanLyThuVien.DAL.Models;

namespace QuanLyThuVien.SubViews
{
    public partial class Thongtincanhan : Form
    {
        private readonly BLL.Thongtincanhan _bll = new BLL.Thongtincanhan();
        private TaiKhoan? _currentUser;

        public Thongtincanhan() : this(null)
        {
        }

        public Thongtincanhan(TaiKhoan? user)
        {
            InitializeComponent();
            _currentUser = user;

            this.Load += Thongtincanhan_Load;
            this.Resize += Thongtincanhan_Resize;
        }

        private void Thongtincanhan_Load(object? sender, EventArgs e)
        {
            if (_currentUser == null)
            {
                using var context = new AppDbContext();
                _currentUser = context.TaiKhoans.FirstOrDefault();
            }

            NapDuLieuNguoiDung();
            CanChinhGiaoDien();
        }

        private void Thongtincanhan_Resize(object? sender, EventArgs e)
        {
            CanChinhGiaoDien();
        }

        private void CanChinhGiaoDien()
        {
            pnlCard.Left = Math.Max(20, (this.ClientSize.Width - pnlCard.Width) / 2);
            btnLuu.Left = Math.Min(this.ClientSize.Width - btnLuu.Width - 30, pnlCard.Right - btnLuu.Width);
            btnHuy.Left = btnLuu.Left - btnHuy.Width - 15;
        }

        private void NapDuLieuNguoiDung()
        {
            if (_currentUser == null) return;

            txtTenDangNhap.Text = _currentUser.TenDangNhap;
            txtMatKhau.Text = _currentUser.MatKhau;
            txtHoTen.Text = _currentUser.HoTen;
            cboGioiTinh.SelectedItem = string.IsNullOrWhiteSpace(_currentUser.GioiTinh) ? "Nam" : _currentUser.GioiTinh;
            txtEmail.Text = _currentUser.Email ?? string.Empty;
            txtSDT.Text = _currentUser.SDT ?? string.Empty;
            dtpNgaySinh.Value = _currentUser.NgaySinh ?? new DateTime(2000, 1, 1);
            txtDiaChi.Text = _currentUser.DiaChi ?? string.Empty;
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog
            {
                Title = "Chọn ảnh đại diện",
                Filter = "Tệp hình ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picAvatar.Image = Image.FromFile(ofd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể mở hình ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            picAvatar.Image = null;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_currentUser == null)
            {
                MessageBox.Show("Không tìm thấy thông tin tài khoản người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hoTen = txtHoTen.Text.Trim();
            string matKhau = txtMatKhau.Text;
            string? gioiTinh = cboGioiTinh.SelectedItem?.ToString();
            DateTime ngaySinh = dtpNgaySinh.Value.Date;
            string sdt = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            if (string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ và tên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }

            if (_bll.CapNhatThongTin(_currentUser.MaTK, hoTen, matKhau, gioiTinh, ngaySinh, sdt, email, diaChi, out string thongBaoLoi))
            {
                _currentUser.HoTen = hoTen;
                _currentUser.MatKhau = matKhau;
                _currentUser.GioiTinh = gioiTinh;
                _currentUser.NgaySinh = ngaySinh;
                _currentUser.SDT = sdt;
                _currentUser.Email = email;
                _currentUser.DiaChi = diaChi;

                MessageBox.Show("Cập nhật thông tin cá nhân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(thongBaoLoi, "Lỗi cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            NapDuLieuNguoiDung();
        }
    }
}

namespace QuanLyThuVien.GUI
{
    // Alias giữ tương thích ngược
    public class Profile : QuanLyThuVien.SubViews.Thongtincanhan
    {
        public Profile() : base() { }
        public Profile(TaiKhoan? user) : base(user) { }
    }
}
