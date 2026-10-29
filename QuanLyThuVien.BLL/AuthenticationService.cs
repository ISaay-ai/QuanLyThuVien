using System;
using System.Linq;
using QuanLyThuVien.DAL;
using QuanLyThuVien.DAL.Models;

namespace QuanLyThuVien.BLL
{
    public class AuthenticationService
    {
        public void KhoiTaoTaiKhoanMacDinh()
        {
            try
            {
                using var context = new AppDbContext();
                if (!context.TaiKhoans.Any())
                {
                    var admin = new TaiKhoan
                    {
                        TenDangNhap = "admin",
                        MatKhau = "admin",
                        HoTen = "Quản Trị Viên (Admin)",
                        VaiTro = "Admin",
                        Email = "admin@thuvien.edu.vn",
                        SDT = "0988888888"
                    };

                    var nhanvien = new TaiKhoan
                    {
                        TenDangNhap = "nhanvien",
                        MatKhau = "123456",
                        HoTen = "Nhân Viên Thư Viện",
                        VaiTro = "NhanVien",
                        Email = "nhanvien@thuvien.edu.vn",
                        SDT = "0977777777"
                    };

                    context.TaiKhoans.AddRange(admin, nhanvien);
                    context.SaveChanges();
                }
            }
            catch
            {
                // Bỏ qua lỗi kết nối trong khởi tạo ban đầu, lỗi sẽ được báo chi tiết khi thực hiện đăng nhập
            }
        }

        public TaiKhoan? Authenticate(string tenDangNhap, string matKhau)
        {
            if (string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                return null;
            }

            KhoiTaoTaiKhoanMacDinh();

            using var context = new AppDbContext();
            string username = tenDangNhap.Trim();
            var taiKhoan = context.TaiKhoans.FirstOrDefault(x => x.TenDangNhap.ToLower() == username.ToLower());
            if (taiKhoan == null || taiKhoan.MatKhau != matKhau)
            {
                return null;
            }

            return taiKhoan;
        }

        public bool ResetPassword(string tenDangNhap, string matKhauMoi, out string thongBaoLoi)
        {
            thongBaoLoi = string.Empty;

            if (string.IsNullOrWhiteSpace(tenDangNhap))
            {
                thongBaoLoi = "Vui lòng nhập tên đăng nhập.";
                return false;
            }

            if (string.IsNullOrEmpty(matKhauMoi))
            {
                thongBaoLoi = "Vui lòng nhập mật khẩu mới.";
                return false;
            }

            try
            {
                KhoiTaoTaiKhoanMacDinh();

                using var context = new AppDbContext();
                string username = tenDangNhap.Trim();
                var taiKhoan = context.TaiKhoans.FirstOrDefault(x => x.TenDangNhap.ToLower() == username.ToLower());
                if (taiKhoan == null)
                {
                    thongBaoLoi = "Tên đăng nhập không tồn tại trong hệ thống.";
                    return false;
                }

                taiKhoan.MatKhau = matKhauMoi;
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                thongBaoLoi = "Lỗi khi cập nhật mật khẩu: " + ex.Message;
                return false;
            }
        }
    }
}
