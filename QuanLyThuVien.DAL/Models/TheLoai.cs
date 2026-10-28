using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace QuanLyThuVien.DAL.Models
{
    public class TheLoai
    {
        [Key]
        public int MaTheLoai { get; set; }
        public string TenTheLoai { get; set; } = string.Empty;

        // 1 thể loại có nhiều sách
        public List<Sach> Sachs { get; set; } = new List<Sach>();

    }
}
