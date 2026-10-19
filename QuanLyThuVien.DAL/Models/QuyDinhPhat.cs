using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace QuanLyThuVien.DAL.Models
{
    public class QuyDinhPhat
    {
        [Key]
        public int MaQD { get; set; }

        public string MaViPham { get; set; } = string.Empty;
        public string TenQuyDinh { get; set; } = string.Empty;
        public string KieuTinh { get; set; } = string.Empty;

        public decimal MucPhat { get; set; }
        public decimal TranPhat { get; set; }

        public bool ApDung { get; set; } = true;

        // Một quy định có thể được áp dụng cho nhiều phiếu phạt
        public List<PhieuPhat> PhieuPhats { get; set; } = new List<PhieuPhat>();
    }
}
