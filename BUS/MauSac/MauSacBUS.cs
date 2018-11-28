using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.MauSac
{
    public class MauSacBUS
    {
        public static List<MauSacDTO> getListMauSacBySanPhamId(int idsanpham)
        {
            List<MauSacDTO> list = new List<MauSacDTO>();            
            list = MauSacConverter.ConvertToDTOes(MauSacDAO.getMauSacBySanPhamId(idsanpham));
            return list;

        }

        public static List<MauSacDTO> getAll()
        {
            List<MauSacDTO> list = new List<MauSacDTO>();
            list = MauSacConverter.ConvertToDTOes(MauSacDAO.getAll());
            return list;

        }
    }
}
