using EFModels;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;


namespace DAO
{
    public class ComboDAO
    {
        public static Model db ;
        
        public static List<Combo> getAllComboes()
        {
            using (db = new Model())
            {
                return db.Comboes.Include("ChiTietComboes").ToList();
            }
        }

        public static Combo getOneById(int idcombo)
        {
            using (db = new Model())
            {
                //return db.Comboes.Include("ChiTietComboes.SanPham.SanPham_DacDiem.DacDiem")
                //                 .Include("ChiTietComboes.SanPham.ThuongHieu")
                //                 .Include("ChiTietComboes.SanPham.ChiTietSanPhams.MauSac")
                //                 .Include("ChiTietComboes.SanPham.ChiTietSanPhams.KichCo")
                //                 .Where(x => x.IDCombo == idcombo).FirstOrDefault();
                return db.Comboes.Include("ChiTietComboes.SanPham")
                                 .Where(x => x.IDCombo == idcombo).SingleOrDefault();
            }
           
        }

        public static List<Combo> Search(int idthuonghieu,int idmausac, int kieudang)
        {
            using (db= new Model())
            {
                List<Combo> comboes = new List<Combo>();
                //idthuonghieu null
                if(idthuonghieu == -1 && idmausac != -1 && kieudang != -1)
                {
                    var list = db.Database.SqlQuery<int>("search1 @MauSac, @DacDiem", new SqlParameter("MauSac", idmausac),
                                                                                        new SqlParameter("DacDiem", kieudang));

                    foreach (var item in list)
                    {
                        Combo combo = db.Comboes.Include("ChiTietComboes").Where(x => x.IDCombo == item).SingleOrDefault();
                        comboes.Add(combo);
                    }
                        return comboes;
                }
                else 
                //idmausac null
                if (idthuonghieu != -1 && idmausac == -1 && kieudang != -1)
                {
                    var list = db.Database.SqlQuery<int>("search2 @ThuongHieu, @DacDiem", new SqlParameter("ThuongHieu", idthuonghieu),
                                                                                        new SqlParameter("DacDiem",kieudang));

                    foreach (var item in list)
                    {
                        Combo combo = db.Comboes.Include("ChiTietComboes").Where(x => x.IDCombo == item).SingleOrDefault();
                        comboes.Add(combo);
                    }
                    return comboes;
                }
                else 
                //kieudang null
                if (idthuonghieu != -1 && idmausac != -1 && kieudang == -1)
                {
                    var list = db.Database.SqlQuery<int>("search3 @ThuongHieu, @MauSac", new SqlParameter("ThuongHieu", idthuonghieu),
                                                                                        new SqlParameter("MauSac", idmausac));

                    foreach (var item in list)
                    {
                        Combo combo = db.Comboes.Include("ChiTietComboes").Where(x => x.IDCombo == item).SingleOrDefault();
                        comboes.Add(combo);
                    }
                    return comboes;
                }
                else
                // idthuonghieu idmausac null 
                if (idthuonghieu == -1 && idmausac == -1 && kieudang != -1)
                {
                    var list = db.Database.SqlQuery<int>("search4 @DacDiem", new SqlParameter("DacDiem",kieudang));

                    foreach (var item in list)
                    {
                        Combo combo = db.Comboes.Include("ChiTietComboes").Where(x => x.IDCombo == item).SingleOrDefault();
                        comboes.Add(combo);
                    }
                    return comboes;
                }
                else
                //idmausac kieudang null
                if (idthuonghieu != -1 && idmausac == -1 && kieudang == -1)
                {
                    var list = db.Database.SqlQuery<int>("search5 @ThuongHieu", new SqlParameter("ThuongHieu", idthuonghieu));

                    foreach (var item in list)
                    {
                        Combo combo = db.Comboes.Include("ChiTietComboes").Where(x => x.IDCombo == item).SingleOrDefault();
                        comboes.Add(combo);
                    }
                    return comboes;
                }
                else
                //idthuonghieu kieudang null
                if (idthuonghieu == -1 && idmausac != -1 && kieudang == -1)
                {
                    var list = db.Database.SqlQuery<int>("search6 @MauSac", new SqlParameter("MauSac", idmausac));

                    foreach (var item in list)
                    {
                        Combo combo = db.Comboes.Include("ChiTietComboes").Where(x => x.IDCombo == item).SingleOrDefault();
                        comboes.Add(combo);
                    }
                    return comboes;
                }
                else if(idthuonghieu != -1 && idmausac != -1 && kieudang != -1)
                {
                    var list = db.Database.SqlQuery<int>("search7 @MauSac, @ThuongHieu, @DacDiem", new SqlParameter("MauSac", idmausac), 
                                                                                        new SqlParameter("ThuongHieu", idthuonghieu),
                                                                                        new SqlParameter("DacDiem",kieudang));

                    foreach (var item in list)
                    {
                        Combo combo = db.Comboes.Include("ChiTietComboes").Where(x => x.IDCombo == item).SingleOrDefault();
                        comboes.Add(combo);
                    }
                    return comboes;
                }
                return comboes;
            }
        }
    }
}
