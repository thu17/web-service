using EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AdminDAO
    {
        static Model db;
        public static admin login(string email, string pwd)
        {
            using (db = new Model())
            {
                admin a = db.admins.Where(x => x.Email == email & x.Password == pwd).SingleOrDefault();
                if (a != null)
                    return a;
                return null;
            }
        }
    }
}
