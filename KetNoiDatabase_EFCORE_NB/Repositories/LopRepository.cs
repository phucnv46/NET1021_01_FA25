using KetNoiDatabase_EFCORE_NB.Data;
using KetNoiDatabase_EFCORE_NB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetNoiDatabase_EFCORE_NB.Repositories
{
    public class LopRepository
    {
        //Gọi các phụ thuộc
        Net102101Context _context;
        DbSet<Lop> _dbSet;

        public LopRepository()
        {
            _context = new Net102101Context();
            _dbSet = _context.Lops;
        }

        public List<Lop> LayDSLop()
        {
            return _dbSet.ToList();
        }

        public void Them(Lop Lop)
        {
            _dbSet.Add(Lop); // Thêm sách vào bảng sách 
            _context.SaveChanges(); // Lưu lại thay đổi
        }

        public void Sua(Lop Lop)
        {
            _dbSet.Update(Lop); // Thêm sách vào bảng sách 
            _context.SaveChanges(); // Lưu lại thay đổi
        }

        public void Xoa(Lop Lop)
        {
            _dbSet.Remove(Lop); // Thêm sách vào bảng sách 
            _context.SaveChanges(); // Lưu lại thay đổi
        }

    }
}
