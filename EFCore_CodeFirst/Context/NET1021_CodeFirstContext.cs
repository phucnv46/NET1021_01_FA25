using EFCore_CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_CodeFirst.Context
{

    public class NET1021_CodeFirstContext : DbContext
    {
    

        public virtual DbSet<SinhVien> SinhVien { get; set; }
        public virtual DbSet<Lop> Lop { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=NET1021_01_CodeFirst;User Id=sa;Password=MatKhauManh123!;TrustServerCertificate=True;");
        }
    }
}
