using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyThuVien.DAL;
using QuanLyThuVien.DAL.Models;

namespace QuanLyThuVien.BLL
{
    public class DocGiaMng
    {
        public List<DocGia> LayDanhSach()
        {
            using var context = new AppDbContext();
            return context.DocGias.ToList();
        }

        public bool ThemMoi(string maSV, string tenSV, string nganhHoc, string khoaHoc, string? soDienThoai = null)
        {
            // Ép kiểu MaSV từ string sang int vì CSDL lưu kiểu int
            if (string.IsNullOrWhiteSpace(maSV) || !int.TryParse(maSV.Trim(), out int id) || string.IsNullOrWhiteSpace(tenSV))
            {
                return false;
            }

            using var context = new AppDbContext();

            if (context.DocGias.Any(x => x.MaSV == id))
            {
                return false;
            }

            var docGia = new DocGia
            {
                MaSV = id,
                // Lưu ý: Thay đổi tên các thuộc tính bên dưới (HoTen, SDT,...) 
                // cho khớp hoàn toàn với file Model DocGia.cs trong dự án DAL của bạn
                HoTen = tenSV.Trim(),
                // NganhHoc = nganhHoc?.Trim(),
                // KhoaHoc = khoaHoc?.Trim(),
                // SDT = soDienThoai?.Trim()
            };

            context.DocGias.Add(docGia);
            context.SaveChanges();
            return true;
        }

        public bool CapNhat(string maSV, string tenSV, string nganhHoc, string khoaHoc, string? soDienThoai = null)
        {
            if (string.IsNullOrWhiteSpace(maSV) || !int.TryParse(maSV.Trim(), out int id))
            {
                return false;
            }

            using var context = new AppDbContext();
            var docGia = context.DocGias.SingleOrDefault(x => x.MaSV == id);

            if (docGia == null)
            {
                return false;
            }

            docGia.HoTen = tenSV?.Trim();
            // docGia.NganhHoc = nganhHoc?.Trim();
            // docGia.KhoaHoc = khoaHoc?.Trim();
            // docGia.SDT = soDienThoai?.Trim();

            context.SaveChanges();
            return true;
        }

        public bool Xoa(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV) || !int.TryParse(maSV.Trim(), out int id))
            {
                return false;
            }

            using var context = new AppDbContext();
            var docGia = context.DocGias.SingleOrDefault(x => x.MaSV == id);

            if (docGia == null)
            {
                return false;
            }

            context.DocGias.Remove(docGia);
            context.SaveChanges();
            return true;
        }
    }
}