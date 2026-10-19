using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuanLyThuVien.DAL.Models
{
    public class TacGia
    {
        [Key]
        public int MaTacGia { get; set; }
        public string TenTacGia { get; set; } = string.Empty;

        // 1 tác giả có nhiều sách theo sơ đồ hiện tại
        public List<Sach> Sachs { get; set; } = new List<Sach>();
    }
}
