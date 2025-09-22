using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlsTapHop.Models
{
    public class Mon 
    {
        [DisplayName("Mã môn")]
        public string MaMon { get; set; } = "Chưa rõ";

        public string TenMon { get; set; } = "Chưa rõ";

        public uint KyHoc { get; set; }
    }
}
