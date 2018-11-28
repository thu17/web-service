using BUS.SanPham;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietComboBUS
    {
        public static string getComboImage (int idcombo)
        {
            return ChiTietComboDAO.getOneImageForCombo(idcombo);
        }

        public static double? caculateComboTotalPrice(int idcombo)
        {
            return ChiTietComboDAO.caculateComboTotalPrice(idcombo);
        }

       
    }
}
