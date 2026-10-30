using System;
using System.Linq;
using QuanLyThuVien.DAL;
using QuanLyThuVien.DAL.Models;

namespace QuanLyThuVien.BLL
{
    public class Thongtincanhan
    {

        /// Lấy thông tin tài khoản người dùng theo mã tài khoản

        public TaiKhoan? LayThongTin(int maTK)
        {
            try
            {
                using var context = new AppDbContext();
                return context.TaiKhoans.FirstOrDefault(x => x.MaTK == maTK);
            }
            catch
            {
                return null;
            }
        }


        /// Cập nhật thông tin cá nhân của tài khoản người dùng

        public bool CapNhatThongTin(int maTK, string hoTen, string matKhau, string? gioiTinh, DateTime? ngaySinh, string? sdt, string? email, string? diaChi, out string thongBaoLoi)
        {
            thongBaoLoi = string.Empty;

            if (string.IsNullOrWhiteSpace(hoTen))
            {
                thongBaoLoi = "Họ và tên không được để trống.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(matKhau))
            {
                thongBaoLoi = "Mật khẩu không được để trống.";
                return false;
            }

            try
            {
                using var context = new AppDbContext();
                var tk = context.TaiKhoans.FirstOrDefault(x => x.MaTK == maTK);
                if (tk == null)
                {
                    thongBaoLoi = "Không tìm thấy thông tin tài khoản trong cơ sở dữ liệu.";
                    return false;
                }

                tk.HoTen = hoTen.Trim();
                tk.MatKhau = matKhau;
                tk.GioiTinh = string.IsNullOrWhiteSpace(gioiTinh) ? null : gioiTinh.Trim();
                tk.NgaySinh = ngaySinh;
                tk.SDT = string.IsNullOrWhiteSpace(sdt) ? null : sdt.Trim();
                tk.Email = string.IsNullOrWhiteSpace(email) ? null : email.Trim();
                tk.DiaChi = string.IsNullOrWhiteSpace(diaChi) ? null : diaChi.Trim();

                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                thongBaoLoi = "Lỗi khi lưu thông tin: " + ex.Message;
                return false;
            }
        }
    }
}
