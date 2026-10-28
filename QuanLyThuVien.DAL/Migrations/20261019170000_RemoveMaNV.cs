using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyThuVien.DAL.Migrations
{
    public partial class RemoveMaNV : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TaiKhoan_MaNV",
                table: "TaiKhoan");

            migrationBuilder.DropColumn(
                name: "MaNV",
                table: "TaiKhoan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MaNV",
                table: "TaiKhoan",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.Sql("UPDATE [TaiKhoan] SET [MaNV] = [TenDangNhap]");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_MaNV",
                table: "TaiKhoan",
                column: "MaNV",
                unique: true);
        }
    }
}
