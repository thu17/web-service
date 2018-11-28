using BUS.ChiTietCombo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.TrangChiTiet
{
    public class TrangChiTietConverter
    {
        //public static DTOTrangChiTiet ConvertToDTO(EFModels.Combo combo, double? gia, List<ChiTietComboDTO> list)
        //{
        //    return new DTOTrangChiTiet
        //    {
        //        IDCombo = combo.IDCombo,
        //        TenCombo = combo.TenCombo,
        //        SoLuong = combo.Soluong,
        //        Gia = gia,
        //        dsChiTietComboDTO = list
        //    };
        //}

        public static DTOTrangChiTiet ConvertToDTO(EFModels.Combo combo,double? gia)
        {
            //List<EFModels.ChiTietCombo> chiTietComboEntities = combo.ChiTietComboes.ToList();
            //List<ChiTietComboDTO> chiTietComboDTOes = new List<ChiTietComboDTO>();            
            //foreach (var item in chiTietComboEntities)
            //{
            //    chiTietComboDTOes.Add(ChiTietComboConverter.ConvertToDTO(item));               
            //}
            return new DTOTrangChiTiet
            {
                IDCombo = combo.IDCombo,
                TenCombo = combo.TenCombo,
                SoLuong = combo.Soluong,
                Gia = gia,
                
                //dsChiTietComboDTO = chiTietComboDTOes
            };

       
        }
    }
}
