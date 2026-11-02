using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyThuVien.BLL;
using QuanLyThuVien.DAL.Models;
using QuanLyThuVien.SubViews;

namespace QuanLyThuVien.Views
{
    public partial class MuontrasachViewcs : Form
    {
        private readonly MuonTraSach muonTraSach = new MuonTraSach();
        private enum ThaoTac { Xem, Muon, GiaHan }
        private ThaoTac thaoTacHienTai = ThaoTac.Xem;

        private List<DocGia> dsDocGia = new List<DocGia>();
        private List<Sach> dsSach = new List<Sach>();
        private List<ChiTietMuonTraDTO> dsMuonTra = new List<ChiTietMuonTraDTO>();

        public MuontrasachViewcs()
        {
            InitializeComponent();
            KhoiTaoDuLieu();
            SetTrangThaiNut(ThaoTac.Xem);
            LoadData();
        }

        private void KhoiTaoDuLieu()
        {
            dsDocGia = muonTraSach.LayDanhSachDocGia();
            cbPMMaSV.DataSource = null;
            cbPMMaSV.DataSource = dsDocGia;
            cbPMMaSV.DisplayMember = "HoTen";
            cbPMMaSV.ValueMember = "MaSV";

            dsSach = muonTraSach.LayDanhSachSach();
            cbPMTenSach.DataSource = null;
            cbPMTenSach.DataSource = dsSach;
            cbPMTenSach.DisplayMember = "TenSach";
            cbPMTenSach.ValueMember = "MaSach";
        }

        private void SetTrangThaiNut(ThaoTac tt)
        {
            thaoTacHienTai = tt;
            CapNhatGiaoDienTrangThaiNut(tt != ThaoTac.Xem, tt == ThaoTac.Muon);
        }

        private void LoadData()
        {
            dsMuonTra = muonTraSach.LayDanhSachChiTietMuonTra();
            dgvMuonTra.DataSource = null;
            dgvMuonTra.DataSource = dsMuonTra;

            DinhDangCotDataGridView();

            if (dgvMuonTra.Rows.Count > 0)
            {
                dgvMuonTra.Rows[0].Selected = true;
                HienThiChiTiet(dsMuonTra[0]);
            }
            else
            {
                XoaTrangPhieuMuon();
            }
        }


        private void HienThiChiTiet(ChiTietMuonTraDTO? dto)
        {
            if (dto == null)
            {
                XoaTrangPhieuMuon();
                return;
            }

            txtMaPM.Text = dto.MaPM.ToString();
            txtTinhTrangSach.Text = dto.TinhTrangSach;
            if (dto.NgayMuon != default)
            {
                dtpNgayMuon.Value = dto.NgayMuon;
            }
            if (dto.HanTra != default)
            {
                dtpNgayTra.Value = dto.HanTra;
            }

            // Đồng bộ combobox Độc giả và thông tin sinh viên
            cbPMMaSV.SelectedValue = dto.MaSV;
            var dg = dsDocGia.FirstOrDefault(x => x.MaSV == dto.MaSV);
            if (dg != null)
            {
                txtMaSV.Text = dg.MaSV.ToString();
                txtTenSV.Text = dg.HoTen;
            }
            else
            {
                txtMaSV.Text = dto.MaSV.ToString();
                txtTenSV.Text = dto.TenDocGia;
            }

            // Đồng bộ combobox Sách và thông tin sách
            cbPMTenSach.SelectedValue = dto.MaSach;
            var sach = dsSach.FirstOrDefault(x => x.MaSach == dto.MaSach);
            if (sach != null)
            {
                txtMaSach.Text = sach.MaSach.ToString();
                txtTenSach.Text = sach.TenSach;
                txtTenTG.Text = sach.TenTacGia;
                txtSLCon.Text = sach.SoLuongCon.ToString();
            }
            else
            {
                txtMaSach.Text = dto.MaSach.ToString();
                txtTenSach.Text = dto.TenSach;
                txtTenTG.Text = string.Empty;
                txtSLCon.Text = string.Empty;
            }
        }

