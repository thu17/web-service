using BUS.MauSac;
using BUS.SanPham;
using DAO;
using EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.SanPham
{
    public class SanPhamBUS
    {
        public static List<SanPhamDTO> getListItemByComboId(int id)
        {
            var list = SanPhamConverter.ConvertToSimpleDTOes(SanPhamDAO.getSanPhamByComboId(id));
            return list;
        }

        
    }
}
