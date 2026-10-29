using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyThuVien.DAL;
using QuanLyThuVien.DAL.Models;

namespace QuanLyThuVien.BLL
{
    public class QuanLiSach
    {
        public List<Sach> LayDanhSach()
        {
            using var context = new AppDbContext();
            return context.Sachs.ToList();
        }

        public bool ThemMoi(string maSach, string tenSach, string maTacGia, string maXB, string maLoai, int soTrang, decimal giaBan, int soLuong)
        {
            if (string.IsNullOrWhiteSpace(maSach) || !int.TryParse(maSach.Trim(), out int id) || string.IsNullOrWhiteSpace(tenSach))
            {
                return false;
            }

            using var context = new AppDbContext();
            if (context.Sachs.Any(x => x.MaSach == id))
            {
                return false;
            }

            var sach = new Sach
            {
                MaSach = id,
                TenSach = tenSach.Trim()
            };

            context.Sachs.Add(sach);
            context.SaveChanges();
            return true;
        }

        public bool CapNhat(string maSach, string tenSach, string maTacGia, string maXB, string maLoai, int soTrang, decimal giaBan, int soLuong)
        {
            if (string.IsNullOrWhiteSpace(maSach) || !int.TryParse(maSach.Trim(), out int id))
            {
                return false;
            }

            using var context = new AppDbContext();
            var sach = context.Sachs.SingleOrDefault(x => x.MaSach == id);
            if (sach == null)
            {
                return false;
            }

            sach.TenSach = tenSach?.Trim();

            context.SaveChanges();
            return true;
        }

        public bool Xoa(string maSach)
        {
            if (string.IsNullOrWhiteSpace(maSach) || !int.TryParse(maSach.Trim(), out int id))
            {
                return false;
            }

            using var context = new AppDbContext();
            var sach = context.Sachs.SingleOrDefault(x => x.MaSach == id);
            if (sach == null)
            {
                return false;
            }

            context.Sachs.Remove(sach);
            context.SaveChanges();
            return true;
        }
    }
}