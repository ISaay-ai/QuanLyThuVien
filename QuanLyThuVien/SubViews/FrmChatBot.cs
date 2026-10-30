using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyThuVien.BLL;

namespace QuanLyThuVien.SubViews
{
    public partial class FrmChatBot : Form
    {
        private readonly ChatBotService _bll = new ChatBotService();

        public FrmChatBot()
        {
            InitializeComponent();
        }

        private void FrmChatBot_Load(object? sender, EventArgs e)
        {
            ThemTinNhan("Bot", "Xin chào! Tôi có thể trả lời các câu hỏi về sách, độc giả và tình hình mượn trả trong thư viện.", Color.FromArgb(0, 120, 215));
            if (!_bll.DaCoApiKey)
                ThemTinNhan("Hệ thống", "Chưa có API key. Hãy dán key vào ApiKey trong QuanLyThuVien.BLL/ChatBotService.cs.", Color.Red);
            txtCauHoi.Focus();
        }

        /// <summary>
        /// Nhấn nút "Gửi": gửi câu hỏi lên chatbot và hiển thị câu trả lời
        /// </summary>
        private async void btnGui_Click(object? sender, EventArgs e)
        {
            string cauHoi = txtCauHoi.Text.Trim();
            if (cauHoi.Length == 0) return;

            ThemTinNhan("Bạn", cauHoi, Color.FromArgb(38, 138, 88));
            txtCauHoi.Clear();
            DatTrangThaiCho(true);

            try
            {
                string traLoi = await _bll.HoiAsync(cauHoi);

                // Nếu Form hoặc control đã bị huỷ (người dùng chuyển tab / đóng form), bỏ qua việc cập nhật
                if (IsDisposed || Disposing || rtbLichSu == null || rtbLichSu.IsDisposed)
                    return;

                ThemTinNhan("Bot", traLoi, Color.FromArgb(0, 120, 215));
            }
            catch (Exception ex)
            {
                if (IsDisposed || Disposing || rtbLichSu == null || rtbLichSu.IsDisposed)
                    return;

                ThemTinNhan("Hệ thống", "Lỗi: " + ex.Message, Color.Red);
            }
            finally
            {
                if (!IsDisposed && !Disposing)
                {
                    DatTrangThaiCho(false);
                }
            }
        }

        /// <summary>
        /// Nhấn Enter trong ô nhập để gửi nhanh
        /// </summary>
        private void txtCauHoi_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnGui.PerformClick();
            }
        }

        /// <summary>
        /// Nhấn nút "Làm mới": xoá lịch sử chat và bắt đầu hội thoại mới
        /// </summary>
        private void btnLamMoi_Click(object? sender, EventArgs e)
        {
            _bll.LamMoi();
            rtbLichSu.Clear();
            FrmChatBot_Load(this, EventArgs.Empty);
        }

        private void DatTrangThaiCho(bool dangCho)
        {
            if (IsDisposed || Disposing || btnGui == null || btnGui.IsDisposed || txtCauHoi == null || txtCauHoi.IsDisposed)
                return;

            if (InvokeRequired)
            {
                try { BeginInvoke(new Action(() => DatTrangThaiCho(dangCho))); }
                catch { }
                return;
            }

            btnGui.Enabled = !dangCho;
            txtCauHoi.Enabled = !dangCho;
            btnGui.Text = dangCho ? "..." : "Gửi";
            if (!dangCho && txtCauHoi.CanFocus)
            {
                txtCauHoi.Focus();
            }
        }

        /// <summary>
        /// Thêm một tin nhắn vào khung lịch sử chat (đảm bảo an toàn luồng và không ném ObjectDisposedException)
        /// </summary>
        private void ThemTinNhan(string nguoiGui, string noiDung, Color mauTen)
        {
            if (IsDisposed || Disposing || rtbLichSu == null || rtbLichSu.IsDisposed)
                return;

            if (InvokeRequired)
            {
                try { BeginInvoke(new Action(() => ThemTinNhan(nguoiGui, noiDung, mauTen))); }
                catch { }
                return;
            }

            try
            {
                rtbLichSu.SelectionStart = rtbLichSu.TextLength;
                rtbLichSu.SelectionColor = mauTen;
                rtbLichSu.SelectionFont = new Font(rtbLichSu.Font, FontStyle.Bold);
                rtbLichSu.AppendText(nguoiGui + ": ");

                rtbLichSu.SelectionColor = Color.Black;
                rtbLichSu.SelectionFont = rtbLichSu.Font;
                rtbLichSu.AppendText(noiDung + Environment.NewLine + Environment.NewLine);

                rtbLichSu.ScrollToCaret();
            }
            catch (ObjectDisposedException)
            {
                // Bỏ qua nếu form đã đóng trong quá trình ghi text
            }
        }
    }
}
