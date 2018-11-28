using DAO;
using EFModels;
using System.Collections.Generic;
using System.Linq;

namespace BUS
{
    public class ComboBUS
    {
        public static List<ComboDTO> showComboes()
        {
            List<Combo> comboEntities = new List<Combo>();
            List<ComboDTO> comboDTOes = new List<ComboDTO>();
            comboEntities = ComboDAO.getAllComboes().Where(x => x.ChiTietComboes.Count >= 2).ToList();
            foreach (Combo item in comboEntities)
            {
                string img = ChiTietComboBUS.getComboImage(item.IDCombo);
                double? total = ChiTietComboBUS.caculateComboTotalPrice(item.IDCombo);
                double? price =  total - total* item.GiaThayDoi;
                comboDTOes.Add(ComboConverter.ConvertToDTO(item, img, price));
            }
            return comboDTOes;
        }

        public static List<ComboDTO> showItems()
        {
            List<Combo> comboEntities = new List<Combo>();
            List<ComboDTO> comboDTOes = new List<ComboDTO>();
            comboEntities = ComboDAO.getAllComboes().Where(x => x.ChiTietComboes.Count == 1).ToList();
            foreach (Combo item in comboEntities)
            {
                string img = ChiTietComboBUS.getComboImage(item.IDCombo);
                double? price = 0;
                double? total = ChiTietComboBUS.caculateComboTotalPrice(item.IDCombo);
                if (item.GiaThayDoi == 1)
                {
                    price = ChiTietComboBUS.caculateComboTotalPrice(item.IDCombo);
                }
                else if(item.GiaThayDoi >1)
                {
                    price = total + total * item.GiaThayDoi;
                }else if(item.GiaThayDoi < 1)
                {
                    price = total - total * item.GiaThayDoi;
                }
                comboDTOes.Add(ComboConverter.ConvertToDTO(item,img,price));
            }
            return comboDTOes;
        }

        public static ComboDTO getById(int idcombo)
        {
            Combo entity = ComboDAO.getOneById(idcombo);
            string img = ChiTietComboBUS.getComboImage(idcombo);
            double? price = 0;
            double? total = ChiTietComboBUS.caculateComboTotalPrice(entity.IDCombo);
            if (entity.GiaThayDoi == 1)
            {
                price = ChiTietComboBUS.caculateComboTotalPrice(entity.IDCombo);
            }
            else if (entity.GiaThayDoi > 1)
            {
                price = total + total * entity.GiaThayDoi;
            }
            else if (entity.GiaThayDoi < 1)
            {
                price = total - total * entity.GiaThayDoi;
            }
            ComboDTO dto = ComboConverter.ConvertToDTO(entity, img, price);
            return dto;
        }
        
       public static List<ComboDTO> Search(int idthuonghieu,int idmausac,int kieudang)
        {
            List<EFModels.Combo> entities = new List<Combo>();
            List<ComboDTO> dtoes = new List<ComboDTO>();
            entities = ComboDAO.Search(idthuonghieu, idmausac, kieudang);
            foreach (Combo item in entities)
            {
                string img = ChiTietComboBUS.getComboImage(item.IDCombo);
                double? price = 0;
                double? total = ChiTietComboBUS.caculateComboTotalPrice(item.IDCombo);
                if (item.GiaThayDoi == 1)
                {
                    price = ChiTietComboBUS.caculateComboTotalPrice(item.IDCombo);
                }
                else if (item.GiaThayDoi > 1)
                {
                    price = total + total * item.GiaThayDoi;
                }
                else if (item.GiaThayDoi < 1)
                {
                    price = total - total * item.GiaThayDoi;
                }
                dtoes.Add(ComboConverter.ConvertToDTO(item, img, price));
            }
            return dtoes;
        }
    }
}
