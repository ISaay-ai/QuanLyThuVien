using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace QuanLyThuVien.DAL.Models
{
    public class ChiTietPhieuMuon
    {
        // PK ghép: MaPM + MaSach
        [Key]
        public int MaPM { get; set; }
        public int MaSach { get; set; }

        public int SoLuong { get; set; }

        // Chưa trả thì NgayTra có thể null
        public DateTime? NgayTra { get; set; }

        // Bình thường, Hỏng hoặc Mất
        public string TinhTrangSach { get; set; } = "Bình thường";

        // Navigation
        public PhieuMuon PhieuMuon { get; set; } = null!;
        public Sach Sach { get; set; } = null!;

        // Thuộc tính tiện ích hiển thị lên DataGridView
        [NotMapped]
        public int MaSV => PhieuMuon != null ? PhieuMuon.MaSV : 0;

        [NotMapped]
        public string TenDocGia => PhieuMuon?.DocGia != null ? PhieuMuon.DocGia.HoTen : string.Empty;

        [NotMapped]
        public string TenSach => Sach != null ? Sach.TenSach : string.Empty;

        [NotMapped]
        public DateTime NgayMuon => PhieuMuon != null ? PhieuMuon.NgayMuon : default;

        [NotMapped]
        public DateTime HanTra => PhieuMuon != null ? PhieuMuon.HanTra : default;

        [NotMapped]
        public string TrangThai => PhieuMuon != null ? PhieuMuon.TrangThai : string.Empty;

        [NotMapped]
        public int SoLanGiaHan => PhieuMuon != null ? PhieuMuon.SoLanGiaHan : 0;

        [NotMapped]
        public int SoNgayQuaHan
        {
            get
            {
                if (NgayTra != null || HanTra == default) return 0;
                int soNgay = (DateTime.Today - HanTra.Date).Days;
                return soNgay > 0 ? soNgay : 0;
            }
        }

        [NotMapped]
        public string GhiChu
        {
            get
            {
                if (PhieuMuon?.PhieuPhats != null && PhieuMuon.PhieuPhats.Count > 0)
                {
                    var pp = PhieuMuon.PhieuPhats
                        .OrderByDescending(p => p.MaPP)
                        .FirstOrDefault(p => p.MaSach == this.MaSach);
                    if (pp != null && !string.IsNullOrWhiteSpace(pp.LyDo))
                    {
                        return pp.LyDo;
                    }
                }
                return _ghiChu ?? string.Empty;
            }
            set => _ghiChu = value;
        }
        private string? _ghiChu;
    }
}
