using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace QuanLyThuVien.DAL.Models
{
    public class TaiKhoan
    {
        [Key]
        public int MaTK { get; set; }

        [Required]
        public string TenDangNhap { get; set; } = string.Empty;

        [Required]
        public string MatKhau { get; set; } = string.Empty;

        [Required]
        public string HoTen { get; set; } = string.Empty;

        public string? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }

        public string? SDT { get; set; }
        public string? Email { get; set; }
        public string? DiaChi { get; set; }

        public string? VaiTro { get; set; }

        // Tài khoản có thể lập nhiều phiếu mượn và phiếu phạt
        public List<PhieuMuon> PhieuMuons { get; set; } = new List<PhieuMuon>();

        public List<PhieuPhat> PhieuPhat { get; set; } = new List<PhieuPhat>();
    }
}
