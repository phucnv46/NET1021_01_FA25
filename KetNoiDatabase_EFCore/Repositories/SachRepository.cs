using KetNoiDatabase_EFCore.Data;
using KetNoiDatabase_EFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetNoiDatabase_EFCore.Repositories
{
    public class SachRepository //Giao tiếp code và database của bảng Sách
    {
        Net102101Context _context;
        DbSet<Sach> _dbSet;

        public SachRepository()
        {
            _context = new Net102101Context();
            _dbSet = _context.Saches;
        }

        public List<Sach> LayDanhSach() // Lấy danh sách các bản ghi
        {
            return _dbSet.ToList(); // Chuyển bảng sách thành list
        }

        public void Them(Sach sach)
        {
            _dbSet.Add(sach); // Thêm sách vào bảng sách 
            _context.SaveChanges(); // Lưu lại thay đổi
        }

        public void Sua(Sach sach)
        {
            _dbSet.Update(sach); // Thêm sách vào bảng sách 
            _context.SaveChanges(); // Lưu lại thay đổi
        }

        public void Xoa(Sach sach)
        {
            _dbSet.Remove(sach); // Thêm sách vào bảng sách 
            _context.SaveChanges(); // Lưu lại thay đổi
        }
    }
}
