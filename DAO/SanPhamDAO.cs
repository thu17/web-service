using EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SanPhamDAO
    {
        static Model db;
        public static List<SanPham> getSanPhamByComboId(int id)
        {
            using (db = new Model())
            {
                var cts = db.ChiTietComboes.Where(x => x.IDCombo == id).ToList();
                List<SanPham> sanphams = new List<SanPham>();
                foreach (var item in cts)
                {
                    sanphams.Add(item.SanPham);
                }
                return sanphams;
            }

        }

        
    }
}
