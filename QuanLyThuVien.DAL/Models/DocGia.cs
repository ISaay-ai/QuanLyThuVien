using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace QuanLyThuVien.DAL.Models
{
    public class DocGia
    {
        [Key]
        public int MaDG { get; set; }

        // Mã sinh viên phải duy nhất
        public string MaSV { get; set; } = string.Empty;

        public string HoTen { get; set; } = string.Empty;

        // Khóa ngoại
        public int MaNganh { get; set; }
        public Nganh Nganh { get; set; } = null!;

        public string Khoa { get; set; } = string.Empty;
        public string SDT { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public DateTime NgayLapThe { get; set; }
        public DateTime NgayHetHan { get; set; }

        // 1 độc giả có nhiều phiếu mượn
        public List<PhieuMuon> PhieuMuons { get; set; } = new List<PhieuMuon>();
    }
}
