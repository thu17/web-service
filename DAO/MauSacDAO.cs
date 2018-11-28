using EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MauSacDAO
    {
        static Model db;
        public static List<MauSac> getMauSacBySanPhamId(int idsanpham)
        {
            using (db = new Model())
            {
                //List<MauSac> mausacs = (from ct in db.ChiTietSanPhams
                //                        join ms in db.MauSacs
                //                        on ct.IDMauSac equals ms.IDMauSac into obj                                  
                //                        where ct.IDSanPham == idsanpham 
                //                        group ct by ct.IDMauSac into g
                //                        select new  { IDMauSac = g.Key ,  }).ToList();

                //return mausacs;
                List<MauSac> list = new List<MauSac>();
                list = db.ChiTietSanPhams.Include("MauSac").Where(x => x.IDSanPham == idsanpham).Select(x => x.MauSac).Distinct().ToList();
                return list;
                
            }
        }

        public static List<MauSac> getAll()
        {
            using (db = new Model())
            {
                //List<MauSac> mausacs = (from ct in db.ChiTietSanPhams
                //                        join ms in db.MauSacs
                //                        on ct.IDMauSac equals ms.IDMauSac into obj                                  
                //                        where ct.IDSanPham == idsanpham 
                //                        group ct by ct.IDMauSac into g
                //                        select new  { IDMauSac = g.Key ,  }).ToList();

                //return mausacs;
                List<MauSac> list = new List<MauSac>();
                list = db.MauSacs.ToList();
                return list;

            }
        }
    }
}
