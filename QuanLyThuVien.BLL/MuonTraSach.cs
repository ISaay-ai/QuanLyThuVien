using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuanLyThuVien.DAL;
using QuanLyThuVien.DAL.Models;

namespace QuanLyThuVien.BLL
{
    public class MuonTraSach
    {
        private TaiKhoan LayHoacTaoTaiKhoan(AppDbContext context)
        {
            var tk = context.TaiKhoans.FirstOrDefault();
            if (tk == null)
            {
                tk = new TaiKhoan
                {
                    TenDangNhap = "admin",
                    MatKhau = "123456",
                    HoTen = "Quản trị viên",
                    VaiTro = "Admin"
                };
                context.TaiKhoans.Add(tk);
                context.SaveChanges();
            }
            return tk;
        }

        public List<ChiTietPhieuMuon> LayDanhSachChiTietMuonTra()
        {
            using var context = new AppDbContext();
            return context.ChiTietPhieuMuons
                .Include(x => x.PhieuMuon)
                    .ThenInclude(pm => pm.DocGia)
                .Include(x => x.PhieuMuon)
                    .ThenInclude(pm => pm.PhieuPhats)
                .Include(x => x.Sach)
                    .ThenInclude(s => s.TacGia)
                .AsNoTracking()
                .OrderByDescending(x => x.MaPM)
                .ToList();
        }

        public List<DocGia> LayDanhSachDocGia()
        {
            using var context = new AppDbContext();
            return context.DocGias
                .AsNoTracking()
                .OrderBy(x => x.MaSV)
                .ToList();
        }

        public List<Sach> LayDanhSachSach()
        {
            using var context = new AppDbContext();
            return context.Sachs
                .Include(x => x.TacGia)
                .Include(x => x.TheLoai)
                .AsNoTracking()
                .OrderBy(x => x.TenSach)
                .ToList();
        }

        public List<QuyDinhPhat> LayDanhSachQuyDinh()
        {
            using var context = new AppDbContext();
            try
            {
                // Tự động nâng cấp cột TranPhat lên decimal(18,2) nếu CSDL cũ đang là decimal(5,2)
                context.Database.ExecuteSqlRaw("ALTER TABLE QuyDinhPhat ALTER COLUMN TranPhat decimal(18,2) NOT NULL;");
            }
            catch
            {
                // Bỏ qua nếu cột đã được cập nhật hoặc không có quyền ALTER
            }

            try
            {
                var list = context.QuyDinhPhats.Where(x => x.ApDung).OrderBy(x => x.MaQD).ToList();
                if (list.Count == 0)
                {
                    var qd1 = new QuyDinhPhat { MaViPham = "TRE_HAN", TenQuyDinh = "Trả sách quá hạn (5.000đ/ngày)", KieuTinh = "TheoNgay", MucPhat = 5000, TranPhat = 0, ApDung = true };
                    var qd2 = new QuyDinhPhat { MaViPham = "HU_HONG", TenQuyDinh = "Làm rách / hư hỏng sách (30.000đ)", KieuTinh = "CoDinh", MucPhat = 30000, TranPhat = 0, ApDung = true };
                    var qd3 = new QuyDinhPhat { MaViPham = "MAT_SACH", TenQuyDinh = "Làm mất sách (100.000đ)", KieuTinh = "CoDinh", MucPhat = 100000, TranPhat = 0, ApDung = true };
                    context.QuyDinhPhats.AddRange(qd1, qd2, qd3);
                    context.SaveChanges();
                    list = context.QuyDinhPhats.Where(x => x.ApDung).OrderBy(x => x.MaQD).ToList();
                }
                return list;
            }
            catch
            {
                // Fallback nếu gặp sự cố kết nối CSDL để form không bao giờ bị crash
                return new List<QuyDinhPhat>
                {
                    new QuyDinhPhat { MaQD = 1, MaViPham = "TRE_HAN", TenQuyDinh = "Trả sách quá hạn (5.000đ/ngày)", KieuTinh = "TheoNgay", MucPhat = 5000, TranPhat = 0, ApDung = true },
                    new QuyDinhPhat { MaQD = 2, MaViPham = "HU_HONG", TenQuyDinh = "Làm rách / hư hỏng sách (30.000đ)", KieuTinh = "CoDinh", MucPhat = 30000, TranPhat = 0, ApDung = true },
                    new QuyDinhPhat { MaQD = 3, MaViPham = "MAT_SACH", TenQuyDinh = "Làm mất sách (100.000đ)", KieuTinh = "CoDinh", MucPhat = 100000, TranPhat = 0, ApDung = true }
                };
            }
        }

