using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using QuanLyThuVien.DAL;
using QuanLyThuVien.DAL.Models;

namespace QuanLyThuVien.BLL
{
    public class MuonTraSach
    {
        // Cấu hình SMTP Gmail
        private const string SmtpServer = "smtp.gmail.com";
        private const int SmtpPort = 587;
        private const string SenderEmail = "dmgbepj@gmail.com";
        private const string AppPassword = "rcty sinv aerv mhjp"; // Thay 16 ký tự Mật khẩu ứng dụng Gmail vào đây

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

        #region TÍNH NĂNG TỰ ĐỘNG GỬI EMAIL NHẮC NỢ SÁCH (MAILKIT)

        /// <summary>
        /// Quét CSDL tìm các độc giả còn đúng 3 ngày nữa là đến hạn trả sách để gửi Gmail tự động.
        /// Được gọi từ project ConsoleWorker (Task Scheduler) hoặc chạy ngầm trên WinForms.
        /// </summary>
        public async Task KiemTraVaGuiMailSapHetHanAsync()
        {
            using var context = new AppDbContext();
            DateTime ngayCanThongBao = DateTime.Today.AddDays(3);

            // Truy vấn các sách mượn chưa trả và có hạn trả đúng tròn 3 ngày tới
            var danhSachSapHetHan = await context.ChiTietPhieuMuons
                .Include(x => x.PhieuMuon)
                    .ThenInclude(pm => pm.DocGia)
                .Include(x => x.Sach)
                .Where(x => x.NgayTra == null
                         && x.PhieuMuon.TrangThai != "DaTra"
                         && x.PhieuMuon.HanTra.Date == ngayCanThongBao)
                .AsNoTracking()
                .ToListAsync();

            foreach (var item in danhSachSapHetHan)
            {
                var docGia = item.PhieuMuon?.DocGia;
                var sach = item.Sach;

                if (docGia != null && !string.IsNullOrWhiteSpace(docGia.Email) && sach != null)
                {
                    await GuiGmailMailKitAsync(
                        docGia.Email,
                        docGia.HoTen,
                        docGia.MaSV,
                        sach.TenSach,
                        item.PhieuMuon.NgayMuon,
                        item.PhieuMuon.HanTra
                    );
                }
            }
        }

        private async Task GuiGmailMailKitAsync(string emailNguoiNhan, string tenDocGia, int maSV, string tenSach, DateTime ngayMuon, DateTime hanTra)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Thư Viện GenLib", SenderEmail));
                message.To.Add(MailboxAddress.Parse(emailNguoiNhan));
                message.Subject = $"[GenLib] Sách '{tenSach}' sắp đến hạn trả ({hanTra:dd/MM/yyyy})";

                var bodyBuilder = new BodyBuilder
                {
                    HtmlBody = TaoNoiDungHtmlEmail(tenDocGia, maSV, tenSach, ngayMuon, hanTra)
                };
                message.Body = bodyBuilder.ToMessageBody();

