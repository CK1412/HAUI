using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace de_07.model
{
    public partial class QLDuocPhamContext : DbContext
    {
        public QLDuocPhamContext()
        {
        }

        public QLDuocPhamContext(DbContextOptions<QLDuocPhamContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DanhMucThuoc> DanhMucThuocs { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<Thuoc> Thuocs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=COOL-KID\\SQLEXPRESS;Initial Catalog=QLDuocPham;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<DanhMucThuoc>(entity =>
            {
                entity.HasKey(e => e.MaDm)
                    .HasName("PK__DanhMucT__2725866EE67D25C9");

                entity.ToTable("DanhMucThuoc");

                entity.Property(e => e.MaDm)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaDM");

                entity.Property(e => e.TenDm)
                    .HasMaxLength(50)
                    .HasColumnName("TenDM");
            });

            modelBuilder.Entity<NhaCungCap>(entity =>
            {
                entity.HasKey(e => e.MaNcc)
                    .HasName("PK__NhaCungC__3A185DEBCC97A384");

                entity.ToTable("NhaCungCap");

                entity.Property(e => e.MaNcc)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaNCC");

                entity.Property(e => e.SoDt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SoDT");

                entity.Property(e => e.TenNcc)
                    .HasMaxLength(30)
                    .HasColumnName("TenNCC");
            });

            modelBuilder.Entity<Thuoc>(entity =>
            {
                entity.HasKey(e => e.MaThuoc)
                    .HasName("PK__Thuoc__4BB1F620A8F8BA31");

                entity.ToTable("Thuoc");

                entity.Property(e => e.MaThuoc)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaDm)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MaDM");

                entity.Property(e => e.TenThuoc).HasMaxLength(30);

                entity.HasOne(d => d.MaDmNavigation)
                    .WithMany(p => p.Thuocs)
                    .HasForeignKey(d => d.MaDm)
                    .HasConstraintName("FK__Thuoc__MaDM__38996AB5");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
