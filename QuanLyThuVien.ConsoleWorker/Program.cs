using System;
using System.Threading.Tasks;
using QuanLyThuVien.BLL;

namespace QuanLyThuVien.ConsoleWorker
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var muonTraBll = new MuonTraSach();

                // Thực thi quét CSDL và gửi email hoàn toàn im lặng ngầm dưới hệ thống
                await muonTraBll.KiemTraVaGuiMailSapHetHanAsync();
            }
            catch (Exception ex)
            {
                // Bắt ngoại lệ ngầm để tránh ngắt tiến trình hệ thống
                Console.WriteLine($"Lỗi tiến trình gửi mail: {ex.Message}");
            }
        }
    }
}