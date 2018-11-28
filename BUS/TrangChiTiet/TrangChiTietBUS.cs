using BUS.ChiTietCombo;
using BUS.SanPham;
using DAO;
using EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.TrangChiTiet
{

    public class TrangChiTietBUS
    {
        public static DTOTrangChiTiet getAnItemByComboID(int comboid)
        {
            //DTOTrangChiTiet dto = new DTOTrangChiTiet();
            ////Combo,ChiTietCombo,SanPham,ChiTietSanPham
            //Combo combo = ComboDAO.getOneById(comboid);
            //double? gia = ChiTietComboDAO.caculateComboTotalPrice(comboid);
            //EFModels.ChiTietCombo chiTietCombo = ChiTietComboDAO.getComboDetail(comboid);
            //List < ChiTietComboDTO > listChiTietComboDTO= ChiTietComboConverter.ConvertToDTO(chiTietCombo,listSanPhamDTO);
            //dto = TrangChiTietConverter.ConvertToDTO(combo, gia, listChiTietComboDTO);
            Combo comboEntity = ComboDAO.getOneById(comboid);
            double? gia = ChiTietComboDAO.caculateComboTotalPrice(comboid);            
            return TrangChiTietConverter.ConvertToDTO(comboEntity, gia);
        }
    }
}
