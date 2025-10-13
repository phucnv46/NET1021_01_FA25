using System;
using System.Collections.Generic;

namespace ChuaDeMau1.Models;

public partial class NhanVien
{
    public NhanVien()
    {
    }

    public string MaNhanVien { get; set; } = null!;

    public string? TenNhanVien { get; set; }

    public string? GioiTinh { get; set; }

    public string? ChucVu { get; set; }

    public NhanVien(string maNhanVien, string? tenNhanVien, string? gioiTinh, string? chucVu)
    {
        MaNhanVien = maNhanVien;
        TenNhanVien = tenNhanVien;
        GioiTinh = gioiTinh;
        ChucVu = chucVu;
    }
}
