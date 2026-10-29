using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuanLyThuVien.DAL;
using QuanLyThuVien.DAL.Models;

namespace QuanLyThuVien.BLL
{
    public class DocGiaMng
    {
        public List<DocGia> LayDanhSach()
        {
            using var context = new AppDbContext();
            return context.DocGias
                .Include(x => x.Nganh)
                .AsNoTracking()
                .OrderBy(x => x.MaSV)
                .ToList();
        }

        public List<Nganh> LayDanhSachNganh()
        {
            using var context = new AppDbContext();
            return context.Nganhs
                .AsNoTracking()
                .OrderBy(x => x.TenNganh)
                .ToList();
        }

        public List<DocGia> TimKiem(string? tuKhoa, bool theoMaSV)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                return LayDanhSach();
            }

            string keyword = tuKhoa.Trim();
            using var context = new AppDbContext();

            if (theoMaSV)
            {
                return context.DocGias
                    .Include(x => x.Nganh)
                    .AsNoTracking()
                    .Where(x => x.MaSV.ToString().Contains(keyword))
                    .OrderBy(x => x.MaSV)
                    .ToList();
            }
            else
            {
                return context.DocGias
                    .Include(x => x.Nganh)
                    .AsNoTracking()
                    .Where(x => x.HoTen.Contains(keyword))
                    .OrderBy(x => x.MaSV)
                    .ToList();
            }
        }

        public bool ThemMoi(DocGia docGia, string tenNganh, out string thongBaoLoi)
        {
            thongBaoLoi = string.Empty;

            if (docGia == null)
            {
                thongBaoLoi = "Dữ liệu độc giả không hợp lệ.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(docGia.HoTen))
            {
                thongBaoLoi = "Họ và tên độc giả không được để trống.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(tenNganh))
            {
                thongBaoLoi = "Vui lòng chọn hoặc nhập ngành học.";
                return false;
            }

            try
            {
                using var context = new AppDbContext();

                // Tìm hoặc tạo mới ngành học
                string normalizedNganh = tenNganh.Trim();
                var nganh = context.Nganhs.FirstOrDefault(x => x.TenNganh.ToLower() == normalizedNganh.ToLower());
                if (nganh == null)
                {
                    nganh = new Nganh { TenNganh = normalizedNganh };
                    context.Nganhs.Add(nganh);
                    context.SaveChanges();
                }

                docGia.MaNganh = nganh.MaNganh;
                docGia.HoTen = docGia.HoTen.Trim();
                docGia.Khoa = (docGia.Khoa ?? string.Empty).Trim();
                docGia.SDT = (docGia.SDT ?? string.Empty).Trim();
                docGia.Email = (docGia.Email ?? string.Empty).Trim();

                if (docGia.NgayLapThe == default)
                {
                    docGia.NgayLapThe = DateTime.Today;
                }
                if (docGia.NgayHetHan == default)
                {
                    docGia.NgayHetHan = DateTime.Today.AddYears(4);
                }

                // CSDL MaSV là IDENTITY tự tăng, không gán MaSV thủ công
                docGia.MaSV = 0;

                context.DocGias.Add(docGia);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                thongBaoLoi = "Lỗi khi thêm độc giả: " + ex.Message;
                return false;
            }
        }

        public bool CapNhat(DocGia docGia, string tenNganh, out string thongBaoLoi)
        {
            thongBaoLoi = string.Empty;

            if (docGia == null || docGia.MaSV <= 0)
            {
                thongBaoLoi = "Mã độc giả không hợp lệ.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(docGia.HoTen))
            {
                thongBaoLoi = "Họ và tên độc giả không được để trống.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(tenNganh))
            {
                thongBaoLoi = "Vui lòng chọn hoặc nhập ngành học.";
                return false;
            }

            try
            {
                using var context = new AppDbContext();
                var existing = context.DocGias.FirstOrDefault(x => x.MaSV == docGia.MaSV);
                if (existing == null)
                {
                    thongBaoLoi = "Không tìm thấy thông tin độc giả cần cập nhật.";
                    return false;
                }

                // Tìm hoặc tạo mới ngành học
                string normalizedNganh = tenNganh.Trim();
                var nganh = context.Nganhs.FirstOrDefault(x => x.TenNganh.ToLower() == normalizedNganh.ToLower());
                if (nganh == null)
                {
                    nganh = new Nganh { TenNganh = normalizedNganh };
                    context.Nganhs.Add(nganh);
                    context.SaveChanges();
                }

                existing.HoTen = docGia.HoTen.Trim();
                existing.MaNganh = nganh.MaNganh;
                existing.Khoa = (docGia.Khoa ?? string.Empty).Trim();
                existing.SDT = (docGia.SDT ?? string.Empty).Trim();
                if (!string.IsNullOrWhiteSpace(docGia.Email))
                {
                    existing.Email = docGia.Email.Trim();
                }
                if (docGia.NgayHetHan != default)
                {
                    existing.NgayHetHan = docGia.NgayHetHan;
                }

                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                thongBaoLoi = "Lỗi khi cập nhật độc giả: " + ex.Message;
                return false;
            }
        }

        public bool Xoa(int maSV, out string thongBaoLoi)
        {
            thongBaoLoi = string.Empty;

            if (maSV <= 0)
            {
                thongBaoLoi = "Mã độc giả không hợp lệ.";
                return false;
            }

            try
            {
                using var context = new AppDbContext();

                // Kiểm tra ràng buộc toàn vẹn dữ liệu: có phiếu mượn sách hay không
                bool coPhieuMuon = context.PhieuMuons.Any(x => x.MaSV == maSV);
                if (coPhieuMuon)
                {
                    thongBaoLoi = "Không thể xoá độc giả này vì đang có dữ liệu phiếu mượn sách trong hệ thống!";
                    return false;
                }

                var existing = context.DocGias.FirstOrDefault(x => x.MaSV == maSV);
                if (existing == null)
                {
                    thongBaoLoi = "Không tìm thấy thông tin độc giả cần xoá.";
                    return false;
                }

                context.DocGias.Remove(existing);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                thongBaoLoi = "Lỗi khi xoá độc giả: " + ex.Message;
                return false;
            }
        }
    }
}
