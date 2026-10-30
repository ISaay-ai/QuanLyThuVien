using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuanLyThuVien.DAL;

namespace QuanLyThuVien.BLL
{
    public class ChatBotService
    {
        private const string ApiKey = "API KEY";

        private const string Model = "gemini-3.5-flash-lite";

        private static readonly HttpClient _http = new HttpClient { Timeout = TimeSpan.FromSeconds(25) };

        private readonly List<(string Role, string Content)> _history = new List<(string Role, string Content)>();

        public bool DaCoApiKey => !string.IsNullOrWhiteSpace(ApiKey);

        public void LamMoi() => _history.Clear();

        public async Task<string> HoiAsync(string cauHoi)
        {
            if (!DaCoApiKey)
                return "Chưa cấu hình API key. Hãy dán API key vào hằng số ApiKey trong file QuanLyThuVien.BLL/ChatBotService.cs.";

            string duLieu = LayDuLieuThuVien();

            string systemInstruction =
                "Bạn là trợ lý ảo của Hệ thống Quản lý Thư viện. Trả lời ngắn gọn, lịch sự bằng tiếng Việt. " +
                "Chỉ dựa vào DỮ LIỆU THƯ VIỆN bên dưới để trả lời các câu hỏi về sách, độc giả, tình trạng mượn trả. " +
                "Nếu dữ liệu không có thông tin thì nói rõ là không tìm thấy trong hệ thống, tuyệt đối không tự bịa thông tin.\n\n" +
                "=== DỮ LIỆU THƯ VIỆN (cập nhật lúc " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + ") ===\n" + duLieu;

            var contentsArray = new JsonArray();
            foreach (var h in _history)
            {
                contentsArray.Add(new JsonObject
                {
                    ["role"] = h.Role,
                    ["parts"] = new JsonArray
                    {
                        new JsonObject { ["text"] = h.Content }
                    }
                });
            }

            contentsArray.Add(new JsonObject
            {
                ["role"] = "user",
                ["parts"] = new JsonArray
                {
                    new JsonObject { ["text"] = cauHoi }
                }
            });

            var body = new JsonObject
            {
                ["system_instruction"] = new JsonObject
                {
                    ["parts"] = new JsonArray
                    {
                        new JsonObject { ["text"] = systemInstruction }
                    }
                },
                ["contents"] = contentsArray
            };

            string url = $"https://generativelanguage.googleapis.com/v1beta/models/{Model}:generateContent?key={ApiKey}";

            using var request = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = new StringContent(body.ToJsonString(), Encoding.UTF8, "application/json")
            };

            try
            {
                using var response = await _http.SendAsync(request);
                string json = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                    return $"Lỗi gọi API ({(int)response.StatusCode}): {json}";

                var root = JsonNode.Parse(json);
                string? traLoi = LayTextTraLoi(root);

                if (!string.IsNullOrEmpty(traLoi))
                {
                    _history.Add(("user", cauHoi));
                    _history.Add(("model", traLoi));
                    return traLoi;
                }

                return "(Không nhận được nội dung trả lời từ mô hình)";
            }
            catch (TaskCanceledException)
            {
                return "Yêu cầu phản hồi quá thời gian chờ (hơn 25 giây). Vui lòng thử lại!";
            }
            catch (Exception ex)
            {
                return "Lỗi kết nối: " + ex.Message;
            }
        }

        private static string? LayTextTraLoi(JsonNode? root)
        {
            var candidates = root?["candidates"]?.AsArray();
            if (candidates == null || candidates.Count == 0) return null;

            var parts = candidates[0]?["content"]?["parts"]?.AsArray();
            if (parts == null) return null;

            var sb = new StringBuilder();
            foreach (var part in parts)
            {
                string? text = part?["text"]?.GetValue<string>();
                if (!string.IsNullOrEmpty(text))
                    sb.Append(text);
            }
            return sb.Length > 0 ? sb.ToString() : null;
        }
        private static string LayDuLieuThuVien()
        {
            using var db = new AppDbContext();
            var sb = new StringBuilder();
            DateTime today = DateTime.Today;

            // Thống kê tổng quan
            sb.AppendLine($"Tổng số đầu sách: {db.Sachs.Count()}");
            sb.AppendLine($"Số thể loại: {db.TheLoais.Count()}, số tác giả: {db.TacGias.Count()}, số NXB: {db.NhaXuatBans.Count()}");
            sb.AppendLine($"Tổng số độc giả: {db.DocGias.Count()}");

            // Danh sách sách
            sb.AppendLine("\n[DANH SÁCH SÁCH] Mã | Tên | Tác giả | Thể loại | NXB | Năm XB | Tổng SL | Còn lại | Vị trí | Giá bìa");
            var sachs = db.Sachs.AsNoTracking()
                .Include(s => s.TacGia).Include(s => s.TheLoai).Include(s => s.NhaXuatBan)
                .OrderBy(s => s.MaSach).Take(300).ToList();
            foreach (var s in sachs)
                sb.AppendLine($"{s.MaSach} | {s.TenSach} | {s.TenTacGia} | {s.TenTheLoai} | {s.TenNXB} | {s.NamXB} | {s.SoLuong} | {s.SoLuongCon} | {s.ViTri} | {s.GiaBia:N0}đ");

            // Danh sách độc giả
            sb.AppendLine("\n[DANH SÁCH ĐỘC GIẢ] Mã SV | Họ tên | Khoa | SĐT | Email | Hạn thẻ");
            var docGias = db.DocGias.AsNoTracking().OrderBy(d => d.MaSV).Take(300).ToList();
            foreach (var d in docGias)
                sb.AppendLine($"{d.MaSV} | {d.HoTen} | {d.Khoa} | {d.SDT} | {d.Email} | {d.NgayHetHan:dd/MM/yyyy}");

            // Sách đang mượn
            sb.AppendLine("\n[SÁCH ĐANG MƯỢN] Mã PM | Độc giả | Tên sách | Ngày mượn | Hạn trả | Tình trạng");
            var dangMuon = db.ChiTietPhieuMuons.AsNoTracking()
                .Include(ct => ct.Sach)
                .Include(ct => ct.PhieuMuon).ThenInclude(pm => pm.DocGia)
                .Where(ct => ct.NgayTra == null && ct.PhieuMuon.TrangThai != "DaTra")
                .OrderBy(ct => ct.PhieuMuon.HanTra).Take(300).ToList();
            foreach (var ct in dangMuon)
            {
                string quaHan = ct.PhieuMuon.HanTra < today ? $"QUÁ HẠN {(today - ct.PhieuMuon.HanTra).Days} ngày" : "Còn hạn";
                sb.AppendLine($"{ct.MaPM} | {ct.PhieuMuon.DocGia?.HoTen} (MSSV {ct.PhieuMuon.MaSV}) | {ct.Sach?.TenSach} | {ct.PhieuMuon.NgayMuon:dd/MM/yyyy} | {ct.PhieuMuon.HanTra:dd/MM/yyyy} | {quaHan}");
            }

            return sb.ToString();
        }
    }
}
