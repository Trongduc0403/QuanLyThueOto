using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChoThueOto.Models;
using QuanLyChoThueOto.Controller;

namespace QuanLyChoThueOto.Controller
{
    class NhanVienController
    {
        public static bool AddNhanVien(NhanVien nhanvien)
        {
            using (var _context = new CNPMEntities())
            {
                _context.NhanViens.Add(nhanvien);
                _context.SaveChanges();
                return true;
            }
        }

        public static bool RemoveNhanVien(string MaNV)
        {
            using (CNPMEntities _context = new CNPMEntities())
            {
                var dbnv = (from nv in _context.NhanViens
                            where nv.MaNV == MaNV
                            select nv).FirstOrDefault();
                _context.NhanViens.Remove(dbnv);
                _context.SaveChanges();
                return true;
            }
        }
    }
}
