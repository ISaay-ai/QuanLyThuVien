using System;
using System.Linq;
using QuanLyThuVien.DAL;
using QuanLyThuVien.DAL.Models;

namespace QuanLyThuVien.BLL
{
    public class EmployeeMng
    {
        private readonly TaiKhoan TaiKhoa = new TaiKhoan();
        public List<TaiKhoan> LayDanhSach()
        {
            using var context = new AppDbContext();
            return context.TaiKhoans.ToList();
        }
        public bool DangKy(string tenDangNhap, string matKhau, string hoTen, string? gioiTinh = null, string? sdt = null, string? email = null, string? diaChi = null, string? vaiTro = "NhanVien")
        {
            if (string.IsNullOrWhiteSpace(tenDangNhap) ||
                string.IsNullOrWhiteSpace(matKhau) ||
                string.IsNullOrWhiteSpace(hoTen))
            {
                return false;
            }

            if (matKhau.Trim().Length < 6)
            {
                return false;
            }

            tenDangNhap = tenDangNhap.Trim();
            hoTen = hoTen.Trim();

            using var context = new AppDbContext();

            if (context.TaiKhoans.Any(x => x.TenDangNhap == tenDangNhap))
            {
                return false;
            }

            var taiKhoan = new TaiKhoan
            {
                TenDangNhap = tenDangNhap,
                MatKhau = matKhau,
                HoTen = hoTen,
                GioiTinh = gioiTinh,
                SDT = sdt,
                Email = email,
                DiaChi = diaChi,
                VaiTro = string.IsNullOrWhiteSpace(vaiTro) ? "NhanVien" : vaiTro
            };

            context.TaiKhoans.Add(taiKhoan);
            context.SaveChanges();
            return true;
        }

        public bool DangKy(TaiKhoan taiKhoan)
        {
            if (taiKhoan == null)
            {
                return false;
            }

            return DangKy(
                taiKhoan.TenDangNhap,
                taiKhoan.MatKhau,
                taiKhoan.HoTen,
                taiKhoan.GioiTinh,
                taiKhoan.SDT,
                taiKhoan.Email,
                taiKhoan.DiaChi,
                taiKhoan.VaiTro);
        }

        public bool DoiMatKhau(string tenDangNhap, string matKhauCu, string matKhauMoi)
        {
            if (string.IsNullOrWhiteSpace(tenDangNhap) ||
                string.IsNullOrWhiteSpace(matKhauCu) ||
                string.IsNullOrWhiteSpace(matKhauMoi))
            {
                return false;
            }

            if (matKhauMoi == matKhauCu)
            {
                return false;
            }

            using var context = new AppDbContext();
            var taiKhoan = context.TaiKhoans
                .SingleOrDefault(x => x.TenDangNhap == tenDangNhap);

            if (taiKhoan == null || taiKhoan.MatKhau != matKhauCu)
            {
                return false;
            }

            taiKhoan.MatKhau = matKhauMoi;
            context.SaveChanges();
            return true;
        }

        public bool XoaTaiKhoan(string tenDangNhap)
        {
            if (string.IsNullOrWhiteSpace(tenDangNhap))
            {
                return false;
            }

            using var context = new AppDbContext();
            var taiKhoan = context.TaiKhoans
                .SingleOrDefault(x => x.TenDangNhap == tenDangNhap.Trim());

            if (taiKhoan == null)
            {
                return false;
            }

            context.TaiKhoans.Remove(taiKhoan);
            context.SaveChanges();
            return true;
        }
    }
}

