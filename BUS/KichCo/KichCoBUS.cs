using BUS.MauSac;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.KichCo
{
    public class KichCoBUS
    {
        public static List<KichCoDTO> getListKichCoByIdSanPhamAndIdMauSac(int sp, int ms)
        {
            List<KichCoDTO> list = new List<KichCoDTO>();           
            list = KichCoConverter.ConvertToDTOes(KichCoDAO.getKichCoByIdSanPhamAndIdMauSac(sp, ms));
            return list;
        }
    }
}
