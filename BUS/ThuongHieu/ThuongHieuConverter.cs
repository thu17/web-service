using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ThuongHieu
{
    class ThuongHieuConverter
    {
        public static ThuongHieuDTO ConvertToDTO(EFModels.ThuongHieu e)
        {
            return new ThuongHieuDTO
            {
                IDThuongHieu = e.IDThuongHieu,
                TenThuongHieu = e.C_ThuongHieu
            };
        }

        public static List<ThuongHieuDTO> ConvertToDTOes(List<EFModels.ThuongHieu> es)
        {
            List<ThuongHieuDTO> dtoes = new List<ThuongHieuDTO>();
            foreach (var item in es)
            {
                dtoes.Add(ConvertToDTO(item));
            }
            return dtoes;
        }
    }
}
