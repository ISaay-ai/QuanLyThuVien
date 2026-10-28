using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace QuanLyThuVien.DAL.Models
{
    public class NhaXuatBan
    {
        [Key]
        public int MaNXB { get; set; }
        public string TenNXB { get; set; } = string.Empty;

        // 1 nhà xuất bản có nhiều sách
        public List<Sach> Sachs { get; set; } = new List<Sach>();
    }
}
