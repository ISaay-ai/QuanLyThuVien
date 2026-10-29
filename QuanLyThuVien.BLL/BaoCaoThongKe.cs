using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuanLyThuVien.DAL;
using QuanLyThuVien.DAL.Models;

namespace QuanLyThuVien.BLL
{
    public class BaoCaoThongKe
    {
        /// <summary>
        /// Đếm tổng số đầu sách có trong thư viện
        /// </summary>
        public int DemSoDauSach()
        {
            using var context = new AppDbContext();
            return context.Sachs.AsNoTracking().Count();
        }

        /// <summary>
        /// Đếm tổng số lượng bản sách (tính cả số lượng của từng đầu sách)
        /// </summary>
        public int DemTongSoLuongSach()
        {
            using var context = new AppDbContext();
            return context.Sachs.AsNoTracking().Sum(s => (int?)s.SoLuong) ?? 0;
        }

        /// <summary>
        /// Đếm tổng số thể loại / loại sách
        /// </summary>
        public int DemSoLoaiSach()
        {
            using var context = new AppDbContext();
            return context.TheLoais.AsNoTracking().Count();
        }

        /// <summary>
        /// Đếm tổng số tác giả
        /// </summary>
        public int DemSoTacGia()
        {
            using var context = new AppDbContext();
            return context.TacGias.AsNoTracking().Count();
        }

        /// <summary>
        /// Đếm tổng số nhà xuất bản
        /// </summary>
        public int DemSoNhaXuatBan()
        {
            using var context = new AppDbContext();
            return context.NhaXuatBans.AsNoTracking().Count();
        }

        /// <summary>
        /// Đếm tổng số độc giả
        /// </summary>
        public int DemSoDocGia()
        {
            using var context = new AppDbContext();
            return context.DocGias.AsNoTracking().Count();
        }

        /// <summary>
        /// Đếm tổng số cuốn sách hiện đang được mượn (chưa trả)
        /// </summary>
        public int DemSoSachDangMuon()
        {
            using var context = new AppDbContext();
            return context.ChiTietPhieuMuons
                .Include(ct => ct.PhieuMuon)
                .AsNoTracking()
                .Where(ct => ct.NgayTra == null && ct.PhieuMuon.TrangThai != "DaTra")
                .Sum(ct => ct.SoLuong > 0 ? (int?)ct.SoLuong : 1) ?? 0;
        }

        /// <summary>
        /// Lấy danh sách các bản ghi mượn sách đang được mượn (chưa trả)
        /// </summary>
        public List<ChiTietPhieuMuon> LayDanhSachDangMuon()
        {
            using var context = new AppDbContext();
            return context.ChiTietPhieuMuons
                .Include(ct => ct.PhieuMuon)
                    .ThenInclude(pm => pm.DocGia)
                .Include(ct => ct.PhieuMuon)
                    .ThenInclude(pm => pm.PhieuPhats)
                .Include(ct => ct.Sach)
                .Where(ct => ct.NgayTra == null && ct.PhieuMuon.TrangThai != "DaTra")
                .OrderByDescending(ct => ct.PhieuMuon.NgayMuon)
                .AsNoTracking()
                .ToList();
        }

        /// <summary>
        /// Lấy danh sách các bản ghi sách đã được trả
        /// </summary>
        public List<ChiTietPhieuMuon> LayDanhSachDaTra()
        {
            using var context = new AppDbContext();
            return context.ChiTietPhieuMuons
                .Include(ct => ct.PhieuMuon)
                    .ThenInclude(pm => pm.DocGia)
                .Include(ct => ct.PhieuMuon)
                    .ThenInclude(pm => pm.PhieuPhats)
                .Include(ct => ct.Sach)
                .Where(ct => ct.NgayTra != null || ct.PhieuMuon.TrangThai == "DaTra")
                .OrderByDescending(ct => ct.NgayTra ?? ct.PhieuMuon.HanTra)
                .AsNoTracking()
                .ToList();
        }

        /// <summary>
        /// Lấy danh sách các bản ghi mượn sách đã quá hạn trả (chưa trả và Hạn Trả < Hôm Nay)
        /// </summary>
        public List<ChiTietPhieuMuon> LayDanhSachQuaHan()
        {
            using var context = new AppDbContext();
            DateTime today = DateTime.Today;
            return context.ChiTietPhieuMuons
                .Include(ct => ct.PhieuMuon)
                    .ThenInclude(pm => pm.DocGia)
                .Include(ct => ct.PhieuMuon)
                    .ThenInclude(pm => pm.PhieuPhats)
                .Include(ct => ct.Sach)
                .Where(ct => ct.NgayTra == null 
                          && ct.PhieuMuon.TrangThai != "DaTra" 
                          && ct.PhieuMuon.HanTra < today)
                .OrderBy(ct => ct.PhieuMuon.HanTra)
                .AsNoTracking()
                .ToList();
        }
    }
}
