using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuanLyThuVien.DAL;
using QuanLyThuVien.DAL.Models;

namespace QuanLyThuVien.BLL
{
    public class QuanLiSach
    {
        public void KhoiTaoDuLieuMau()
        {
            using var context = new AppDbContext();

            if (!context.TheLoais.Any())
            {
                context.TheLoais.AddRange(
                    new TheLoai { TenTheLoai = "Công nghệ thông tin" },
                    new TheLoai { TenTheLoai = "Khoa học kỹ thuật" },
                    new TheLoai { TenTheLoai = "Kinh tế - Quản trị" },
                    new TheLoai { TenTheLoai = "Văn học nghệ thuật" },
                    new TheLoai { TenTheLoai = "Ngoại ngữ" }
                );
                context.SaveChanges();
            }

            if (!context.TacGias.Any())
            {
                context.TacGias.AddRange(
                    new TacGia { TenTacGia = "Nguyễn Nhật Ánh" },
                    new TacGia { TenTacGia = "Robert C. Martin" },
                    new TacGia { TenTacGia = "Andrew S. Tanenbaum" },
                    new TacGia { TenTacGia = "Nam Cao" },
                    new TacGia { TenTacGia = "Dale Carnegie" }
                );
                context.SaveChanges();
            }

            if (!context.NhaXuatBans.Any())
            {
                context.NhaXuatBans.AddRange(
                    new NhaXuatBan { TenNXB = "NXB Giáo Dục" },
                    new NhaXuatBan { TenNXB = "NXB Trẻ" },
                    new NhaXuatBan { TenNXB = "NXB Kim Đồng" },
                    new NhaXuatBan { TenNXB = "NXB Thông tin và Truyền thông" }
                );
                context.SaveChanges();
            }

            if (!context.Sachs.Any())
            {
                var tlCNTT = context.TheLoais.FirstOrDefault(t => t.TenTheLoai == "Công nghệ thông tin") ?? context.TheLoais.First();
                var tlVanHoc = context.TheLoais.FirstOrDefault(t => t.TenTheLoai == "Văn học nghệ thuật") ?? context.TheLoais.First();

                var tgBob = context.TacGias.FirstOrDefault(t => t.TenTacGia == "Robert C. Martin") ?? context.TacGias.First();
                var tgAnh = context.TacGias.FirstOrDefault(t => t.TenTacGia == "Nguyễn Nhật Ánh") ?? context.TacGias.First();

                var nxbTT = context.NhaXuatBans.FirstOrDefault(n => n.TenNXB.Contains("Thông tin")) ?? context.NhaXuatBans.First();
                var nxbTre = context.NhaXuatBans.FirstOrDefault(n => n.TenNXB.Contains("Trẻ")) ?? context.NhaXuatBans.First();

                context.Sachs.AddRange(
                    new Sach
                    {
                        TenSach = "Clean Code - Mã Sạch",
                        MaTheLoai = tlCNTT.MaTheLoai,
                        MaTacGia = tgBob.MaTacGia,
                        MaNXB = nxbTT.MaNXB,
                        NamXB = 2021,
                        SoLuong = 15,
                        SoLuongCon = 15,
                        ViTri = "Kệ A1",
                        GiaBia = 180000
                    },
                    new Sach
                    {
                        TenSach = "Mắt Biếc",
                        MaTheLoai = tlVanHoc.MaTheLoai,
                        MaTacGia = tgAnh.MaTacGia,
                        MaNXB = nxbTre.MaNXB,
                        NamXB = 2019,
                        SoLuong = 20,
                        SoLuongCon = 20,
                        ViTri = "Kệ B2",
                        GiaBia = 110000
                    },
                    new Sach
                    {
                        TenSach = "Tôi Thấy Hoa Vàng Trên Cỏ Xanh",
                        MaTheLoai = tlVanHoc.MaTheLoai,
                        MaTacGia = tgAnh.MaTacGia,
                        MaNXB = nxbTre.MaNXB,
                        NamXB = 2020,
                        SoLuong = 12,
                        SoLuongCon = 12,
                        ViTri = "Kệ B2",
                        GiaBia = 125000
                    }
                );
                context.SaveChanges();
            }
        }

        public List<Sach> LayDanhSach()
        {
            using var context = new AppDbContext();
            return context.Sachs
                .Include(s => s.TheLoai)
                .Include(s => s.TacGia)
                .Include(s => s.NhaXuatBan)
                .OrderByDescending(s => s.MaSach)
                .ToList();
        }

