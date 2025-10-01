using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace KetNoiDatabase_EFCORE_NB.Models;

public partial class SinhVien
{
    public string MaSinhVien { get; set; } = null!;

    public string TenSinhVien { get; set; } = null!;

    public DateOnly NgaySinh { get; set; }

    public string? DiaChi { get; set; }

    public string? MaLop { get; set; }

    [Browsable(false)]
    public virtual Lop? MaLopNavigation { get; set; } // Thuộc tính quan hệ (liên kết)

    public string TenLop { get 
        {
            return MaLopNavigation?.TenLop ?? "Chưa có thông tin";
        } 
    }
}
