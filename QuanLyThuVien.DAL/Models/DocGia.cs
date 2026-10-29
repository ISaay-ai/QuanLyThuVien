using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyThuVien.DAL.Models
{
    public class DocGia
    {
        [Key]
        public int MaSV { get; set; }

        public string HoTen { get; set; } = string.Empty;

        // Khóa ngoại
        public int MaNganh { get; set; }
        public Nganh Nganh { get; set; } = null!;

        public string Khoa { get; set; } = string.Empty;
        public string SDT { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public DateTime NgayLapThe { get; set; }
        public DateTime NgayHetHan { get; set; }

        // Thuộc tính tiện ích để hiển thị trực tiếp lên DataGridView (không lưu vào DB)
        [NotMapped]
        public string TenNganh => Nganh != null ? Nganh.TenNganh : string.Empty;

        // 1 độc giả có nhiều phiếu mượn
        public List<PhieuMuon> PhieuMuons { get; set; } = new List<PhieuMuon>();
    }
}
