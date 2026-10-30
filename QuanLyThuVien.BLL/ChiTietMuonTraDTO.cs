using System;
using System.Linq;
using QuanLyThuVien.DAL.Models;

namespace QuanLyThuVien.BLL
{

    /// DTO hiển thị thông tin chi tiết mượn trả lên DataGridView.

    public class ChiTietMuonTraDTO
    {
        public int MaPM { get; set; }
        public int MaSach { get; set; }
        public int SoLuong { get; set; }
        public DateTime? NgayTra { get; set; }
        public string TinhTrangSach { get; set; } = "Bình thường";

        // Thông tin từ PhieuMuon
        public int MaSV { get; set; }
        public string TenDocGia { get; set; } = string.Empty;
        public DateTime NgayMuon { get; set; }
        public DateTime HanTra { get; set; }
        public string TrangThai { get; set; } = string.Empty;
        public int SoLanGiaHan { get; set; }

        // Thông tin từ Sach
        public string TenSach { get; set; } = string.Empty;


        //Tính số ngày quá hạn: chỉ tính khi chưa trả và đã quá hạn.
        public int SoNgayQuaHan
        {
            get
            {
                if (NgayTra != null || HanTra == default) return 0;
                int soNgay = (DateTime.Today - HanTra.Date).Days;
                return soNgay > 0 ? soNgay : 0;
            }
        }

        /// Ghi chú: ưu tiên lấy lý do phạt từ PhieuPhat, nếu không có thì dùng ghi chú tùy chỉnh.

        public string GhiChu
        {
            get => _ghiChu ?? string.Empty;
            set => _ghiChu = value;
        }
        private string? _ghiChu;




        /// Tạo DTO từ entity ChiTietPhieuMuon, ánh xạ toàn bộ thuộc tính hiển thị
        /// và tính toán GhiChu từ PhieuPhat.

        public static ChiTietMuonTraDTO FromEntity(ChiTietPhieuMuon entity)
        {
            var dto = new ChiTietMuonTraDTO
            {
                MaPM = entity.MaPM,
                MaSach = entity.MaSach,
                SoLuong = entity.SoLuong,
                NgayTra = entity.NgayTra,
                TinhTrangSach = entity.TinhTrangSach,

                MaSV = entity.PhieuMuon?.MaSV ?? 0,
                TenDocGia = entity.PhieuMuon?.DocGia?.HoTen ?? string.Empty,
                NgayMuon = entity.PhieuMuon?.NgayMuon ?? default,
                HanTra = entity.PhieuMuon?.HanTra ?? default,
                TrangThai = entity.PhieuMuon?.TrangThai ?? string.Empty,
                SoLanGiaHan = entity.PhieuMuon?.SoLanGiaHan ?? 0,

                TenSach = entity.Sach?.TenSach ?? string.Empty,
            };

            // Logic GhiChu: lấy lý do phạt mới nhất cho sách này
            if (entity.PhieuMuon?.PhieuPhats != null && entity.PhieuMuon.PhieuPhats.Count > 0)
            {
                var pp = entity.PhieuMuon.PhieuPhats
                    .OrderByDescending(p => p.MaPP)
                    .FirstOrDefault(p => p.MaSach == entity.MaSach);
                if (pp != null && !string.IsNullOrWhiteSpace(pp.LyDo))
                {
                    dto.GhiChu = pp.LyDo;
                }
            }

            return dto;
        }
    }
}
