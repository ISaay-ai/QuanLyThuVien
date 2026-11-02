using Microsoft.EntityFrameworkCore;
using QuanLyThuVien.DAL.Models;

namespace QuanLyThuVien.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

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
            // Dự phòng khi gọi DbContext không qua Dependency Injection
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=QuanLyThuVien;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ======================================
            // 1. TÊN BẢNG & KHÓA CHÍNH
            // ======================================
            modelBuilder.Entity<TheLoai>(e => { e.ToTable("TheLoai"); e.HasKey(x => x.MaTheLoai); });
            modelBuilder.Entity<TacGia>(e => { e.ToTable("TacGia"); e.HasKey(x => x.MaTacGia); });
            modelBuilder.Entity<NhaXuatBan>(e => { e.ToTable("NhaXuatBan"); e.HasKey(x => x.MaNXB); });
            modelBuilder.Entity<Sach>(e => { e.ToTable("Sach"); e.HasKey(x => x.MaSach); });
            modelBuilder.Entity<Nganh>(e => { e.ToTable("Nganh"); e.HasKey(x => x.MaNganh); });
            modelBuilder.Entity<DocGia>(e => { e.ToTable("DocGia"); e.HasKey(x => x.MaSV); });
            modelBuilder.Entity<TaiKhoan>(e => { e.ToTable("TaiKhoan"); e.HasKey(x => x.MaTK); });
            modelBuilder.Entity<PhieuMuon>(e => { e.ToTable("PhieuMuon"); e.HasKey(x => x.MaPM); });
            modelBuilder.Entity<QuyDinhPhat>(e => { e.ToTable("QuyDinhPhat"); e.HasKey(x => x.MaQD); });
            modelBuilder.Entity<PhieuPhat>(e => { e.ToTable("PhieuPhat"); e.HasKey(x => x.MaPP); });

            // Khóa chính ghép
            modelBuilder.Entity<ChiTietPhieuMuon>(e =>
            {
                e.ToTable("ChiTietPhieuMuon");
                e.HasKey(x => new { x.MaPM, x.MaSach });
            });

            // ======================================
            // 2. KHÓA DUY NHẤT (UNIQUE INDEX)
            // ======================================
            modelBuilder.Entity<DocGia>().HasIndex(x => x.MaSV).IsUnique();
            modelBuilder.Entity<TaiKhoan>().HasIndex(x => x.TenDangNhap).IsUnique();
            modelBuilder.Entity<QuyDinhPhat>().HasIndex(x => x.MaViPham).IsUnique();

            // ======================================
            // 3. QUAN HỆ (RELATIONSHIPS)
            // ======================================
            modelBuilder.Entity<Sach>()
                .HasOne(x => x.TheLoai).WithMany(x => x.Sachs).HasForeignKey(x => x.MaTheLoai).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Sach>()
                .HasOne(x => x.TacGia).WithMany(x => x.Sachs).HasForeignKey(x => x.MaTacGia).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Sach>()
                .HasOne(x => x.NhaXuatBan).WithMany(x => x.Sachs).HasForeignKey(x => x.MaNXB).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DocGia>()
                .HasOne(x => x.Nganh).WithMany(x => x.DocGias).HasForeignKey(x => x.MaNganh).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PhieuMuon>()
                .HasOne(x => x.DocGia).WithMany(x => x.PhieuMuons).HasForeignKey(x => x.MaSV).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PhieuMuon>()
                .HasOne(x => x.TaiKhoan).WithMany(x => x.PhieuMuons).HasForeignKey(x => x.MaTK).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ChiTietPhieuMuon>()
                .HasOne(x => x.PhieuMuon).WithMany(x => x.ChiTietPhieuMuons).HasForeignKey(x => x.MaPM).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ChiTietPhieuMuon>()
                .HasOne(x => x.Sach).WithMany(x => x.ChiTietPhieuMuons).HasForeignKey(x => x.MaSach).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PhieuPhat>()
                .HasOne(x => x.PhieuMuon).WithMany(x => x.PhieuPhats).HasForeignKey(x => x.MaPM).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PhieuPhat>()
                .HasOne(x => x.Sach).WithMany(x => x.PhieuPhats).HasForeignKey(x => x.MaSach).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PhieuPhat>()
                .HasOne(x => x.QuyDinhPhat).WithMany(x => x.PhieuPhats).HasForeignKey(x => x.MaQD).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PhieuPhat>()
                .HasOne(x => x.TaiKhoan).WithMany(x => x.PhieuPhat).HasForeignKey(x => x.MaTK).OnDelete(DeleteBehavior.Restrict);

            // ======================================
            // 4. KIỂU DỮ LIỆU VÀ ĐỘ DÀI
            // ======================================
            modelBuilder.Entity<TheLoai>().Property(x => x.TenTheLoai).HasMaxLength(100);
            modelBuilder.Entity<TacGia>().Property(x => x.TenTacGia).HasMaxLength(100);
            modelBuilder.Entity<NhaXuatBan>().Property(x => x.TenNXB).HasMaxLength(100);
            modelBuilder.Entity<Nganh>().Property(x => x.TenNganh).HasMaxLength(100);

            modelBuilder.Entity<Sach>(entity =>
            {
                entity.Property(x => x.TenSach).HasMaxLength(200);
                entity.Property(x => x.ViTri).HasMaxLength(50);
                entity.Property(x => x.GiaBia).HasPrecision(18, 0);
                entity.Property(x => x.AnhBia).HasMaxLength(255);
            });

            modelBuilder.Entity<DocGia>(entity =>
            {
                entity.Property(x => x.MaSV).HasMaxLength(20);
                entity.Property(x => x.HoTen).HasMaxLength(100);
                entity.Property(x => x.Khoa).HasMaxLength(10);
                entity.Property(x => x.SDT).IsUnicode(false).HasMaxLength(15);
                entity.Property(x => x.Email).IsUnicode(false).HasMaxLength(100);
                entity.Property(x => x.NgayLapThe).HasColumnType("date");
                entity.Property(x => x.NgayHetHan).HasColumnType("date");
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.Property(x => x.TenDangNhap).HasMaxLength(50).IsRequired();
                entity.Property(x => x.MatKhau).HasMaxLength(255).IsRequired();
                entity.Property(x => x.HoTen).HasMaxLength(100).IsRequired();
                entity.Property(x => x.GioiTinh).HasMaxLength(10);
                entity.Property(x => x.SDT).IsUnicode(false).HasMaxLength(15);
                entity.Property(x => x.Email).IsUnicode(false).HasMaxLength(100);
                entity.Property(x => x.DiaChi).HasMaxLength(200);
                entity.Property(x => x.VaiTro).HasMaxLength(20);
                entity.Property(x => x.NgaySinh).HasColumnType("date");
            });

            modelBuilder.Entity<PhieuMuon>(entity =>
            {
                entity.Property(x => x.NgayMuon).HasColumnType("date");
                entity.Property(x => x.HanTra).HasColumnType("date");
                entity.Property(x => x.TrangThai).HasMaxLength(20);
            });

            modelBuilder.Entity<ChiTietPhieuMuon>(entity =>
            {
                entity.Property(x => x.NgayTra).HasColumnType("date");
                entity.Property(x => x.TinhTrangSach).HasMaxLength(20);
            });

            modelBuilder.Entity<QuyDinhPhat>(entity =>
            {
                entity.Property(x => x.MaViPham).HasMaxLength(20);
                entity.Property(x => x.TenQuyDinh).HasMaxLength(100);
                entity.Property(x => x.KieuTinh).HasMaxLength(20);
                entity.Property(x => x.MucPhat).HasPrecision(18, 2);
                entity.Property(x => x.TranPhat).HasPrecision(18, 2);
            });

            modelBuilder.Entity<PhieuPhat>(entity =>
            {
                entity.Property(x => x.NgayLap).HasColumnType("date");
                entity.Property(x => x.NgayThu).HasColumnType("date");
                entity.Property(x => x.TienPhat).HasPrecision(18, 0);
                entity.Property(x => x.LyDo).HasMaxLength(200);
                entity.Property(x => x.TrangThai).HasMaxLength(20);
            });
        }
    }
}