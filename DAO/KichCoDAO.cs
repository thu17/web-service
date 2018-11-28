using EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KichCoDAO
    {
        static Model db;
        public static List<KichCo> getKichCoByIdSanPhamAndIdMauSac(int sp, int ms)
        {
            using (db = new Model())
            {
                List<KichCo> list = new List<KichCo>();                
                list = db.ChiTietSanPhams.Include("KichCo")
                                         .Where(x => x.IDSanPham == sp && x.IDMauSac == ms)
                                         .Select(x => x.KichCo).Distinct().ToList();
                return list;
            }
        }
    }
}
