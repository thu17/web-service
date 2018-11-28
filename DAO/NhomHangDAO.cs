using EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhomHangDAO
    {
        static Model db;
        public static List<nhomhang> getAll()
        {
            using (db = new Model())
            {
                List<nhomhang> nhomhangs = new List<nhomhang>();
                nhomhangs = db.nhomhangs.ToList();
                return nhomhangs;
            }
        }
    }
}
