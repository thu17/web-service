using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.MauSac
{
    public class MauSacConverter
    {
        public static MauSacDTO ConvertToDTO (EFModels.MauSac e)
        {
            return new MauSacDTO
            {
                IDMauSac = e.IDMauSac,
                C_MauSac = e.C_MauSac
            };
        }

        public static List<MauSacDTO> ConvertToDTOes (List<EFModels.MauSac> es)
        {
            List<MauSacDTO> dtoes = new List<MauSacDTO>();
            foreach (var item in es)
            {
                dtoes.Add(ConvertToDTO(item));
            }
            return dtoes;
        }
    }
}
