using EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThuongHieuDAO
    {
        static Model db;
        public static List<ThuongHieu> getAll()
        {
            using (db = new Model())
            {
                List<ThuongHieu> list = new List<ThuongHieu>();
                list = db.ThuongHieux.ToList();
                return list;
            }
        }

        public static List<ThuongHieu> getByNhomHang(int idnh)
        {
            using (db = new Model())
            {
                List<ThuongHieu> list = new List<ThuongHieu>();
                list = db.ThuongHieux.Where(x => x.IDNhomHang == idnh).ToList();
                return list;
            }
        }


    }
}
