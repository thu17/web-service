using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ThuongHieu
{
    public class ThuongHieuBUS
    {
        public static List<ThuongHieuDTO> getAll()
        {
            List<ThuongHieuDTO> dtoes = new List<ThuongHieuDTO>();
            List<EFModels.ThuongHieu> entities = new List<EFModels.ThuongHieu>();
            entities = ThuongHieuDAO.getAll();
            dtoes = ThuongHieuConverter.ConvertToDTOes(entities);
            return dtoes;
        }
        public static List<ThuongHieuDTO> getByNhomHang(int idnh)
        {
            List<ThuongHieuDTO> dtoes = new List<ThuongHieuDTO>();
            List<EFModels.ThuongHieu> entities = new List<EFModels.ThuongHieu>();
            entities = ThuongHieuDAO.getByNhomHang(idnh);
            dtoes = ThuongHieuConverter.ConvertToDTOes(entities);
            return dtoes;
        }
    }
}
