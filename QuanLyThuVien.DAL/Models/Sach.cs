using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace QuanLyThuVien.DAL.Models
{
    public class Sach
    {
        [Key]
        public int MaSach { get; set; }

        public string TenSach { get; set; } = string.Empty;

        // Khóa ngoại
        public int MaTheLoai { get; set; }
        public int MaTacGia { get; set; }
        public int MaNXB { get; set; }

        public int NamXB { get; set; }
        public int SoLuong { get; set; }
        public int SoLuongCon { get; set; }

        public string ViTri { get; set; } = string.Empty;
        public decimal GiaBia { get; set; }
        public string? AnhBia { get; set; }

        // Navigation tới các bảng cha
        public TheLoai TheLoai { get; set; } = null!;
        public TacGia TacGia { get; set; } = null!;
        public NhaXuatBan NhaXuatBan { get; set; } = null!;

        // 1 sách xuất hiện trong nhiều chi tiết mượn và phiếu phạt
        public List<ChiTietPhieuMuon> ChiTietPhieuMuons
        { get; set; } = new List<ChiTietPhieuMuon>();

        public List<PhieuPhat> PhieuPhats
        { get; set; } = new List<PhieuPhat>();
    }
}