                using var client = new SmtpClient();
                await client.ConnectAsync(SmtpServer, SmtpPort, SecureSocketOptions.StartTls);
                await client.AuthenticateAsync(SenderEmail, AppPassword);
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Lỗi gửi mail đến {emailNguoiNhan}]: {ex.Message}");
            }
        }

        private string TaoNoiDungHtmlEmail(string tenDocGia, int maSV, string tenSach, DateTime ngayMuon, DateTime hanTra)
        {
            return $@"
            <!DOCTYPE html>
            <html>
            <head>
                <meta charset='utf-8'>
                <style>
                    body {{ font-family: Arial, sans-serif; line-height: 1.6; color: #333333; background-color: #f4f4f4; margin: 0; padding: 20px; }}
                    .container {{ max-width: 600px; margin: 0 auto; background: #ffffff; border-radius: 8px; overflow: hidden; box-shadow: 0 2px 4px rgba(0,0,0,0.1); }}
                    .header {{ background-color: #0056b3; color: #ffffff; padding: 20px; text-align: center; }}
                    .header h2 {{ margin: 0; font-size: 20px; }}
                    .content {{ padding: 25px; }}
                    .info-box {{ background-color: #f8f9fa; border-left: 4px solid #0056b3; padding: 15px; margin: 20px 0; border-radius: 4px; }}
                    .info-table {{ width: 100%; border-collapse: collapse; }}
                    .info-table td {{ padding: 8px 0; border-bottom: 1px dashed #e9ecef; }}
                    .info-table td:first-child {{ font-weight: bold; color: #495057; width: 35%; }}
                    .warning {{ color: #d9534f; font-weight: bold; }}
                    .footer {{ background-color: #e9ecef; padding: 15px; text-align: center; font-size: 12px; color: #6c757d; }}
                </style>
            </head>
            <body>
                <div class='container'>
                    <div class='header'>
                        <h2>THƯ VIỆN GenLib - THÔNG BÁO TỰ ĐỘNG</h2>
                    </div>
                    <div class='content'>
                        <p>Kính gửi độc giả <b>{tenDocGia}</b> (MSSV: <b>{maSV}</b>),</p>
                        <p>Thư viện GenLib xin thông báo: Cuốn sách bạn mượn tại thư viện sắp đến hạn hoàn trả. Chi tiết như sau:</p>
                        
                        <div class='info-box'>
                            <table class='info-table'>
                                <tr>
                                    <td>Tên đầu sách:</td>
                                    <td><b style='color: #0056b3;'>{tenSach}</b></td>
                                </tr>
                                <tr>
                                    <td>Ngày mượn sách:</td>
                                    <td>{ngayMuon:dd/MM/yyyy}</td>
                                </tr>
                                <tr>
                                    <td>Hạn trả sách:</td>
                                    <td><b class='warning'>{hanTra:dd/MM/yyyy}</b> (Còn 3 ngày nữa)</td>
                                </tr>
                            </table>
                        </div>

                        <p><b>📌 Hướng dẫn dành cho bạn:</b></p>
                        <ul>
                            <li><b>Hoàn trả sách:</b> Vui lòng mang sách đến quầy thủ thư trước hoặc trong ngày <b>{hanTra:dd/MM/yyyy}</b>.</li>
                            <li><b>Gia hạn sách:</b> Nếu chưa quá 2 lần gia hạn, bạn có thể thực hiện gia hạn trực tiếp tại bàn thủ thư.</li>
                        </ul>

                        <p class='warning'>⚠️ Lưu ý phí phạt quá hạn:</p>
                        <p>Theo Quy định Thư viện, các trường hợp trả sách quá hạn sẽ áp dụng mức phí phạt <b>5.000 VNĐ / ngày trễ</b>.</p>
                    </div>
                    
                    <div class='footer'>
                        <p><b>BAN QUẢN LÝ THƯ VIỆN GenLib</b></p>
                        <p><i>Email này được gửi tự động từ hệ thống. Vui lòng không trả lời (reply) trực tiếp.</i></p>
                    </div>
                </div>
            </body>
            </html>";
        }

        #endregion

        /// Lấy toàn bộ danh sách chi tiết mượn trả, trả về DTO (đã chuyển logic hiển thị sang BLL).
        public List<ChiTietMuonTraDTO> LayDanhSachChiTietMuonTra()
        {
            using var context = new AppDbContext();
            var entities = context.ChiTietPhieuMuons
                .Include(x => x.PhieuMuon)
                    .ThenInclude(pm => pm.DocGia)
                .Include(x => x.PhieuMuon)
                    .ThenInclude(pm => pm.PhieuPhats)
                .Include(x => x.Sach)
                    .ThenInclude(s => s.TacGia)
                .AsNoTracking()
                .OrderByDescending(x => x.MaPM)
                .ToList();

            return entities.Select(ChiTietMuonTraDTO.FromEntity).ToList();
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

        /// Tìm kiếm chi tiết mượn trả, trả về DTO.
        public List<ChiTietMuonTraDTO> TimKiem(string? tuKhoa, bool isTimTheoMaSV)
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

            List<ChiTietPhieuMuon> entities;

            if (isTimTheoMaSV)
            {
                entities = query
                    .Where(x => x.PhieuMuon.MaSV.ToString().Contains(keyword) || (x.PhieuMuon.DocGia != null && x.PhieuMuon.DocGia.HoTen.Contains(keyword)))
                    .OrderByDescending(x => x.MaPM)
                    .ToList();
            }
            else
            {
                entities = query
                    .Where(x => x.MaSach.ToString().Contains(keyword) || (x.Sach != null && x.Sach.TenSach.Contains(keyword)))
                    .OrderByDescending(x => x.MaPM)
                    .ToList();
            }

            return entities.Select(ChiTietMuonTraDTO.FromEntity).ToList();
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