using Microsoft.EntityFrameworkCore;
using QuanLyThuVien.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyThuVien.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<TheLoai> TheLoais { get; set; }
        public DbSet<TacGia> TacGias { get; set; }
        public DbSet<NhaXuatBan> NhaXuatBans { get; set; }
        public DbSet<Sach> Sachs { get; set; }
        public DbSet<Nganh> Nganhs { get; set; }
        public DbSet<DocGia> DocGias { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<PhieuMuon> PhieuMuons { get; set; }

        public DbSet<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; }

        public DbSet<QuyDinhPhat> QuyDinhPhats { get; set; }
        public DbSet<PhieuPhat> PhieuPhats { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-ER612F1\\SQLEXPRESS;Database=QuanLyThuVien;Trusted_Connection=true;TrustServerCertificate=True;");

        }
        protected override void OnModelCreating(
           ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ======================================
            // 1. TÊN BẢNG
            // ======================================

            modelBuilder.Entity<TheLoai>().ToTable("TheLoai");
            modelBuilder.Entity<TacGia>().ToTable("TacGia");
            modelBuilder.Entity<NhaXuatBan>().ToTable("NhaXuatBan");
            modelBuilder.Entity<Sach>().ToTable("Sach");
            modelBuilder.Entity<Nganh>().ToTable("Nganh");
            modelBuilder.Entity<DocGia>().ToTable("DocGia");
            modelBuilder.Entity<TaiKhoan>().ToTable("TaiKhoan");
            modelBuilder.Entity<PhieuMuon>().ToTable("PhieuMuon");

            modelBuilder.Entity<ChiTietPhieuMuon>()
                .ToTable("ChiTietPhieuMuon");

            modelBuilder.Entity<QuyDinhPhat>()
                .ToTable("QuyDinhPhat");

            modelBuilder.Entity<PhieuPhat>()
                .ToTable("PhieuPhat");


            // ======================================
            // 2. KHÓA CHÍNH
            // ======================================

            modelBuilder.Entity<TheLoai>()
                .HasKey(x => x.MaTheLoai);

            modelBuilder.Entity<TacGia>()
                .HasKey(x => x.MaTacGia);

            modelBuilder.Entity<NhaXuatBan>()
                .HasKey(x => x.MaNXB);

            modelBuilder.Entity<Sach>()
                .HasKey(x => x.MaSach);

            modelBuilder.Entity<Nganh>()
                .HasKey(x => x.MaNganh);

            modelBuilder.Entity<DocGia>()
                .HasKey(x => x.MaDG);

            modelBuilder.Entity<TaiKhoan>()
                .HasKey(x => x.MaTK);

            modelBuilder.Entity<PhieuMuon>()
                .HasKey(x => x.MaPM);

            // Khóa chính ghép
            modelBuilder.Entity<ChiTietPhieuMuon>()
                .HasKey(x => new { x.MaPM, x.MaSach });

            modelBuilder.Entity<QuyDinhPhat>()
                .HasKey(x => x.MaQD);

            modelBuilder.Entity<PhieuPhat>()
                .HasKey(x => x.MaPP);


            // ======================================
            // 3. KHÓA DUY NHẤT
            // ======================================

            modelBuilder.Entity<DocGia>()
                .HasIndex(x => x.MaSV)
                .IsUnique();

            modelBuilder.Entity<TaiKhoan>()
                .HasIndex(x => x.TenDangNhap)
                .IsUnique();

            modelBuilder.Entity<QuyDinhPhat>()
                .HasIndex(x => x.MaViPham)
                .IsUnique();


            // ======================================
            // 4. THELOAI - SACH: 1 - N
            // ======================================

            modelBuilder.Entity<Sach>()
                .HasOne(x => x.TheLoai)
                .WithMany(x => x.Sachs)
                .HasForeignKey(x => x.MaTheLoai)
                .OnDelete(DeleteBehavior.Restrict);


            // ======================================
            // 5. TACGIA - SACH: 1 - N
            // ======================================

            modelBuilder.Entity<Sach>()
                .HasOne(x => x.TacGia)
                .WithMany(x => x.Sachs)
                .HasForeignKey(x => x.MaTacGia)
                .OnDelete(DeleteBehavior.Restrict);


            // ======================================
            // 6. NHAXUATBAN - SACH: 1 - N
            // ======================================

            modelBuilder.Entity<Sach>()
                .HasOne(x => x.NhaXuatBan)
                .WithMany(x => x.Sachs)
                .HasForeignKey(x => x.MaNXB)
                .OnDelete(DeleteBehavior.Restrict);


            // ======================================
            // 7. NGANH - DOCGIA: 1 - N
            // ======================================

            modelBuilder.Entity<DocGia>()
                .HasOne(x => x.Nganh)
                .WithMany(x => x.DocGias)
                .HasForeignKey(x => x.MaNganh)
                .OnDelete(DeleteBehavior.Restrict);


            // ======================================
            // 8. DOCGIA - PHIEUMUON: 1 - N
            // ======================================

            modelBuilder.Entity<PhieuMuon>()
                .HasOne(x => x.DocGia)
                .WithMany(x => x.PhieuMuons)
                .HasForeignKey(x => x.MaDG)
                .OnDelete(DeleteBehavior.Restrict);


            // ======================================
            // 9. TAIKHOAN - PHIEUMUON: 1 - N
            // ======================================

            modelBuilder.Entity<PhieuMuon>()
                .HasOne(x => x.TaiKhoan)
                .WithMany(x => x.PhieuMuons)
                .HasForeignKey(x => x.MaTK)
                .OnDelete(DeleteBehavior.Restrict);


            // ======================================
            // 10. PHIEUMUON - CHITIETPHIEUMUON: 1 - N
            // ======================================

            modelBuilder.Entity<ChiTietPhieuMuon>()
                .HasOne(x => x.PhieuMuon)
                .WithMany(x => x.ChiTietPhieuMuons)
                .HasForeignKey(x => x.MaPM)
                .OnDelete(DeleteBehavior.Restrict);


            // ======================================
            // 11. SACH - CHITIETPHIEUMUON: 1 - N
            // ======================================

            modelBuilder.Entity<ChiTietPhieuMuon>()
                .HasOne(x => x.Sach)
                .WithMany(x => x.ChiTietPhieuMuons)
                .HasForeignKey(x => x.MaSach)
                .OnDelete(DeleteBehavior.Restrict);


            // ======================================
            // 12. PHIEUMUON - PHIEUPHAT: 1 - N
            // ======================================

            modelBuilder.Entity<PhieuPhat>()
                .HasOne(x => x.PhieuMuon)
                .WithMany(x => x.PhieuPhats)
                .HasForeignKey(x => x.MaPM)
                .OnDelete(DeleteBehavior.Restrict);


            // ======================================
            // 13. SACH - PHIEUPHAT: 1 - N
            // ======================================

            modelBuilder.Entity<PhieuPhat>()
                .HasOne(x => x.Sach)
                .WithMany(x => x.PhieuPhats)
                .HasForeignKey(x => x.MaSach)
                .OnDelete(DeleteBehavior.Restrict);


            // ======================================
            // 14. QUYDINHPHAT - PHIEUPHAT: 1 - N
            // ======================================

            modelBuilder.Entity<PhieuPhat>()
                .HasOne(x => x.QuyDinhPhat)
                .WithMany(x => x.PhieuPhats)
                .HasForeignKey(x => x.MaQD)
                .OnDelete(DeleteBehavior.Restrict);


            // ======================================
            // 15. TAIKHOAN - PHIEUPHAT: 1 - N
            // ======================================

            modelBuilder.Entity<PhieuPhat>()
                .HasOne(x => x.TaiKhoan)
                .WithMany(x => x.PhieuPhat)
                .HasForeignKey(x => x.MaTK)
                .OnDelete(DeleteBehavior.Restrict);


            // ======================================
            // 16. KIỂU DỮ LIỆU VÀ ĐỘ DÀI
            // ======================================

            modelBuilder.Entity<TheLoai>()
                .Property(x => x.TenTheLoai)
                .HasMaxLength(100);

            modelBuilder.Entity<TacGia>()
                .Property(x => x.TenTacGia)
                .HasMaxLength(100);

            modelBuilder.Entity<NhaXuatBan>()
                .Property(x => x.TenNXB)
                .HasMaxLength(100);

            modelBuilder.Entity<Nganh>()
                .Property(x => x.TenNganh)
                .HasMaxLength(100);

            modelBuilder.Entity<Sach>(entity =>
            {
                entity.Property(x => x.TenSach)
                    .HasMaxLength(200);

                entity.Property(x => x.ViTri)
                    .HasMaxLength(50);

                entity.Property(x => x.GiaBia)
                    .HasColumnType("decimal(18,0)");

                entity.Property(x => x.AnhBia)
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DocGia>(entity =>
            {
                entity.Property(x => x.MaSV)
                    .HasMaxLength(20);

                entity.Property(x => x.HoTen)
                    .HasMaxLength(100);

                entity.Property(x => x.Khoa)
                    .HasMaxLength(10);

                entity.Property(x => x.SDT)
                    .HasColumnType("varchar(15)");

                entity.Property(x => x.Email)
                    .HasColumnType("varchar(100)");

                entity.Property(x => x.NgayLapThe)
                    .HasColumnType("date");

                entity.Property(x => x.NgayHetHan)
                    .HasColumnType("date");
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.Property(x => x.MaTK)
                    .HasColumnOrder(0);

                entity.Property(x => x.TenDangNhap)
                    .HasMaxLength(50)
                    .HasColumnOrder(1)
                    .IsRequired();

                entity.Property(x => x.MatKhau)
                    .HasMaxLength(255)
                    .HasColumnOrder(2)
                    .IsRequired();

                entity.Property(x => x.HoTen)
                    .HasMaxLength(100)
                    .HasColumnOrder(3)
                    .IsRequired();

                entity.Property(x => x.GioiTinh)
                    .HasMaxLength(10)
                    .HasColumnOrder(4)
                    .IsRequired(false);

                entity.Property(x => x.SDT)
                    .HasColumnType("varchar(15)")
                    .HasColumnOrder(6)
                    .IsRequired(false);

                entity.Property(x => x.Email)
                    .HasColumnType("varchar(100)")
                    .HasColumnOrder(7)
                    .IsRequired(false);

                entity.Property(x => x.DiaChi)
                    .HasMaxLength(200)
                    .HasColumnOrder(8)
                    .IsRequired(false);

                entity.Property(x => x.VaiTro)
                    .HasMaxLength(20)
                    .HasColumnOrder(9)
                    .IsRequired(false);

                entity.Property(x => x.NgaySinh)
                    .HasColumnType("date")
                    .HasColumnOrder(5)
                    .IsRequired(false);

            });

            modelBuilder.Entity<PhieuMuon>(entity =>
            {
                entity.Property(x => x.NgayMuon)
                    .HasColumnType("date");

                entity.Property(x => x.HanTra)
                    .HasColumnType("date");

                entity.Property(x => x.TrangThai)
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ChiTietPhieuMuon>(entity =>
            {
                entity.Property(x => x.NgayTra)
                    .HasColumnType("date");

                entity.Property(x => x.TinhTrangSach)
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<QuyDinhPhat>(entity =>
            {
                entity.Property(x => x.MaViPham)
                    .HasMaxLength(20);

                entity.Property(x => x.TenQuyDinh)
                    .HasMaxLength(100);

                entity.Property(x => x.KieuTinh)
                    .HasMaxLength(20);

                entity.Property(x => x.MucPhat)
                    .HasColumnType("decimal(18,2)");

                entity.Property(x => x.TranPhat)
                    .HasColumnType("decimal(5,2)");
            });

            modelBuilder.Entity<PhieuPhat>(entity =>
            {
                entity.Property(x => x.NgayLap)
                    .HasColumnType("date");

                entity.Property(x => x.NgayThu)
                    .HasColumnType("date");

                entity.Property(x => x.TienPhat)
                    .HasColumnType("decimal(18,0)");

                entity.Property(x => x.LyDo)
                    .HasMaxLength(200);

                entity.Property(x => x.TrangThai)
                    .HasMaxLength(20);
            });
        }
    }
}


