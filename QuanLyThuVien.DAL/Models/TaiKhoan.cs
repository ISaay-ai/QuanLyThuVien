using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace QuanLyThuVien.DAL.Models
{
    public class TaiKhoan
    {
        [Key]
        public int MaTK { get; set; }

        public string TenDangNhap { get; set; } = string.Empty;
        public string MatKhauHash { get; set; } = string.Empty;

        public string HoTen { get; set; } = string.Empty;
        public string GioiTinh { get; set; } = string.Empty;
        public DateTime NgaySinh { get; set; }

        public string SDT { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string DiaChi { get; set; } = string.Empty;

        // Chỉ nhận Admin hoặc NhanVien
        public string VaiTro { get; set; } = "NhanVien";

        public bool TrangThai { get; set; } = true;
        public DateTime NgayTao { get; set; } = DateTime.Now;

        // Tài khoản có thể lập nhiều phiếu mượn và phiếu phạt
        public List<PhieuMuon> PhieuMuons { get; set; } = new List<PhieuMuon>();

        public List<PhieuPhat> PhieuPhat { get; set; } = new List<PhieuPhat>();
    }
}
