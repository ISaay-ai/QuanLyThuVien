using QuanLyThuVien.DAL;
using QuanLyThuVien.DAL.Models;

namespace QuanLyThuVien.BLL;

public class AuthenticationService
{
    public TaiKhoan? Authenticate(string tenDangNhap, string matKhau)
    {
        if (string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrEmpty(matKhau))
        {
            return null;
        }

        using var context = new AppDbContext();
        var taiKhoan = context.TaiKhoans.SingleOrDefault(x => x.TenDangNhap == tenDangNhap);
        if (taiKhoan is null || taiKhoan.MatKhau != matKhau)
        {
            return null;
        }

        return taiKhoan;
    }

    public bool ResetPassword(string tenDangNhap, string matKhauMoi)
    {
        if (string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrEmpty(matKhauMoi))
        {
            return false;
        }

        using var context = new AppDbContext();
        var taiKhoan = context.TaiKhoans.SingleOrDefault(x => x.TenDangNhap == tenDangNhap);
        if (taiKhoan is null)
        {
            return false;
        }

        taiKhoan.MatKhau = matKhauMoi;
        context.SaveChanges();
        return true;
    }
}