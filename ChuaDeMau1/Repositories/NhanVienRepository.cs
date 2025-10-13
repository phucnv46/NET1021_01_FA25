using ChuaDeMau1.Data;
using ChuaDeMau1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaDeMau1.Repositories
{
    public class NhanVienRepository
    {
        Net102101Context _context; // Đại diện cho database
        DbSet<NhanVien> _set; // Đại diện cho bảng nhân viên


        public NhanVienRepository()
        {
            _context = new Net102101Context();
            _set = _context.NhanViens;
        }

        public List<NhanVien> GetAll()
        {
            return _set.ToList(); // chuyển bảng thành danh sách 
        }

        public void Them(NhanVien nhanVien)
        {
            _set.Add(nhanVien);
            _context.SaveChanges();
        }

        public void Sua(NhanVien nhanVien)
        {
            _set.Update(nhanVien);
            _context.SaveChanges();
        }

        public void Xoa(NhanVien nhanVien)
        {
            _set.Remove(nhanVien);
            _context.SaveChanges();
        }
    }
}
