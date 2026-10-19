using QuanLyThuVien.DAL;
using QuanLyThuVien.DAL.Models;

namespace QuanLyThuVien.BLL;

public class AuthenticationService
{
    public TaiKhoan? Authenticate(string identifier, string matKhau)
    {
        if (string.IsNullOrWhiteSpace(identifier) || string.IsNullOrEmpty(matKhau))
        {
            return null;
        }

        using var context = new AppDbContext();
        var taiKhoan = context.TaiKhoans.SingleOrDefault(x => x.TenDangNhap == identifier)
            ?? context.TaiKhoans.SingleOrDefault(x => x.MaNV == identifier);
        if (taiKhoan is null || taiKhoan.MatKhau != matKhau)
        {
            return null;
        }

        return taiKhoan;
    }

    public bool ResetPassword(string maNhanVien, string matKhauMoi)
    {
        if (string.IsNullOrWhiteSpace(maNhanVien) || string.IsNullOrEmpty(matKhauMoi))
        {
            return false;
        }

        using var context = new AppDbContext();
        var taiKhoan = context.TaiKhoans.SingleOrDefault(x => x.MaNV == maNhanVien);
        if (taiKhoan is null)
        {
            return false;
        }

        taiKhoan.MatKhau = matKhauMoi;
        context.SaveChanges();
        return true;
    }
}