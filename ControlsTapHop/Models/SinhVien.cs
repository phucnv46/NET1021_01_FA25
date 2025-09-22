using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlsTapHop.Models
{
    public class SinhVien
    {
        public string Ma { get; set; }

        public string HoTen { get; set; }

        public DateOnly NgaySinh { get; set; }

        public bool GioiTinh { get; set; }
    }
}
