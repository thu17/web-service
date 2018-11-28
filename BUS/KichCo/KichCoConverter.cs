using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.KichCo
{
    public class KichCoConverter
    {
        public static KichCoDTO ConvertToDTO(EFModels.KichCo e)
        {
            return new KichCoDTO
            {
                IDKichCo = e.IDKichCo,
                C_KichCo = e.C_KichCo
            };
        }

        public static List<KichCoDTO> ConvertToDTOes(List<EFModels.KichCo> es)
        {
            List<KichCoDTO> dtoes = new List<KichCoDTO>();
            foreach (var item in es)
            {
                dtoes.Add(ConvertToDTO(item));
            }
            return dtoes;
        }
    }
}
