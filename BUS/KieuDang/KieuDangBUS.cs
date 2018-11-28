using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.KieuDang
{
    public class KieuDangBUS
    {
        public static List<KieuDangDTO> getAll()
        {
            List<KieuDangDTO> list = new List<KieuDangDTO>();
            list = KieuDangConverter.ConvertToDTOes(KieuDangDAO.getAll());
            return list;

        }
    }
}