        private void XoaTrangPhieuMuon()
        {
            txtMaPM.Text = string.Empty;
            txtTinhTrangSach.Text = "Bình thường";
            txtMaSV.Text = string.Empty;
            txtTenSV.Text = string.Empty;
            txtMaSach.Text = string.Empty;
            txtTenSach.Text = string.Empty;
            txtTenTG.Text = string.Empty;
            txtSLCon.Text = string.Empty;
        }

        private void dgvMuonTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (thaoTacHienTai != ThaoTac.Xem)
            {
                return;
            }

            if (e.RowIndex >= 0 && dgvMuonTra.Rows[e.RowIndex].DataBoundItem is ChiTietMuonTraDTO dto)
            {
                HienThiChiTiet(dto);
            }
        }

        private void cbPMMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPMMaSV.SelectedItem is DocGia dg)
            {
                txtMaSV.Text = dg.MaSV.ToString();
                txtTenSV.Text = dg.HoTen;
            }
        }

        private void cbPMTenSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPMTenSach.SelectedItem is Sach s)
            {
                txtMaSach.Text = s.MaSach.ToString();
                txtTenSach.Text = s.TenSach;
                txtTenTG.Text = s.TenTacGia;
                txtSLCon.Text = s.SoLuongCon.ToString();
            }
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            if (dsDocGia.Count == 0)
            {
                MessageBox.Show("Hiện chưa có dữ liệu độc giả. Vui lòng thêm độc giả trước khi lập phiếu mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dsSach.Count == 0)
            {
                MessageBox.Show("Hiện chưa có dữ liệu sách trong thư viện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetTrangThaiNut(ThaoTac.Muon);
            txtMaPM.Text = "(Tự động)";
            dtpNgayMuon.Value = DateTime.Today;
            dtpNgayTra.Value = DateTime.Today.AddDays(14);
            txtTinhTrangSach.Text = "Bình thường";

            if (cbPMMaSV.Items.Count > 0)
            {
                cbPMMaSV.SelectedIndex = 0;
            }
            if (cbPMTenSach.Items.Count > 0)
            {
                cbPMTenSach.SelectedIndex = 0;
            }
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            if (dgvMuonTra.CurrentRow?.DataBoundItem is not ChiTietMuonTraDTO dto)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn cần gia hạn từ bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dto.NgayTra != null || dto.TrangThai == "DaTra")
            {
                MessageBox.Show("Sách này đã được trả, không thể gia hạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dto.SoLanGiaHan >= 2)
            {
                MessageBox.Show("Phiếu mượn này đã được gia hạn 2 lần (tối đa theo quy định), không thể gia hạn thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetTrangThaiNut(ThaoTac.GiaHan);
            dtpNgayTra.Value = dto.HanTra.AddDays(7);
        }

        // =========================================================================================================
        // SỰ KIỆN CLICK NÚT btnTraSach -> POPUP FORM TrasachView ĐỂ XỬ LÝ TRẢ SÁCH, VI PHẠM, PHẠT TIỀN
        // =========================================================================================================
        private void btnTraSach_Click(object sender, EventArgs e)
        {
            ChiTietMuonTraDTO? dto = null;

            // 1. Lấy thông tin phiếu mượn từ dòng đang chọn trên DataGridView
            if (dgvMuonTra.CurrentRow?.DataBoundItem is ChiTietMuonTraDTO item1)
            {
                dto = item1;
            }
            else if (dgvMuonTra.SelectedRows.Count > 0 && dgvMuonTra.SelectedRows[0].DataBoundItem is ChiTietMuonTraDTO item2)
            {
                dto = item2;
            }

            // 2. Nếu người dùng chưa chọn dòng nào, tự động lấy phiếu mượn chưa trả đầu tiên
            if (dto == null)
            {
                dto = dsMuonTra.FirstOrDefault(x => x.NgayTra == null && x.TrangThai != "DaTra");
            }

            if (dto == null)
            {
                MessageBox.Show("Hiện không có phiếu mượn nào cần trả sách trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 3. Nếu dòng đang chọn đã được trả trước đó, hỗ trợ chuyển sang phiếu mượn đang mượn gần nhất
            if (dto.NgayTra != null || dto.TrangThai == "DaTra")
            {
                var chuaTra = dsMuonTra.FirstOrDefault(x => x.NgayTra == null && x.TrangThai != "DaTra");
                if (chuaTra != null)
                {
                    var luaChon = MessageBox.Show(
                        $"Phiếu mượn số {dto.MaPM} đã được trả trước đó rồi.\n\nBạn có muốn chuyển sang trả sách cho phiếu mượn chưa trả gần nhất (Mã PM: {chuaTra.MaPM} - Độc giả: {chuaTra.TenDocGia} - Sách: {chuaTra.TenSach}) không?",
                        "Phiếu mượn đã trả", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (luaChon == DialogResult.Yes)
                    {
                        dto = chuaTra;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Tất cả phiếu mượn trong hệ thống đều đã được trả sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            // 4. Khởi tạo và hiển thị popup TrasachView dạng Modal Dialog
            using var frmTra = new SubViews.TrasachView(dto);
            if (frmTra.ShowDialog(this) == DialogResult.OK)
            {
                // Khi xác nhận trả sách thành công, làm mới toàn bộ dữ liệu trên bảng
                KhoiTaoDuLieu();
                LoadData();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (thaoTacHienTai == ThaoTac.Muon)
            {
                if (cbPMMaSV.SelectedValue is not int maSV)
                {
                    MessageBox.Show("Vui lòng chọn độc giả mượn sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbPMTenSach.SelectedValue is not int maSach)
                {
                    MessageBox.Show("Vui lòng chọn sách cần mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dtpNgayTra.Value.Date < dtpNgayMuon.Value.Date)
                {
                    MessageBox.Show("Hạn trả sách không thể trước ngày mượn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (muonTraSach.ThemPhieuMuon(maSV, maSach, dtpNgayMuon.Value, dtpNgayTra.Value, out string thongBaoLoi))
                {
                    MessageBox.Show("Lập phiếu mượn sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetTrangThaiNut(ThaoTac.Xem);
                    KhoiTaoDuLieu();
                    LoadData();
                }
                else
                {
                    MessageBox.Show(thongBaoLoi, "Lỗi lập phiếu mượn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (thaoTacHienTai == ThaoTac.GiaHan)
            {
                if (!int.TryParse(txtMaPM.Text, out int maPM))
                {
                    MessageBox.Show("Mã phiếu mượn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (muonTraSach.GiaHan(maPM, dtpNgayTra.Value, out string thongBaoLoi))
                {
                    MessageBox.Show("Gia hạn phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetTrangThaiNut(ThaoTac.Xem);
                    LoadData();
                }
                else
                {
                    MessageBox.Show(thongBaoLoi, "Lỗi gia hạn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            SetTrangThaiNut(ThaoTac.Xem);
            if (dgvMuonTra.CurrentRow?.DataBoundItem is ChiTietMuonTraDTO dto)
            {
                HienThiChiTiet(dto);
            }
            else if (dsMuonTra.Count > 0)
            {
                HienThiChiTiet(dsMuonTra[0]);
            }
            else
            {
                XoaTrangPhieuMuon();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            ThucHienTimKiem();
        }

        private void rbTimKiem_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton rb && rb.Checked)
            {
                ThucHienTimKiem();
            }
        }

        private void ThucHienTimKiem()
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            bool isTimTheoMaSV = rbMaSV.Checked;

            var ketQua = muonTraSach.TimKiem(tuKhoa, isTimTheoMaSV);
            dgvMuonTra.DataSource = null;
            dgvMuonTra.DataSource = ketQua;
            DinhDangCotDataGridView();

            if (ketQua.Count > 0)
            {
                HienThiChiTiet(ketQua[0]);
            }
            else
            {
                XoaTrangPhieuMuon();
            }
        }
    }
}
