using BUS.SanPham;
using BUS.SanPhamDacDiem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ChiTietCombo
{

    public class ChiTietComboConverter
    {
        //public static ChiTietComboDTO ConvertToDTO(EFModels.ChiTietCombo ct, List<SanPhamDTO> list)
        //{
        //    return new ChiTietComboDTO
        //    {
        //        IDChiTietCombo = ct.IDChiTietCombo,
        //        IDCombo = ct.IDCombo,
        //        IDSanPham = ct.IDSanPham,
        //        dsSanPhamDTO = list
        //    };
        //}
        //public static ChiTietComboDTO ConvertToDTO(EFModels.ChiTietCombo ct)
        //{
        //    EFModels.SanPham sanPhamEntity = ct.SanPham;
        //    List<SanPhamDacDiemDTO> sp_ddDTOes = new List<SanPhamDacDiemDTO>();
        //    foreach (var item in sanPhamEntity.SanPham_DacDiem)
        //    {
        //        sp_ddDTOes.Add(SanPhamDacDiemConverter.ConvertToDto(item));
        //    }
        //    return new ChiTietComboDTO
        //    {
        //        IDChiTietCombo = ct.IDChiTietCombo,
        //        IDCombo = ct.IDCombo,
        //        IDSanPham = ct.IDSanPham,
        //        SanPhamDTO = SanPhamConverter.ConvertToDTO(ct.SanPham),
        //        dsSanPhamDacDiemDTO = sp_ddDTOes
        //    };
        //}


    }
}
