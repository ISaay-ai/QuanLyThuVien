using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClosedXML.Excel;
using QuanLyThuVien.BLL;
using QuanLyThuVien.DAL.Models;

namespace QuanLyThuVien.Views
{
    public partial class BaocaothongkeView : Form
    {
        private readonly BaoCaoThongKe _bll = new BaoCaoThongKe();
        private enum CheDoXem { DangMuon, DaTra, QuaHan }
        private CheDoXem _currentCheDo = CheDoXem.DangMuon;

        public BaocaothongkeView()
        {
            InitializeComponent();

            // Cấu hình bảng hiển thị dữ liệu
            dgvData.ReadOnly = true;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.MultiSelect = false;
            dgvData.AllowUserToResizeRows = false;

            // Xử lý bỏ chọn dòng khi click chuột vào vùng trống ngoài bảng hoặc trên form
            dgvData.MouseDown += (s, e) =>
            {
                var hit = dgvData.HitTest(e.X, e.Y);
                if (hit.Type == DataGridViewHitTestType.None)
                {
                    dgvData.ClearSelection();
                }
            };

            this.MouseDown += (s, e) => dgvData.ClearSelection();
            grpThongKeMuonQuaHan.MouseDown += (s, e) => dgvData.ClearSelection();
            grpThongKeSach.MouseDown += (s, e) => dgvData.ClearSelection();
            grpThongKeDocGia.MouseDown += (s, e) => dgvData.ClearSelection();
        }

        private void BaocaothongkeView_Load(object sender, EventArgs e)
        {
            // Tải số liệu đếm tổng quan cho các khối thẻ
            TaiThongKeTongQuan();

            // Hiển thị danh sách sách đang mượn mặc định khi vừa mở form
            btnDangMuon_Click(this, EventArgs.Empty);

            // Căn chỉnh giao diện đẹp mắt và cân đối
            CanChinhGiaoDien();
        }

        private void BaocaothongkeView_Resize(object sender, EventArgs e)
        {
            CanChinhGiaoDien();
        }

        /// <summary>
        /// Căn chỉnh vị trí các khối GroupBox và tiêu đề luôn ở chính giữa khi form co giãn
        /// </summary>
        private void CanChinhGiaoDien()
        {
            // Căn giữa 2 GroupBox thống kê số liệu
            grpThongKeSach.Left = Math.Max(10, (this.ClientSize.Width - grpThongKeSach.Width) / 2);
            grpThongKeDocGia.Left = Math.Max(10, (this.ClientSize.Width - grpThongKeDocGia.Width) / 2);

            // Căn giữa 3 nút bấm và tiêu đề trong GroupBox danh sách mượn
            int mid = grpThongKeMuonQuaHan.ClientSize.Width / 2;
            btnDangMuon.Left = mid - 195;
            btnDaTra.Left = mid - 60;
            btnDSQuaHan.Left = mid + 75;

            lblTitleList.Left = Math.Max(40, mid - 190);
            lblTongSo.Left = mid + 50;

            // Đặt vị trí nút Xuất Excel luôn cách lề phải 25px
            if (btnXuatExcel != null)
            {
                btnXuatExcel.Left = grpThongKeMuonQuaHan.ClientSize.Width - btnXuatExcel.Width - 25;
            }
        }

