using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace QuanLyThuVien.DAL.Models
{
    public class PhieuPhat
    {
        [Key]
        public int MaPP { get; set; }

        // Khóa ngoại
        public int MaPM { get; set; }
        public int MaSach { get; set; }
        public int MaQD { get; set; }
        public int MaTK { get; set; }

        public DateTime NgayLap { get; set; }
        public int SoNgayTre { get; set; }

        public decimal TienPhat { get; set; }
        public string LyDo { get; set; } = string.Empty;
        public string TrangThai { get; set; } = "ChuaThu";

        // Chưa thu tiền thì NgayThu có thể null
        public DateTime? NgayThu { get; set; }

        // Navigation
        public PhieuMuon PhieuMuon { get; set; } = null!;
        public Sach Sach { get; set; } = null!;
        public QuyDinhPhat QuyDinhPhat { get; set; } = null!;
        public TaiKhoan TaiKhoan { get; set; } = null!;
    }
}
