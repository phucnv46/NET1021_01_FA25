using System;
using System.Collections.Generic;

namespace KetNoiDatabase_EFCORE_NB.Models;

public partial class Sach
{
    public long MaSach { get; set; }

    public string? TenSach { get; set; }

    public int? NamXuatBan { get; set; }

    public string? NhaXuatBan { get; set; }

    public int? SoLuong { get; set; }

    public decimal? GiaTien { get; set; }
}
