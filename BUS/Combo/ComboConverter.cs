
using EFModels;

namespace BUS
{
    public class ComboConverter
    {
        public static ComboDTO ConvertToDTO(Combo combo, string img, double? gia)
        {
            return new ComboDTO
            {
                IDItem = combo.IDCombo,
                TenItem = combo.TenCombo,
                Gia = gia,
                Image = img,
                SoLuong = combo.Soluong
            };
        }
    }
}