        public List<ChiTietPhieuMuon> TimKiem(string? tuKhoa, bool isTimTheoMaSV)
        {
            if (string.IsNullOrWhiteSpace(tuKhoa))
            {
                return LayDanhSachChiTietMuonTra();
            }

            string keyword = tuKhoa.Trim();
            using var context = new AppDbContext();

            var query = context.ChiTietPhieuMuons
                .Include(x => x.PhieuMuon)
                    .ThenInclude(pm => pm.DocGia)
                .Include(x => x.PhieuMuon)
                    .ThenInclude(pm => pm.PhieuPhats)
                .Include(x => x.Sach)
                    .ThenInclude(s => s.TacGia)
                .AsNoTracking();

            if (isTimTheoMaSV)
            {
                return query
                    .Where(x => x.PhieuMuon.MaSV.ToString().Contains(keyword) || (x.PhieuMuon.DocGia != null && x.PhieuMuon.DocGia.HoTen.Contains(keyword)))
                    .OrderByDescending(x => x.MaPM)
                    .ToList();
            }
            else
            {
                return query
                    .Where(x => x.MaSach.ToString().Contains(keyword) || (x.Sach != null && x.Sach.TenSach.Contains(keyword)))
                    .OrderByDescending(x => x.MaPM)
                    .ToList();
            }
        }

        public bool ThemPhieuMuon(int maSV, int maSach, DateTime ngayMuon, DateTime hanTra, out string thongBaoLoi)
        {
            thongBaoLoi = string.Empty;

            if (maSV <= 0)
            {
                thongBaoLoi = "Vui lòng chọn độc giả hợp lệ.";
                return false;
            }

            if (maSach <= 0)
            {
                thongBaoLoi = "Vui lòng chọn sách cần mượn.";
                return false;
            }

            if (hanTra < ngayMuon)
            {
                thongBaoLoi = "Hạn trả sách không thể trước ngày mượn.";
                return false;
            }

            try
            {
                using var context = new AppDbContext();

                var sach = context.Sachs.FirstOrDefault(x => x.MaSach == maSach);
                if (sach == null)
                {
                    thongBaoLoi = "Không tìm thấy thông tin sách trong thư viện.";
                    return false;
                }

                if (sach.SoLuongCon <= 0)
                {
                    thongBaoLoi = $"Sách '{sach.TenSach}' hiện đã hết (số lượng còn: 0), không thể cho mượn.";
                    return false;
                }

                var docGia = context.DocGias.FirstOrDefault(x => x.MaSV == maSV);
                if (docGia == null)
                {
                    thongBaoLoi = "Không tìm thấy thông tin độc giả.";
                    return false;
                }

                var taiKhoan = LayHoacTaoTaiKhoan(context);

                // Tạo phiếu mượn
                var phieuMuon = new PhieuMuon
                {
                    MaSV = maSV,
                    MaTK = taiKhoan.MaTK,
                    NgayMuon = ngayMuon,
                    HanTra = hanTra,
                    SoLanGiaHan = 0,
                    TrangThai = "DangMuon"
                };

                context.PhieuMuons.Add(phieuMuon);
                context.SaveChanges();

                // Tạo chi tiết phiếu mượn
                var chiTiet = new ChiTietPhieuMuon
                {
                    MaPM = phieuMuon.MaPM,
                    MaSach = maSach,
                    SoLuong = 1,
                    TinhTrangSach = "Bình thường"
                };

                context.ChiTietPhieuMuons.Add(chiTiet);

                // Cập nhật số lượng sách còn
                sach.SoLuongCon -= 1;

                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                thongBaoLoi = "Lỗi khi lập phiếu mượn: " + ex.Message;
                return false;
            }
        }

