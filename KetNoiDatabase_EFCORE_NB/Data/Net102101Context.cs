using System;
using System.Collections.Generic;
using KetNoiDatabase_EFCORE_NB.Models;
using Microsoft.EntityFrameworkCore;

namespace KetNoiDatabase_EFCORE_NB.Data;

public partial class Net102101Context : DbContext
{
    public Net102101Context()
    {
    }

    public Net102101Context(DbContextOptions<Net102101Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Lop> Lops { get; set; }

    public virtual DbSet<Sach> Saches { get; set; }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=NET1021_01;User Id=sa;Password=MatKhauManh123!;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Lop>(entity =>
        {
            entity.HasKey(e => e.MaLop).HasName("PK__Lop__3B98D27383DE0C31");

            entity.ToTable("Lop");

            entity.Property(e => e.MaLop).HasMaxLength(10);
            entity.Property(e => e.MonHoc).HasMaxLength(255);
            entity.Property(e => e.TenLop).HasMaxLength(50);
        });

        modelBuilder.Entity<Sach>(entity =>
        {
            entity.HasKey(e => e.MaSach).HasName("PK__Sach__B235742DE9B5A970");

            entity.ToTable("Sach");

            entity.Property(e => e.GiaTien).HasColumnType("money");
            entity.Property(e => e.NhaXuatBan).HasMaxLength(255);
            entity.Property(e => e.TenSach).HasMaxLength(500);
        });

        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.HasKey(e => e.MaSinhVien).HasName("PK__SinhVien__939AE775685B4CEE");

            entity.ToTable("SinhVien");

            entity.Property(e => e.MaSinhVien).HasMaxLength(50);
            entity.Property(e => e.DiaChi).HasMaxLength(500);
            entity.Property(e => e.MaLop).HasMaxLength(10);
            entity.Property(e => e.TenSinhVien).HasMaxLength(255);

            entity.HasOne(d => d.MaLopNavigation).WithMany(p => p.SinhViens)
                .HasForeignKey(d => d.MaLop)
                .HasConstraintName("FK__SinhVien__MaLop__5629CD9C");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
