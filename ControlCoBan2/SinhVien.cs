using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlCoBan2
{
    public class SinhVien // public : quyền truy cập cho phép truy cập từ mọi nơi
    {
        //2 loại thuộc tính :
        //+ auto-property: loại ngắn gọn
        //+ full property: loại đầy đủ

        //Auto-property : snip: prop + tab

        public string MaSV { get; set; }

        /* Full-property : snip: propf + tab
         field để tương tác với thuộc tính
         */

        public string HoTen { get; set; } = "Chưa rõ"; // Khởi tạo giá trị mặc định 

        public DateTime NgaySinh { get; set; }

        public string Lop { get; set; } = "Chưa rõ";

        public bool GioiTinh { get; set; }

        public string? DiaChi { get; set; }

        public override string? ToString()
        {
            return $"Thông tin sinh viên:\n" +
                $"+Mã sinh viên: {MaSV}\n" +
                $"+Họ tên: {HoTen}\n" +
                $"+Ngày sinh: {NgaySinh.ToShortDateString()}\n" +
                $"+Giới Tính: {(GioiTinh ? "Nam" : "Nữ")}\n" +
                $"+Lớp: {Lop}\n" +
                $"Địa chỉ: {DiaChi}";
        }
    }
}