        /// <summary>
        /// Tải các chỉ số thống kê từ BLL và gán vào các nhãn trên giao diện
        /// </summary>
        private void TaiThongKeTongQuan()
        {
            try
            {
                lblCountSach.Text = _bll.DemSoDauSach().ToString();
                lblCountLoaiSach.Text = _bll.DemSoLoaiSach().ToString();
                lblCountTacGia.Text = _bll.DemSoTacGia().ToString();
                lblCountNXB.Text = _bll.DemSoNhaXuatBan().ToString();
                lblCountDocGia.Text = _bll.DemSoDocGia().ToString();
                lblCountSachMuon.Text = _bll.DemSoSachDangMuon().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải số liệu thống kê: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sự kiện khi nhấn nút "Đang Mượn"
        /// </summary>
        private void btnDangMuon_Click(object sender, EventArgs e)
        {
            CapNhatGiaoDienNut(CheDoXem.DangMuon);
            HienThiDanhSachDangMuon();
        }

        /// <summary>
        /// Sự kiện khi nhấn nút "Đã Trả"
        /// </summary>
        private void btnDaTra_Click(object sender, EventArgs e)
        {
            CapNhatGiaoDienNut(CheDoXem.DaTra);
            HienThiDanhSachDaTra();
        }

        /// <summary>
        /// Sự kiện khi nhấn nút "DS Quá Hạn"
        /// </summary>
        private void btnDSQuaHan_Click(object sender, EventArgs e)
        {
            CapNhatGiaoDienNut(CheDoXem.QuaHan);
            HienThiDanhSachQuaHan();
        }

        /// <summary>
        /// Đổi màu nút bấm và tiêu đề tương ứng với chế độ đang xem
        /// </summary>
        private void CapNhatGiaoDienNut(CheDoXem cheDo)
        {
            _currentCheDo = cheDo;
            Color colorInactive = Color.FromArgb(108, 117, 137);

            btnDangMuon.BackColor = (cheDo == CheDoXem.DangMuon) ? Color.FromArgb(38, 138, 88) : colorInactive;
            btnDaTra.BackColor = (cheDo == CheDoXem.DaTra) ? Color.FromArgb(40, 110, 180) : colorInactive;
            btnDSQuaHan.BackColor = (cheDo == CheDoXem.QuaHan) ? Color.FromArgb(220, 53, 69) : colorInactive;

            btnDangMuon.ForeColor = Color.White;
            btnDaTra.ForeColor = Color.White;
            btnDSQuaHan.ForeColor = Color.White;

            switch (cheDo)
            {
                case CheDoXem.DangMuon:
                    lblTitleList.Text = "Danh sách sách đang mượn";
                    lblTitleList.ForeColor = Color.FromArgb(40, 40, 40);
                    lblTongSo.ForeColor = Color.FromArgb(38, 138, 88);
                    break;
                case CheDoXem.DaTra:
                    lblTitleList.Text = "Danh sách sách đã trả";
                    lblTitleList.ForeColor = Color.FromArgb(40, 40, 40);
                    lblTongSo.ForeColor = Color.FromArgb(40, 110, 180);
                    break;
                case CheDoXem.QuaHan:
                    lblTitleList.Text = "Danh sách sách mượn quá hạn";
                    lblTitleList.ForeColor = Color.FromArgb(180, 40, 40);
                    lblTongSo.ForeColor = Color.FromArgb(220, 53, 69);
                    break;
            }
        }

        /// <summary>
        /// Tải và hiển thị danh sách sách đang mượn
        /// </summary>
        private void HienThiDanhSachDangMuon()
        {
            try
            {
                List<ChiTietPhieuMuon> ds = _bll.LayDanhSachDangMuon();
                dgvData.DataSource = null;
                dgvData.DataSource = ds;

                lblTongSo.Text = $"Tổng:    {ds.Count}    Sách";

                DinhDangCot(CheDoXem.DangMuon);
                dgvData.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách sách đang mượn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Tải và hiển thị danh sách sách đã trả
        /// </summary>
        private void HienThiDanhSachDaTra()
        {
            try
            {
                List<ChiTietPhieuMuon> ds = _bll.LayDanhSachDaTra();
                dgvData.DataSource = null;
                dgvData.DataSource = ds;

                lblTongSo.Text = $"Tổng:    {ds.Count}    Sách Đã Trả";

                DinhDangCot(CheDoXem.DaTra);
                dgvData.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách sách đã trả: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Tải và hiển thị danh sách sách mượn quá hạn
        /// </summary>
        private void HienThiDanhSachQuaHan()
        {
            try
            {
                List<ChiTietPhieuMuon> ds = _bll.LayDanhSachQuaHan();
                dgvData.DataSource = null;
                dgvData.DataSource = ds;

                lblTongSo.Text = $"Tổng:    {ds.Count}    Sách Quá Hạn";

                DinhDangCot(CheDoXem.QuaHan);
                dgvData.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách sách mượn quá hạn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Định dạng các cột hiển thị trên DataGridView
        /// </summary>
        private void DinhDangCot(CheDoXem cheDo)
        {
            // Ẩn các thuộc tính quan hệ / không cần thiết
            if (dgvData.Columns["PhieuMuon"] is DataGridViewColumn colPM) colPM.Visible = false;
            if (dgvData.Columns["Sach"] is DataGridViewColumn colS) colS.Visible = false;
            if (dgvData.Columns["SoLuong"] is DataGridViewColumn colSL) colSL.Visible = false;
            if (dgvData.Columns["SoLanGiaHan"] is DataGridViewColumn colGH) colGH.Visible = false;

            // Đặt tên cột tiếng Việt và tỉ lệ độ rộng
            if (dgvData.Columns["MaPM"] is DataGridViewColumn cMaPM)
            {
                cMaPM.HeaderText = "Mã PM";
                cMaPM.FillWeight = 45;
                cMaPM.DisplayIndex = 0;
            }
            if (dgvData.Columns["MaSV"] is DataGridViewColumn cMaSV)
            {
                cMaSV.HeaderText = "Mã SV";
                cMaSV.FillWeight = 50;
                cMaSV.DisplayIndex = 1;
            }
            if (dgvData.Columns["TenDocGia"] is DataGridViewColumn cTenSV)
            {
                cTenSV.HeaderText = "Tên Độc Giả";
                cTenSV.FillWeight = 110;
                cTenSV.DisplayIndex = 2;
            }
            if (dgvData.Columns["MaSach"] is DataGridViewColumn cMaSach)
            {
                cMaSach.HeaderText = "Mã Sách";
                cMaSach.FillWeight = 50;
                cMaSach.DisplayIndex = 3;
            }
            if (dgvData.Columns["TenSach"] is DataGridViewColumn cTenSach)
            {
                cTenSach.HeaderText = "Tên Sách";
                cTenSach.FillWeight = 125;
                cTenSach.DisplayIndex = 4;
            }
            if (dgvData.Columns["NgayMuon"] is DataGridViewColumn cNgayMuon)
            {
                cNgayMuon.HeaderText = "Ngày Mượn";
                cNgayMuon.DefaultCellStyle.Format = "dd/MM/yyyy";
                cNgayMuon.FillWeight = 70;
                cNgayMuon.DisplayIndex = 5;
            }
            if (dgvData.Columns["HanTra"] is DataGridViewColumn cHanTra)
            {
                cHanTra.HeaderText = "Hạn Trả";
                cHanTra.DefaultCellStyle.Format = "dd/MM/yyyy";
                cHanTra.FillWeight = 70;
                cHanTra.DisplayIndex = 6;
            }
            if (dgvData.Columns["NgayTra"] is DataGridViewColumn cNgayTra)
            {
                cNgayTra.HeaderText = "Ngày Trả";
                cNgayTra.DefaultCellStyle.Format = "dd/MM/yyyy";
                cNgayTra.FillWeight = 70;
                cNgayTra.Visible = true;
                cNgayTra.DisplayIndex = 7;
            }
            if (dgvData.Columns["TinhTrangSach"] is DataGridViewColumn cTinhTrang)
            {
                cTinhTrang.HeaderText = "Tình Trạng";
                cTinhTrang.FillWeight = 75;
                cTinhTrang.DisplayIndex = 8;
            }
            if (dgvData.Columns["TrangThai"] is DataGridViewColumn cTrangThai)
            {
                cTrangThai.HeaderText = "Trạng Thái";
                cTrangThai.FillWeight = 75;
                cTrangThai.DisplayIndex = 9;
            }
            if (dgvData.Columns["GhiChu"] is DataGridViewColumn cGhiChu)
            {
                cGhiChu.HeaderText = "Ghi Chú";
                cGhiChu.FillWeight = 130;
                cGhiChu.Visible = true;
                cGhiChu.DisplayIndex = 10;
            }
            if (dgvData.Columns["SoNgayQuaHan"] is DataGridViewColumn cSoNgayQuaHan)
            {
                bool isQuaHan = (cheDo == CheDoXem.QuaHan);
                cSoNgayQuaHan.Visible = isQuaHan;
                if (isQuaHan)
                {
                    cSoNgayQuaHan.HeaderText = "Trễ Hạn (Ngày)";
                    cSoNgayQuaHan.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    cSoNgayQuaHan.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                    cSoNgayQuaHan.DefaultCellStyle.ForeColor = Color.FromArgb(220, 53, 69);
                    cSoNgayQuaHan.FillWeight = 70;
                    cSoNgayQuaHan.DisplayIndex = 11;
                }
            }

            // Đổi màu dòng cảnh báo nếu đang ở chế độ quá hạn
            if (cheDo == CheDoXem.QuaHan)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(180, 30, 30);
                    row.DefaultCellStyle.SelectionForeColor = Color.Yellow;
                }
            }
        }

        /// <summary>
        /// Xử lý xuất toàn bộ danh sách đang hiển thị ra tệp Microsoft Excel (.xlsx)
        /// </summary>
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count == 0)
            {
                MessageBox.Show("Hiện không có dữ liệu nào trong bảng để xuất ra Excel!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Tên file và tiêu đề báo cáo mặc định theo chế độ xem đang chọn
            string defaultFileName = _currentCheDo switch
            {
                CheDoXem.DangMuon => $"DS_Sach_Dang_Muon_{DateTime.Now:yyyyMMdd_HHmm}.xlsx",
                CheDoXem.DaTra => $"DS_Sach_Da_Tra_{DateTime.Now:yyyyMMdd_HHmm}.xlsx",
                CheDoXem.QuaHan => $"DS_Sach_Qua_Han_{DateTime.Now:yyyyMMdd_HHmm}.xlsx",
                _ => $"Bao_Cao_Thong_Ke_{DateTime.Now:yyyyMMdd_HHmm}.xlsx"
            };

            string reportTitle = _currentCheDo switch
            {
                CheDoXem.DangMuon => "DANH SÁCH SÁCH ĐANG MƯỢN",
                CheDoXem.DaTra => "DANH SÁCH SÁCH ĐÃ TRẢ",
                CheDoXem.QuaHan => "DANH SÁCH SÁCH MƯỢN QUÁ HẠN",
                _ => "BÁO CÁO THỐNG KÊ"
            };

            using var sfd = new SaveFileDialog
            {
                Filter = "Excel Workbook (*.xlsx)|*.xlsx",
                FileName = defaultFileName,
                Title = "Chọn nơi lưu file Excel báo cáo"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("ThongKe");

                    // 1. Tiêu đề chính hệ thống
                    worksheet.Cell(1, 1).Value = "HỆ THỐNG QUẢN LÝ THƯ VIỆN";
                    worksheet.Cell(1, 1).Style.Font.Bold = true;
                    worksheet.Cell(1, 1).Style.Font.FontSize = 16;
                    worksheet.Cell(1, 1).Style.Font.FontColor = XLColor.FromArgb(16, 124, 65);

                    // 2. Tiêu đề báo cáo
                    worksheet.Cell(2, 1).Value = reportTitle;
                    worksheet.Cell(2, 1).Style.Font.Bold = true;
                    worksheet.Cell(2, 1).Style.Font.FontSize = 13;
                    worksheet.Cell(2, 1).Style.Font.FontColor = XLColor.FromArgb(40, 40, 40);

                    // 3. Thời gian xuất và tổng số dòng
                    worksheet.Cell(3, 1).Value = $"Thời gian xuất: {DateTime.Now:dd/MM/yyyy HH:mm:ss} | Tổng số bản ghi: {dgvData.Rows.Count}";
                    worksheet.Cell(3, 1).Style.Font.Italic = true;
                    worksheet.Cell(3, 1).Style.Font.FontSize = 10;
                    worksheet.Cell(3, 1).Style.Font.FontColor = XLColor.Gray;

                    // 4. Lấy danh sách cột hiển thị theo thứ tự DisplayIndex
                    var visibleCols = dgvData.Columns
                        .Cast<DataGridViewColumn>()
                        .Where(c => c.Visible)
                        .OrderBy(c => c.DisplayIndex)
                        .ToList();

                    if (visibleCols.Count == 0)
                    {
                        MessageBox.Show("Không có cột nào hiển thị để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int startRow = 5;

                    // Header hàng 5
                    for (int c = 0; c < visibleCols.Count; c++)
                    {
                        var cell = worksheet.Cell(startRow, c + 1);
                        cell.Value = visibleCols[c].HeaderText;
                        cell.Style.Font.Bold = true;
                        cell.Style.Font.FontSize = 11;
                        cell.Style.Font.FontColor = XLColor.White;
                        cell.Style.Fill.BackgroundColor = XLColor.FromArgb(16, 124, 65);
                        cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        cell.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        cell.Style.Border.OutsideBorderColor = XLColor.FromArgb(200, 200, 200);
                    }
                    worksheet.Row(startRow).Height = 26;

                    // Dữ liệu từ hàng 6
                    int currentRow = startRow + 1;
                    for (int r = 0; r < dgvData.Rows.Count; r++)
                    {
                        var dgvRow = dgvData.Rows[r];
                        for (int c = 0; c < visibleCols.Count; c++)
                        {
                            var col = visibleCols[c];
                            var rawVal = dgvRow.Cells[col.Index].Value;
                            var cell = worksheet.Cell(currentRow, c + 1);

                            if (rawVal != null && rawVal != DBNull.Value)
                            {
                                if (rawVal is DateTime dt)
                                {
                                    cell.Value = dt;
                                    cell.Style.DateFormat.Format = "dd/MM/yyyy";
                                    cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                }
                                else if (rawVal is int intVal)
                                {
                                    cell.Value = intVal;
                                    cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                }
                                else if (rawVal is decimal decVal)
                                {
                                    cell.Value = (double)decVal;
                                    cell.Style.NumberFormat.Format = "#,##0";
                                    cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
                                }
                                else
                                {
                                    cell.Value = rawVal.ToString();
                                    if (col.Name.StartsWith("Ma") || col.Name == "TrangThai")
                                    {
                                        cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                    }
                                    else
                                    {
                                        cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                                    }
                                }
                            }
                            else
                            {
                                cell.Value = string.Empty;
                            }

                            cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                            cell.Style.Border.OutsideBorderColor = XLColor.FromArgb(220, 220, 220);

                            // Màu dòng so le
                            if (r % 2 == 1)
                            {
                                cell.Style.Fill.BackgroundColor = XLColor.FromArgb(248, 249, 250);
                            }

                            // Cảnh báo đỏ nếu trễ hạn
                            if (_currentCheDo == CheDoXem.QuaHan && (col.Name == "SoNgayQuaHan" || col.Name == "HanTra"))
                            {
                                cell.Style.Font.FontColor = XLColor.FromArgb(220, 53, 69);
                                cell.Style.Font.Bold = true;
                            }
                        }
                        worksheet.Row(currentRow).Height = 22;
                        currentRow++;
                    }

                    // Dòng tổng kết
                    var totalLabelCell = worksheet.Cell(currentRow, 1);
                    totalLabelCell.Value = "TỔNG CỘNG:";
                    totalLabelCell.Style.Font.Bold = true;
                    totalLabelCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;

                    var totalValCell = worksheet.Cell(currentRow, 2);
                    totalValCell.Value = $"{dgvData.Rows.Count} bản ghi";
                    totalValCell.Style.Font.Bold = true;
                    totalValCell.Style.Font.FontColor = XLColor.FromArgb(16, 124, 65);

                    for (int c = 1; c <= visibleCols.Count; c++)
                    {
                        worksheet.Cell(currentRow, c).Style.Border.TopBorder = XLBorderStyleValues.Thin;
                        worksheet.Cell(currentRow, c).Style.Border.BottomBorder = XLBorderStyleValues.Double;
                    }
                    worksheet.Row(currentRow).Height = 24;

                    // Căn chỉnh tự động độ rộng cột
                    worksheet.Columns().AdjustToContents();
                    for (int c = 1; c <= visibleCols.Count; c++)
                    {
                        if (worksheet.Column(c).Width < 12)
                            worksheet.Column(c).Width = 12;
                    }

                    workbook.SaveAs(sfd.FileName);
                }

                var choice = MessageBox.Show(
                    "Xuất dữ liệu ra file Excel thành công!\nBạn có muốn mở file vừa xuất ngay bây giờ không?",
                    "Thành công",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (choice == DialogResult.Yes)
                {
                    Process.Start(new ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xuất file Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Tự vẽ biểu tượng bảng tính Excel trực tiếp lên nút Xuất Excel
        /// </summary>
        private void btnXuatExcel_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int iconX = 14;
            int iconY = (btnXuatExcel.Height - 20) / 2;

            // Nền trang tính
            using (var brush = new SolidBrush(Color.FromArgb(235, 255, 240)))
            {
                g.FillRectangle(brush, iconX, iconY, 18, 20);
            }
            using (var pen = new Pen(Color.White, 1.5f))
            {
                g.DrawRectangle(pen, iconX, iconY, 18, 20);
            }

            // Kẻ ô lưới Excel
            using (var gridPen = new Pen(Color.FromArgb(16, 124, 65), 1f))
            {
                g.DrawLine(gridPen, iconX + 4, iconY + 7, iconX + 14, iconY + 7);
                g.DrawLine(gridPen, iconX + 4, iconY + 11, iconX + 14, iconY + 11);
                g.DrawLine(gridPen, iconX + 4, iconY + 15, iconX + 14, iconY + 15);
                g.DrawLine(gridPen, iconX + 9, iconY + 4, iconX + 9, iconY + 17);
            }

            // Khối nhãn màu xanh lá đậm biểu tượng chữ X
            using (var badgeBrush = new SolidBrush(Color.FromArgb(16, 124, 65)))
            {
                g.FillRectangle(badgeBrush, iconX - 3, iconY + 4, 11, 12);
            }
            using (var font = new Font("Arial", 8f, FontStyle.Bold))
            using (var textBrush = new SolidBrush(Color.White))
            {
                g.DrawString("X", font, textBrush, iconX - 2, iconY + 4);
            }
        }
    }
}
