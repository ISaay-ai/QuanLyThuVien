using System;
using System.ComponentModel.DataAnnotations;

namespace QuanLyThuVien.DAL.Models
{
    public class ChiTietPhieuMuon
    {
        // PK ghép: MaPM + MaSach
        [Key]
        public int MaPM { get; set; }
        public int MaSach { get; set; }

        public int SoLuong { get; set; }

        // Chưa trả thì NgayTra có thể null
        public DateTime? NgayTra { get; set; }

        // Bình thường, Hỏng hoặc Mất
        public string TinhTrangSach { get; set; } = "Bình thường";

        // Navigation
        public PhieuMuon PhieuMuon { get; set; } = null!;
        public Sach Sach { get; set; } = null!;
    }
}
