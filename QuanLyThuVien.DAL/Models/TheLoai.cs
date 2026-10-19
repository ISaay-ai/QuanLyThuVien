using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThuVien.DAL.Models
{
    public class TheLoai
    {
        public int MaTheLoai { get; set; }
        public string TenTheLoai { get; set; } = string.Empty;
        public string? MoTa { get; set; }

        // 1-N: Một thể loại có nhiều sách
        public List<Sachs> Sachs { get; set; } = new List<Sachs>();
    }
}
