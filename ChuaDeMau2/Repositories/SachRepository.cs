using ChuaDeMau2.Context;
using ChuaDeMau2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaDeMau2.Repositories
{
    public class SachRepository
    {
        Net102101CdContext _context; // Đại diện cho database trong code
        DbSet<Sach> _dbSet; // đại diện cho bảng sách

        public SachRepository()
        {
            _context = new Net102101CdContext(); // Khởi tạo dbContext 
            _dbSet = _context.Saches;
        }


        public List<Sach> GetAll()
        {
            return _dbSet.ToList(); // chuyển bảng thành list
        }

        public void Them(Sach sach) // truyền vào model của đề bài 
        {
            _dbSet.Add(sach);
            _context.SaveChanges();
        }

        public void Sua(Sach sach) // truyền vào model của đề bài 
        {
            _dbSet.Update(sach); // cập nhật thông tin của bảng
            _context.SaveChanges();
        }

        public void Xoa(Sach sach) // truyền vào model của đề bài 
        {
            _dbSet.Remove(sach); // xóa bản ghi trong bảng 
            _context.SaveChanges();
        }

    }
}
