using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyThuVien.DAL.Migrations
{
    /// <inheritdoc />
    public partial class khoitao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nganh",
                columns: table => new
                {
                    MaNganh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNganh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nganh", x => x.MaNganh);
                });

            migrationBuilder.CreateTable(
                name: "NhaXuatBan",
                columns: table => new
                {
                    MaNXB = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNXB = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaXuatBan", x => x.MaNXB);
                });

            migrationBuilder.CreateTable(
                name: "QuyDinhPhat",
                columns: table => new
                {
                    MaQD = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaViPham = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TenQuyDinh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KieuTinh = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MucPhat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TranPhat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ApDung = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuyDinhPhat", x => x.MaQD);
                });

            migrationBuilder.CreateTable(
                name: "TacGia",
                columns: table => new
                {
                    MaTacGia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTacGia = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TacGia", x => x.MaTacGia);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    MaTK = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDangNhap = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "date", nullable: true),
                    SDT = table.Column<string>(type: "varchar(15)", nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    VaiTro = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.MaTK);
                });

            migrationBuilder.CreateTable(
                name: "TheLoai",
                columns: table => new
                {
                    MaTheLoai = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTheLoai = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheLoai", x => x.MaTheLoai);
                });

            migrationBuilder.CreateTable(
                name: "DocGia",
                columns: table => new
                {
                    MaSV = table.Column<int>(type: "int", maxLength: 20, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MaNganh = table.Column<int>(type: "int", nullable: false),
                    Khoa = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SDT = table.Column<string>(type: "varchar(15)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    NgayLapThe = table.Column<DateTime>(type: "date", nullable: false),
                    NgayHetHan = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocGia", x => x.MaSV);
                    table.ForeignKey(
                        name: "FK_DocGia_Nganh_MaNganh",
                        column: x => x.MaNganh,
                        principalTable: "Nganh",
                        principalColumn: "MaNganh",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sach",
                columns: table => new
                {
                    MaSach = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSach = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MaTheLoai = table.Column<int>(type: "int", nullable: false),
                    MaTacGia = table.Column<int>(type: "int", nullable: false),
                    MaNXB = table.Column<int>(type: "int", nullable: false),
                    NamXB = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    SoLuongCon = table.Column<int>(type: "int", nullable: false),
                    ViTri = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GiaBia = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    AnhBia = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sach", x => x.MaSach);
                    table.ForeignKey(
                        name: "FK_Sach_NhaXuatBan_MaNXB",
                        column: x => x.MaNXB,
                        principalTable: "NhaXuatBan",
                        principalColumn: "MaNXB",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sach_TacGia_MaTacGia",
                        column: x => x.MaTacGia,
                        principalTable: "TacGia",
                        principalColumn: "MaTacGia",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sach_TheLoai_MaTheLoai",
                        column: x => x.MaTheLoai,
                        principalTable: "TheLoai",
                        principalColumn: "MaTheLoai",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhieuMuon",
                columns: table => new
                {
                    MaPM = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSV = table.Column<int>(type: "int", nullable: false),
                    MaTK = table.Column<int>(type: "int", nullable: false),
                    NgayMuon = table.Column<DateTime>(type: "date", nullable: false),
                    HanTra = table.Column<DateTime>(type: "date", nullable: false),
                    SoLanGiaHan = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuMuon", x => x.MaPM);
                    table.ForeignKey(
                        name: "FK_PhieuMuon_DocGia_MaSV",
                        column: x => x.MaSV,
                        principalTable: "DocGia",
                        principalColumn: "MaSV",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuMuon_TaiKhoan_MaTK",
                        column: x => x.MaTK,
                        principalTable: "TaiKhoan",
                        principalColumn: "MaTK",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuMuon",
                columns: table => new
                {
                    MaPM = table.Column<int>(type: "int", nullable: false),
                    MaSach = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    NgayTra = table.Column<DateTime>(type: "date", nullable: true),
                    TinhTrangSach = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuMuon", x => new { x.MaPM, x.MaSach });
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuMuon_PhieuMuon_MaPM",
                        column: x => x.MaPM,
                        principalTable: "PhieuMuon",
                        principalColumn: "MaPM",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuMuon_Sach_MaSach",
                        column: x => x.MaSach,
                        principalTable: "Sach",
                        principalColumn: "MaSach",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhieuPhat",
                columns: table => new
                {
                    MaPP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaPM = table.Column<int>(type: "int", nullable: false),
                    MaSach = table.Column<int>(type: "int", nullable: false),
                    MaQD = table.Column<int>(type: "int", nullable: false),
                    MaTK = table.Column<int>(type: "int", nullable: false),
                    NgayLap = table.Column<DateTime>(type: "date", nullable: false),
                    SoNgayTre = table.Column<int>(type: "int", nullable: false),
                    TienPhat = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    LyDo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NgayThu = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuPhat", x => x.MaPP);
                    table.ForeignKey(
                        name: "FK_PhieuPhat_PhieuMuon_MaPM",
                        column: x => x.MaPM,
                        principalTable: "PhieuMuon",
                        principalColumn: "MaPM",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuPhat_QuyDinhPhat_MaQD",
                        column: x => x.MaQD,
                        principalTable: "QuyDinhPhat",
                        principalColumn: "MaQD",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuPhat_Sach_MaSach",
                        column: x => x.MaSach,
                        principalTable: "Sach",
                        principalColumn: "MaSach",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuPhat_TaiKhoan_MaTK",
                        column: x => x.MaTK,
                        principalTable: "TaiKhoan",
                        principalColumn: "MaTK",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuMuon_MaSach",
                table: "ChiTietPhieuMuon",
                column: "MaSach");

            migrationBuilder.CreateIndex(
                name: "IX_DocGia_MaNganh",
                table: "DocGia",
                column: "MaNganh");

            migrationBuilder.CreateIndex(
                name: "IX_DocGia_MaSV",
                table: "DocGia",
                column: "MaSV",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhieuMuon_MaSV",
                table: "PhieuMuon",
                column: "MaSV");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuMuon_MaTK",
                table: "PhieuMuon",
                column: "MaTK");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuPhat_MaPM",
                table: "PhieuPhat",
                column: "MaPM");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuPhat_MaQD",
                table: "PhieuPhat",
                column: "MaQD");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuPhat_MaSach",
                table: "PhieuPhat",
                column: "MaSach");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuPhat_MaTK",
                table: "PhieuPhat",
                column: "MaTK");

            migrationBuilder.CreateIndex(
                name: "IX_QuyDinhPhat_MaViPham",
                table: "QuyDinhPhat",
                column: "MaViPham",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sach_MaNXB",
                table: "Sach",
                column: "MaNXB");

            migrationBuilder.CreateIndex(
                name: "IX_Sach_MaTacGia",
                table: "Sach",
                column: "MaTacGia");

            migrationBuilder.CreateIndex(
                name: "IX_Sach_MaTheLoai",
                table: "Sach",
                column: "MaTheLoai");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_TenDangNhap",
                table: "TaiKhoan",
                column: "TenDangNhap",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietPhieuMuon");

            migrationBuilder.DropTable(
                name: "PhieuPhat");

            migrationBuilder.DropTable(
                name: "PhieuMuon");

            migrationBuilder.DropTable(
                name: "QuyDinhPhat");

            migrationBuilder.DropTable(
                name: "Sach");

            migrationBuilder.DropTable(
                name: "DocGia");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "NhaXuatBan");

            migrationBuilder.DropTable(
                name: "TacGia");

            migrationBuilder.DropTable(
                name: "TheLoai");

            migrationBuilder.DropTable(
                name: "Nganh");
        }
    }
}
