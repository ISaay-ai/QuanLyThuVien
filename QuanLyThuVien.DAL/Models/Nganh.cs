using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace QuanLyThuVien.DAL.Models
{
    public class Nganh
    {
        [Key]
        public int MaNganh { get; set; }
        public string TenNganh { get; set; } = string.Empty;

        // 1 ngành có nhiều độc giả
        public List<DocGia> DocGias { get; set; } = new List<DocGia>();
    }
}
