using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.KieuDang
{
    public class KieuDangConverter
    {
        public static KieuDangDTO ConvertToDTO(EFModels.DacDiem e)
        {
            return new KieuDangDTO
            {
                IDDacDiem = e.IDDacDiem,
                C_DacDiem = e.C_DacDiem
            };
        }

        public static List<KieuDangDTO> ConvertToDTOes(List<EFModels.DacDiem> es)
        {
            List<KieuDangDTO> dtoes = new List<KieuDangDTO>();
            foreach (var item in es)
            {
                dtoes.Add(ConvertToDTO(item));
            }
            return dtoes;
        }
    }
}