        public List<Sach> TimKiem(string? tuKhoa)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                return LayDanhSach();
            }

            string keyword = tuKhoa.Trim().ToLower();

            using var context = new AppDbContext();
            return context.Sachs
                .Include(s => s.TheLoai)
                .Include(s => s.TacGia)
                .Include(s => s.NhaXuatBan)
                .Where(s => s.TenSach.ToLower().Contains(keyword) ||
                            (s.TheLoai != null && s.TheLoai.TenTheLoai.ToLower().Contains(keyword)) ||
                            (s.TacGia != null && s.TacGia.TenTacGia.ToLower().Contains(keyword)) ||
                            (s.NhaXuatBan != null && s.NhaXuatBan.TenNXB.ToLower().Contains(keyword)) ||
                            s.MaSach.ToString() == keyword)
                .OrderByDescending(s => s.MaSach)
                .ToList();
        }

        public bool Them(Sach sachMoi, out string thongBaoLoi)
        {
            thongBaoLoi = string.Empty;

            if (sachMoi == null)
            {
                thongBaoLoi = "Dữ liệu sách không hợp lệ.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(sachMoi.TenSach))
            {
                thongBaoLoi = "Tên sách không được để trống.";
                return false;
            }

            if (sachMoi.MaTheLoai <= 0)
            {
                thongBaoLoi = "Vui lòng chọn thể loại sách.";
                return false;
            }

            if (sachMoi.MaTacGia <= 0)
            {
                thongBaoLoi = "Vui lòng chọn tác giả.";
                return false;
            }

            if (sachMoi.MaNXB <= 0)
            {
                thongBaoLoi = "Vui lòng chọn nhà xuất bản.";
                return false;
            }

            int namHienTai = DateTime.Now.Year;
            if (sachMoi.NamXB < 1000 || sachMoi.NamXB > namHienTai + 1)
            {
                thongBaoLoi = $"Năm xuất bản không hợp lệ (từ 1000 đến {namHienTai + 1}).";
                return false;
            }

            if (sachMoi.SoLuong < 0)
            {
                thongBaoLoi = "Số lượng sách không được âm.";
                return false;
            }

            if (sachMoi.GiaBia < 0)
            {
                thongBaoLoi = "Giá bán không được âm.";
                return false;
            }

            try
            {
                using var context = new AppDbContext();

                sachMoi.TenSach = sachMoi.TenSach.Trim();
                sachMoi.SoLuongCon = sachMoi.SoLuong;
                if (string.IsNullOrWhiteSpace(sachMoi.ViTri))
                {
                    sachMoi.ViTri = "Kệ 1";
                }

                context.Sachs.Add(sachMoi);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                thongBaoLoi = "Lỗi khi lưu sách vào cơ sở dữ liệu: " + ex.Message;
                return false;
            }
        }

        public bool CapNhat(Sach sachCapNhat, out string thongBaoLoi)
        {
            thongBaoLoi = string.Empty;

            if (sachCapNhat == null || sachCapNhat.MaSach <= 0)
            {
                thongBaoLoi = "Mã sách không hợp lệ.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(sachCapNhat.TenSach))
            {
                thongBaoLoi = "Tên sách không được để trống.";
                return false;
            }

            if (sachCapNhat.MaTheLoai <= 0)
            {
                thongBaoLoi = "Vui lòng chọn thể loại sách.";
                return false;
            }

            if (sachCapNhat.MaTacGia <= 0)
            {
                thongBaoLoi = "Vui lòng chọn tác giả.";
                return false;
            }

            if (sachCapNhat.MaNXB <= 0)
            {
                thongBaoLoi = "Vui lòng chọn nhà xuất bản.";
                return false;
            }

            int namHienTai = DateTime.Now.Year;
            if (sachCapNhat.NamXB < 1000 || sachCapNhat.NamXB > namHienTai + 1)
            {
                thongBaoLoi = $"Năm xuất bản không hợp lệ (từ 1000 đến {namHienTai + 1}).";
                return false;
            }

            if (sachCapNhat.SoLuong < 0)
            {
                thongBaoLoi = "Số lượng sách không được âm.";
                return false;
            }

            if (sachCapNhat.GiaBia < 0)
            {
                thongBaoLoi = "Giá bán không được âm.";
                return false;
            }

            try
            {
                using var context = new AppDbContext();
                var sachDb = context.Sachs.FirstOrDefault(s => s.MaSach == sachCapNhat.MaSach);
                if (sachDb == null)
                {
                    thongBaoLoi = "Không tìm thấy sách cần cập nhật.";
                    return false;
                }

                int soLuongDangMuon = sachDb.SoLuong - sachDb.SoLuongCon;
                if (sachCapNhat.SoLuong < soLuongDangMuon)
                {
                    thongBaoLoi = $"Không thể giảm số lượng xuống {sachCapNhat.SoLuong} vì hiện đang có {soLuongDangMuon} cuốn đang được mượn!";
                    return false;
                }

                sachDb.TenSach = sachCapNhat.TenSach.Trim();
                sachDb.MaTheLoai = sachCapNhat.MaTheLoai;
                sachDb.MaTacGia = sachCapNhat.MaTacGia;
                sachDb.MaNXB = sachCapNhat.MaNXB;
                sachDb.NamXB = sachCapNhat.NamXB;
                sachDb.GiaBia = sachCapNhat.GiaBia;
                sachDb.SoLuongCon = sachCapNhat.SoLuong - soLuongDangMuon;
                sachDb.SoLuong = sachCapNhat.SoLuong;
                if (!string.IsNullOrWhiteSpace(sachCapNhat.ViTri))
                {
                    sachDb.ViTri = sachCapNhat.ViTri.Trim();
                }

                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                thongBaoLoi = "Lỗi khi cập nhật sách: " + ex.Message;
                return false;
            }
        }

        public bool Xoa(int maSach, out string thongBaoLoi)
        {
            thongBaoLoi = string.Empty;

            if (maSach <= 0)
            {
                thongBaoLoi = "Mã sách không hợp lệ.";
                return false;
            }

            try
            {
                using var context = new AppDbContext();
                var sachDb = context.Sachs.FirstOrDefault(s => s.MaSach == maSach);
                if (sachDb == null)
                {
                    thongBaoLoi = "Không tìm thấy sách cần xóa.";
                    return false;
                }

                bool daMuon = context.ChiTietPhieuMuons.Any(ct => ct.MaSach == maSach);
                if (daMuon)
                {
                    thongBaoLoi = "Không thể xóa sách này vì đã phát sinh lịch sử mượn trả!";
                    return false;
                }

                bool coPhat = context.PhieuPhats.Any(pp => pp.MaSach == maSach);
                if (coPhat)
                {
                    thongBaoLoi = "Không thể xóa sách này vì có phiếu phạt liên quan!";
                    return false;
                }

                context.Sachs.Remove(sachDb);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                thongBaoLoi = "Lỗi khi xóa sách: " + ex.Message;
                return false;
            }
        }

        // ================= Quản lý Thể Loại =================
        public List<TheLoai> LayDanhSachTheLoai()
        {
            using var context = new AppDbContext();
            return context.TheLoais.OrderBy(t => t.TenTheLoai).ToList();
        }

        public bool ThemTheLoai(TheLoai theLoai, out string thongBaoLoi)
        {
            thongBaoLoi = string.Empty;
            if (theLoai == null || string.IsNullOrWhiteSpace(theLoai.TenTheLoai))
            {
                thongBaoLoi = "Tên thể loại không được để trống.";
                return false;
            }

            theLoai.TenTheLoai = theLoai.TenTheLoai.Trim();

            try
            {
                using var context = new AppDbContext();
                if (context.TheLoais.Any(t => t.TenTheLoai.ToLower() == theLoai.TenTheLoai.ToLower()))
                {
                    thongBaoLoi = "Thể loại này đã tồn tại trong hệ thống.";
                    return false;
                }

                context.TheLoais.Add(theLoai);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                thongBaoLoi = "Lỗi khi thêm thể loại: " + ex.Message;
                return false;
            }
        }

        public bool XoaTheLoai(int maTheLoai, out string thongBaoLoi)
        {
            thongBaoLoi = string.Empty;
            if (maTheLoai <= 0)
            {
                thongBaoLoi = "Mã thể loại không hợp lệ.";
                return false;
            }

            try
            {
                using var context = new AppDbContext();
                var theLoai = context.TheLoais.FirstOrDefault(t => t.MaTheLoai == maTheLoai);
                if (theLoai == null)
                {
                    thongBaoLoi = "Không tìm thấy thể loại cần xóa.";
                    return false;
                }

                if (context.Sachs.Any(s => s.MaTheLoai == maTheLoai))
                {
                    thongBaoLoi = "Không thể xóa thể loại này vì hiện đang có sách thuộc thể loại này trong thư viện!";
                    return false;
                }

                context.TheLoais.Remove(theLoai);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                thongBaoLoi = "Lỗi khi xóa thể loại: " + ex.Message;
                return false;
            }
        }

        // ================= Quản lý Tác Giả =================
        public List<TacGia> LayDanhSachTacGia()
        {
            using var context = new AppDbContext();
            return context.TacGias.OrderBy(t => t.TenTacGia).ToList();
        }

        public bool ThemTacGia(TacGia tacGia, out string thongBaoLoi)
        {
            thongBaoLoi = string.Empty;
            if (tacGia == null || string.IsNullOrWhiteSpace(tacGia.TenTacGia))
            {
                thongBaoLoi = "Tên tác giả không được để trống.";
                return false;
            }

            tacGia.TenTacGia = tacGia.TenTacGia.Trim();

            try
            {
                using var context = new AppDbContext();
                if (context.TacGias.Any(t => t.TenTacGia.ToLower() == tacGia.TenTacGia.ToLower()))
                {
                    thongBaoLoi = "Tác giả này đã tồn tại trong hệ thống.";
                    return false;
                }

                context.TacGias.Add(tacGia);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                thongBaoLoi = "Lỗi khi thêm tác giả: " + ex.Message;
                return false;
            }
        }

        public bool XoaTacGia(int maTacGia, out string thongBaoLoi)
        {
            thongBaoLoi = string.Empty;
            if (maTacGia <= 0)
            {
                thongBaoLoi = "Mã tác giả không hợp lệ.";
                return false;
            }

            try
            {
                using var context = new AppDbContext();
                var tacGia = context.TacGias.FirstOrDefault(t => t.MaTacGia == maTacGia);
                if (tacGia == null)
                {
                    thongBaoLoi = "Không tìm thấy tác giả cần xóa.";
                    return false;
                }

                if (context.Sachs.Any(s => s.MaTacGia == maTacGia))
                {
                    thongBaoLoi = "Không thể xóa tác giả này vì hiện đang có sách của tác giả này trong thư viện!";
                    return false;
                }

                context.TacGias.Remove(tacGia);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                thongBaoLoi = "Lỗi khi xóa tác giả: " + ex.Message;
                return false;
            }
        }

        // ================= Quản lý Nhà Xuất Bản =================
        public List<NhaXuatBan> LayDanhSachNhaXuatBan()
        {
            using var context = new AppDbContext();
            return context.NhaXuatBans.OrderBy(n => n.TenNXB).ToList();
        }

        public bool ThemNhaXuatBan(NhaXuatBan nxb, out string thongBaoLoi)
        {
            thongBaoLoi = string.Empty;
            if (nxb == null || string.IsNullOrWhiteSpace(nxb.TenNXB))
            {
                thongBaoLoi = "Tên nhà xuất bản không được để trống.";
                return false;
            }

            nxb.TenNXB = nxb.TenNXB.Trim();

            try
            {
                using var context = new AppDbContext();
                if (context.NhaXuatBans.Any(n => n.TenNXB.ToLower() == nxb.TenNXB.ToLower()))
                {
                    thongBaoLoi = "Nhà xuất bản này đã tồn tại trong hệ thống.";
                    return false;
                }

                context.NhaXuatBans.Add(nxb);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                thongBaoLoi = "Lỗi khi thêm nhà xuất bản: " + ex.Message;
                return false;
            }
        }

        public bool XoaNhaXuatBan(int maNXB, out string thongBaoLoi)
        {
            thongBaoLoi = string.Empty;
            if (maNXB <= 0)
            {
                thongBaoLoi = "Mã nhà xuất bản không hợp lệ.";
                return false;
            }

            try
            {
                using var context = new AppDbContext();
                var nxb = context.NhaXuatBans.FirstOrDefault(n => n.MaNXB == maNXB);
                if (nxb == null)
                {
                    thongBaoLoi = "Không tìm thấy nhà xuất bản cần xóa.";
                    return false;
                }

                if (context.Sachs.Any(s => s.MaNXB == maNXB))
                {
                    thongBaoLoi = "Không thể xóa nhà xuất bản này vì hiện đang có sách thuộc nhà xuất bản này trong thư viện!";
                    return false;
                }

                context.NhaXuatBans.Remove(nxb);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                thongBaoLoi = "Lỗi khi xóa nhà xuất bản: " + ex.Message;
                return false;
            }
        }
    }
}
