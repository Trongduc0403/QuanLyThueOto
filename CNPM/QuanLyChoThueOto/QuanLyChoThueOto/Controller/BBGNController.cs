using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChoThueOto.Models;

namespace QuanLyChoThueOto.Controller
{
    class BBGNController
    {
        public static bool AddBBGN(BBGN bbgn)
        {
            using (var _context = new CNPMEntities())
            {
                _context.BBGNs.Add(bbgn);
                _context.SaveChanges();
                return true;
            }
        }
        public static bool RemoveBBGN(string MaBBGN)
        {
            using (CNPMEntities _context = new CNPMEntities())
            {
                var dbbbgn = (from bbgn in _context.BBGNs
                            where bbgn.MaBBGN == MaBBGN
                            select bbgn).FirstOrDefault();
                _context.BBGNs.Remove(dbbbgn);
                _context.SaveChanges();
                return true;
            }
        }
    }
}
