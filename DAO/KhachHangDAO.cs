using EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachHangDAO
    {
        static Model db;
        public static khachhang login(string email, string pwd)
        {
            using (db = new Model())
            {
                khachhang kh = db.khachhangs.Where(x => x.Email == email & x.Password == pwd).SingleOrDefault();
                if (kh != null)
                    return kh;
                return null;
            }
        }
    }
}
