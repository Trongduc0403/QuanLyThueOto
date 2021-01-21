using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChoThueOto.Models;

namespace QuanLyChoThueOto.Controller
{
    class LoaiXeController
    {
        public static bool AddLoaiXe(LoaiXe loaixe)
        {
            using (var _context = new CNPMEntities())
            {
                _context.LoaiXes.Add(loaixe);
                _context.SaveChanges();
                return true;
            }
        }
        public static bool RemoveLoaiXe(string TenLoai)
        {
            using (CNPMEntities _context = new CNPMEntities())
            {
                var dblx = (from lx in _context.LoaiXes
                            where lx.TenLoai == TenLoai
                            select lx).FirstOrDefault();
                _context.LoaiXes.Remove(dblx);
                _context.SaveChanges();
                return true;
            }
        }
    }
}
