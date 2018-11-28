using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.NhomHang
{
    public class NhomHangBUS
    {
        public static List<NhomHangDTO> getAll()
        {
            List<NhomHangDTO> dtoes = new List<NhomHangDTO>();
            List <EFModels.nhomhang> entities = NhomHangDAO.getAll();
            dtoes = NhomHangConverter.ConvertToDTOes(entities);
            return dtoes;
        }
    }
}
