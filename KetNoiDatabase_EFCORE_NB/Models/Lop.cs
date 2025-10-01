using System;
using System.Collections.Generic;

namespace KetNoiDatabase_EFCORE_NB.Models;

public partial class Lop
{
    public string MaLop { get; set; } = null!;

    public string? TenLop { get; set; }

    public int? KyHoc { get; set; }

    public string? MonHoc { get; set; }

    public virtual ICollection<SinhVien> SinhViens { get; set; } = new List<SinhVien>();
}
