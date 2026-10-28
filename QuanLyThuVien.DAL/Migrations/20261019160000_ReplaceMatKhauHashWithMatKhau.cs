using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyThuVien.DAL.Migrations
{
    public partial class ReplaceMatKhauHashWithMatKhau : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MatKhauHash",
                table: "TaiKhoan",
                newName: "MatKhau");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MatKhau",
                table: "TaiKhoan",
                newName: "MatKhauHash");
        }
    }
}
