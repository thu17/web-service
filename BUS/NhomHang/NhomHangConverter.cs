using System.Collections.Generic;

namespace BUS.NhomHang
{
    public class NhomHangConverter
    {
        public static NhomHangDTO ConvertToDTO(EFModels.nhomhang e)
        {
            return new NhomHangDTO
            {
                IDNhomHang = e.IDNhomhang,
                TenNhomHang = e.Tennhomhang
            };
        }

        public static List<NhomHangDTO> ConvertToDTOes(List<EFModels.nhomhang> es)
        {
            List<NhomHangDTO> dtoes = new List<NhomHangDTO>();
            foreach (var item in es)
            {
                dtoes.Add(ConvertToDTO(item));
            }
            return dtoes;
        }
    }
}