        public bool GiaHan(int maPM, DateTime ngayTraMoi, out string thongBaoLoi)
        {
            thongBaoLoi = string.Empty;

            if (maPM <= 0)
            {
                thongBaoLoi = "Mã phiếu mượn không hợp lệ.";
                return false;
            }

            try
            {
                using var context = new AppDbContext();
                var phieuMuon = context.PhieuMuons.FirstOrDefault(x => x.MaPM == maPM);
                if (phieuMuon == null)
                {
                    thongBaoLoi = "Không tìm thấy phiếu mượn.";
                    return false;
                }

                if (phieuMuon.TrangThai == "DaTra")
                {
                    thongBaoLoi = "Phiếu mượn này đã được trả, không thể gia hạn.";
                    return false;
                }

                if (phieuMuon.SoLanGiaHan >= 2)
                {
                    thongBaoLoi = "Phiếu mượn này đã được gia hạn 2 lần (tối đa theo quy định), không thể gia hạn thêm.";
                    return false;
                }

                if (ngayTraMoi <= phieuMuon.HanTra)
                {
                    thongBaoLoi = $"Ngày hẹn trả mới phải sau ngày hẹn trả hiện tại ({phieuMuon.HanTra:dd/MM/yyyy}).";
                    return false;
                }

                phieuMuon.HanTra = ngayTraMoi;
                phieuMuon.SoLanGiaHan += 1;

                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                thongBaoLoi = "Lỗi khi gia hạn phiếu mượn: " + ex.Message;
                return false;
            }
        }

        public bool TraSach(int maPM, int maSach, DateTime ngayTraThucTe, string tinhTrangSach, bool coViPham, int maQD, decimal tienPhat, string lyDoPhat, out string thongBaoLoi)
        {
            thongBaoLoi = string.Empty;

            try
            {
                using var context = new AppDbContext();

                var ctpm = context.ChiTietPhieuMuons
                    .Include(x => x.PhieuMuon)
                    .FirstOrDefault(x => x.MaPM == maPM && x.MaSach == maSach);

                if (ctpm == null)
                {
                    thongBaoLoi = "Không tìm thấy chi tiết phiếu mượn.";
                    return false;
                }

                if (ctpm.NgayTra != null)
                {
                    thongBaoLoi = "Sách này đã được trả trước đó rồi.";
                    return false;
                }

                ctpm.NgayTra = ngayTraThucTe;
                ctpm.TinhTrangSach = string.IsNullOrWhiteSpace(tinhTrangSach) ? "Bình thường" : tinhTrangSach.Trim();

                // Cập nhật tăng số lượng sách còn nếu không bị mất
                var sach = context.Sachs.FirstOrDefault(x => x.MaSach == maSach);
                if (sach != null && !ctpm.TinhTrangSach.ToLower().Contains("mất"))
                {
                    sach.SoLuongCon += 1;
                }

                // Kiểm tra xem tất cả các sách trong phiếu mượn đã trả hết chưa
                var tatCaChiTiet = context.ChiTietPhieuMuons.Where(x => x.MaPM == maPM).ToList();
                bool daTraHet = tatCaChiTiet.All(x => (x.MaSach == maSach ? ngayTraThucTe : x.NgayTra) != null);
                if (daTraHet && ctpm.PhieuMuon != null)
                {
                    ctpm.PhieuMuon.TrangThai = "DaTra";
                }

                // Xử lý vi phạm / phiếu phạt và ghi chú trả sách
                if (coViPham || !string.IsNullOrWhiteSpace(lyDoPhat))
                {
                    var taiKhoan = LayHoacTaoTaiKhoan(context);
                    int soNgayTre = ctpm.PhieuMuon != null ? Math.Max(0, (ngayTraThucTe.Date - ctpm.PhieuMuon.HanTra.Date).Days) : 0;

                    int qdId = maQD;
                    if (qdId <= 0)
                    {
                        var qdDau = context.QuyDinhPhats.FirstOrDefault(x => x.ApDung) ?? context.QuyDinhPhats.FirstOrDefault();
                        if (qdDau != null) qdId = qdDau.MaQD;
                    }

                    if (qdId > 0)
                    {
                        var phieuPhat = new PhieuPhat
                        {
                            MaPM = maPM,
                            MaSach = maSach,
                            MaQD = qdId,
                            MaTK = taiKhoan.MaTK,
                            NgayLap = DateTime.Today,
                            SoNgayTre = soNgayTre,
                            TienPhat = tienPhat,
                            LyDo = lyDoPhat ?? string.Empty,
                            TrangThai = tienPhat > 0 ? "ChuaThu" : "DaThu"
                        };

                        context.PhieuPhats.Add(phieuPhat);
                    }
                }

                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                thongBaoLoi = "Lỗi khi xử lý trả sách: " + ex.Message;
                return false;
            }
        }
    }
}
