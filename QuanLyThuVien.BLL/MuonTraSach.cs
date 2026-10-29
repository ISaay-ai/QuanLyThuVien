using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QuanLyThuVien.BLL
{
    public class MuonTraSach
    {
        /// <summary>
        /// Lấy toàn bộ danh sách mượn trả sách để hiển thị lên DataGridView
        /// </summary>
        public DataTable LayDanhSachMuonTra()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT pm.MaPhieuMuon, sv.MaSV, sv.TenSV, s.MaSach, s.TenSach, 
                                    pm.NgayMuon, pm.NgayTra, pm.GhiChu 
                             FROM PhieuMuon pm
                             JOIN SinhVien sv ON pm.MaSV = sv.MaSV
                             JOIN Sach s ON pm.MaSach = s.MaSach";

            // dt = DBConnect.ExecuteQuery(query);
            return dt;
        }

        /// <summary>
        /// Chức năng Mượn sách (Thêm phiếu mượn mới)
        /// </summary>
        public bool ThemPhieuMuon(string maPM, string maSV, string maSach, DateTime ngayMuon, DateTime ngayTra, string ghiChu)
        {
            try
            {
                string queryInsert = string.Format(
                    "INSERT INTO PhieuMuon(MaPhieuMuon, MaSV, MaSach, NgayMuon, NgayTra, GhiChu) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                    maPM, maSV, maSach, ngayMuon.ToString("yyyy-MM-dd"), ngayTra.ToString("yyyy-MM-dd"), ghiChu);

                string queryUpdateSach = "UPDATE Sach SET SLCon = SLCon - 1 WHERE MaSach = '" + maSach + "'";

                // DBConnect.ExecuteNonQuery(queryInsert);
                // DBConnect.ExecuteNonQuery(queryUpdateSach);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Chức năng Trả sách
        /// </summary>
        public bool TraSach(string maPM, string maSach)
        {
            try
            {
                string queryUpdatePM = "UPDATE PhieuMuon SET GhiChu = N'Đã trả' WHERE MaPhieuMuon = '" + maPM + "'";
                string queryUpdateSach = "UPDATE Sach SET SLCon = SLCon + 1 WHERE MaSach = '" + maSach + "'";

                // DBConnect.ExecuteNonQuery(queryUpdatePM);
                // DBConnect.ExecuteNonQuery(queryUpdateSach);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Chức năng Gia hạn ngày trả
        /// </summary>
        public bool GiaHan(string maPM, DateTime ngayTraMoi)
        {
            try
            {
                string query = string.Format("UPDATE PhieuMuon SET NgayTra = '{0}', GhiChu = N'Đã gia hạn' WHERE MaPhieuMuon = '{1}'",
                    ngayTraMoi.ToString("yyyy-MM-dd"), maPM);

                // DBConnect.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Chức năng Tìm kiếm phiếu mượn
        /// </summary>
        public DataTable TimKiemMuonTra(string tuKhoa, bool isTimTheoMaSV)
        {
            DataTable dt = new DataTable();
            string query = "";

            if (isTimTheoMaSV)
            {
                query = "SELECT * FROM PhieuMuon WHERE MaSV LIKE '%" + tuKhoa + "%'";
            }
            else
            {
                query = "SELECT * FROM PhieuMuon WHERE MaSach LIKE '%" + tuKhoa + "%'";
            }

            // dt = DBConnect.ExecuteQuery(query);
            return dt;
        }
    }
}