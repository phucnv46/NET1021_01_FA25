using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GioiThieuLinQ.Models
{
    public class Giay
    {
        public int MaGiay { get; set; }

        public string TenGiay { get; set; }

        public string? Hang { get; set; }

        public string? ChatLieu { get; set; }

        public GioiTinh? GioiTinh { get; set; }

        public ICollection<BienThe> DSBienThe { get; set; } = new List<BienThe>();

    }

    public enum GioiTinh
    {
        Nam, Nu, Unisex
    }

}
