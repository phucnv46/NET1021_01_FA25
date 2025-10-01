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
    public class SinhVienRepository
    {
        //Gọi các phụ thuộc
        Net102101Context _context;
        DbSet<SinhVien> _dbSet;

        public SinhVienRepository()
        {
            _context = new Net102101Context();
            _dbSet = _context.SinhViens;
        }

        public List<SinhVien> LayDSSinhVien()
        {
            return _dbSet.ToList(); // Chỉ load riêng bảng, không load các bảng quan hệ
        }

        public void Them(SinhVien SinhVien)
        {
            _dbSet.Add(SinhVien); // Thêm sách vào bảng sách 
            _context.SaveChanges(); // Lưu lại thay đổi
        }

        public void Sua(SinhVien SinhVien)
        {
            _dbSet.Update(SinhVien); // Thêm sách vào bảng sách 
            _context.SaveChanges(); // Lưu lại thay đổi
        }

        public void Xoa(SinhVien SinhVien)
        {
            _dbSet.Remove(SinhVien); // Thêm sách vào bảng sách 
            _context.SaveChanges(); // Lưu lại thay đổi
        }

        public List<SinhVien> LayDSKemBangQuanHe()
        {
            return _dbSet.Include(nameof(SinhVien.MaLopNavigation)).ToList();
        }

    }
}
