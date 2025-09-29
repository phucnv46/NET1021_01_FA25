using System;
using System.Collections.Generic;
using KetNoiDatabase_EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace KetNoiDatabase_EFCore.Data;

public partial class Net102101Context : DbContext
{
    public Net102101Context()
    {
    }

    public Net102101Context(DbContextOptions<Net102101Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Sach> Saches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=NET1021_01;User Id=sa;Password=MatKhauManh123!;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sach>(entity =>
        {
            entity.HasKey(e => e.MaSach).HasName("PK__Sach__B235742DE9B5A970");

            entity.ToTable("Sach");

            entity.Property(e => e.GiaTien).HasColumnType("money");
            entity.Property(e => e.NhaXuatBan).HasMaxLength(255);
            entity.Property(e => e.TenSach).HasMaxLength(500);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
