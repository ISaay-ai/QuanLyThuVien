using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyThuVien.BLL;
using QuanLyThuVien.DAL.Models;

namespace QuanLyThuVien.Views
{
    public partial class BaocaothongkeView : Form
    {
        private readonly BaoCaoThongKe _bll = new BaoCaoThongKe();
        private enum CheDoXem { DangMuon, DaTra, QuaHan }

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
    }
}
