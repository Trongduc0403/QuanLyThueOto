using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChoThueOto.Controller;
using QuanLyChoThueOto.Models;

namespace QuanLyChoThueOto.Controller
{
    class KhachHangController
    {
        public static bool AddKhachHang(KhachHang khachhang  )
        {
            using (var _context = new CNPMEntities())
            {
                _context.KhachHangs.Add(khachhang);
                _context.SaveChanges();
                return true;
            }
        }
        public static bool RemoveKhachHang(string MaKH)
        {
            using (CNPMEntities _context = new CNPMEntities())
            {
                var dbkh = (from kh in _context.KhachHangs
                            where kh.MaKH == MaKH
                            select kh).FirstOrDefault();
                _context.KhachHangs.Remove(dbkh);
                _context.SaveChanges();
                return true;
            }
        }

    }
}
