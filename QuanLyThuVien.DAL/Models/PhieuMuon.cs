using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace QuanLyThuVien.DAL.Models
{
    public class PhieuMuon
    {
        [Key]
        public int MaPM { get; set; }

        // Khóa ngoại
        public int MaDG { get; set; }
        public int MaTK { get; set; }

        public DateTime NgayMuon { get; set; }
        public DateTime HanTra { get; set; }

        public int SoLanGiaHan { get; set; }

        public string TrangThai { get; set; } = "DangMuon";

        public DocGia DocGia { get; set; } = null!;
        public TaiKhoan TaiKhoan { get; set; } = null!;

        // Bảng trung gian cho quan hệ N-N giữa Phiếu mượn và Sách
        public List<ChiTietPhieuMuon> ChiTietPhieuMuons  { get; set; } = new List<ChiTietPhieuMuon>();

        // 1 phiếu mượn có thể phát sinh nhiều khoản phạt
        public List<PhieuPhat> PhieuPhats { get; set; } = new List<PhieuPhat>();
    }
}
