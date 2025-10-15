using System;
using System.Collections.Generic;
using ChuaDeMau2.Models;
using Microsoft.EntityFrameworkCore;

namespace ChuaDeMau2.Context;

public partial class Net102101CdContext : DbContext
{
    public Net102101CdContext()
    {
    }

    public Net102101CdContext(DbContextOptions<Net102101CdContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Sach> Saches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=NET1021_01_CD;User Id=sa;Password=MatKhauManh123!;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sach>(entity =>
        {
            entity.HasKey(e => e.MaSach).HasName("PK__Sach__B235742DE1D11746");

            entity.ToTable("Sach");

            entity.Property(e => e.MaSach)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DonGia).HasColumnType("money");
            entity.Property(e => e.TenSach).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
