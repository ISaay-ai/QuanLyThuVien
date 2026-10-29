using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        // Các thuộc tính tiện ích để hiển thị trực tiếp lên DataGridView (không lưu vào DB)
        [NotMapped]
        public string TenTheLoai => TheLoai != null ? TheLoai.TenTheLoai : string.Empty;

        [NotMapped]
        public string TenTacGia => TacGia != null ? TacGia.TenTacGia : string.Empty;

        [NotMapped]
        public string TenNXB => NhaXuatBan != null ? NhaXuatBan.TenNXB : string.Empty;

        // 1 sách xuất hiện trong nhiều chi tiết mượn và phiếu phạt
        public List<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; } = new List<ChiTietPhieuMuon>();

        public List<PhieuPhat> PhieuPhats { get; set; } = new List<PhieuPhat>();
    }
}
