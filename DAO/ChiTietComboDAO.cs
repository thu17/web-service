using System.Collections.Generic;
using System.Linq;
using EFModels;

namespace DAO
{
    public class ChiTietComboDAO
    {
        public static Model db ;
        /*public static ChiTietCombo getUniqueChiTietComboByComboID(int idcombo)
        {
            using (db)
            {
                return db.ChiTietComboes.Where(x => x.IDCombo == idcombo).First();
            }
        }*/

        public static string getOneImageForCombo(int idcombo)
        {
            using (db = new Model())
            {
                string ImageUrls = db.ChiTietComboes.Where(x => x.IDCombo == idcombo).First().SanPham.URLAnh;
                return ImageUrl.getFirstImageUrl(ImageUrls);
            }
            
        }

        public static double? caculateComboTotalPrice(int comboid)
        {
            using (db = new Model())
            {
                var list = db.ChiTietComboes.Where(x => x.IDCombo == comboid).ToList();
                double? totalPrice = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    totalPrice += list[i].SanPham.GiaBan;
                }
                return totalPrice;
            }
           
        }

        public static ChiTietCombo getComboDetail(int idCombo)
        {
            using (db = new Model())
            {
                return db.ChiTietComboes.Where(x => x.IDCombo == idCombo).SingleOrDefault();
            }
        }

        public static List<SanPham> getListSanPhamInACombo(int comboid)
        {
            using (db = new Model())
            {
                var listChiTietCombo = db.ChiTietComboes.Include("SanPham").Where(x => x.IDCombo == comboid).ToList();
                List<SanPham> sanphams = new List<SanPham>();
                foreach (var item in listChiTietCombo)
                {
                    sanphams.Add(item.SanPham);
                }
                return sanphams;
            }
        }
        
        
        //public static List<ChiTietCombo> getChiTietComboesByComboId(int comboid)
        //{
        //    using (db)
        //    {
        //        return db.ChiTietComboes.Include("SanPham.IDSanPham").ToList();
        //    }
        //}
    }
}
