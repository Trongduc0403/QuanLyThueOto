using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChoThueOto.Models;

namespace QuanLyChoThueOto.Controller
{
    class XeController
    {
        public static bool AddXe(Xe xe)
        {
            using (var _context = new CNPMEntities())
            {
                _context.Xes.Add(xe);
                _context.SaveChanges();
                return true;
            }
        }
        public static bool RemoveXe(string BSX)
        {
            using (CNPMEntities _context = new CNPMEntities())
            {
                var dbxe = (from xe in _context.Xes
                            where xe.Biensoxe == BSX
                            select xe).FirstOrDefault();
                _context.Xes.Remove(dbxe);
                _context.SaveChanges();
                return true;
            }
        }
    }
}
