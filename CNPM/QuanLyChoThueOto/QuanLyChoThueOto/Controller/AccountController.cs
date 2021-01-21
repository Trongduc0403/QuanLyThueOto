using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using QuanLyChoThueOto.Models;

namespace QuanLyChoThueOto.Controller
{
    class AccountController
    {
        public static bool AddAccount(Account a)
        {
            using (var _context = new CNPMEntities())
            {
                _context.Accounts.Add(a);
                _context.SaveChanges();
                return true;
            }
        }

        public static bool RemoveAccount(string a)
        {
            using (CNPMEntities _context = new CNPMEntities())
            {
                var getaccount = (from ac in _context.Accounts
                            where ac.TaiKhoan == a
                            select ac).FirstOrDefault();
                _context.Accounts.Remove(getaccount);
                _context.SaveChanges();
                return true;
            }
        }

        public static string SHA256(string MatKhau)
        {
            try
            {
                SHA256Managed crypt = new SHA256Managed();
                string hash = string.Empty;
                byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(MatKhau), 0, Encoding.UTF8.GetByteCount(MatKhau));
                foreach(byte bit in crypto)
                {
                    hash += bit.ToString("x2");
                }
                return hash;
            }
            catch
            {
                return null;
            }
        }
        

    }
}
