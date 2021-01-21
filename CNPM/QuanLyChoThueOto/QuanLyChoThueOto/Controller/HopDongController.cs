using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChoThueOto.Models;

namespace QuanLyChoThueOto.Controller
{
    class HopDongController
    {
        public static bool AddHopDong(HopDong hopdong)
        {
            using (var _context = new CNPMEntities())
            {
                _context.HopDongs.Add(hopdong);
                _context.SaveChanges();
                return true;
            }
        }
        public static bool RemoveHopDong(string MaHD)
        {
            using (CNPMEntities _context = new CNPMEntities())
            {
                var dbhd = (from hd in _context.HopDongs
                            where hd.MaHD == MaHD
                            select hd).FirstOrDefault();
                _context.HopDongs.Remove(dbhd);
                _context.SaveChanges();
                return true;
            }
        }

    }
}
