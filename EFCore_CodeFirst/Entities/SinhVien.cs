
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_CodeFirst.Entities
{
    [Table("sinhvien")]
    public class SinhVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        // [Column("ho_ten")]
        [StringLength(500)]
        [Unicode]
        
        public string HoTen { get; set; } // Từ chuyển thành kiểu nvarchar(max)


        public DateOnly? NgaySinh { get; set; }

        public bool GioiTinh { get; set; } // chuyển thành bit (0,1)

        [StringLength(500)]
        public string? DiaChi { get; set; }

        //Shadow property
 
        public Lop Lop { get; set; }
    }
}
