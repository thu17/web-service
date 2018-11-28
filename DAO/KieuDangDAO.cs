using EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KieuDangDAO
    {
        static Model db;
        public static List<DacDiem> getAll()
        {
            using (db = new Model())
            {
                List<DacDiem> list = new List<DacDiem>();
                list = db.DacDiems.ToList();
                return list;
            }
        }
    }
}
