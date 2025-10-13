using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore_CodeFirst.Entities
{
    public class Lop
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int MaLop { get; set; }

        [Required]
        public string TenLop { get; set; }

        public List<SinhVien> SinhViens { get; set; } = new List<SinhVien>();
    }
}