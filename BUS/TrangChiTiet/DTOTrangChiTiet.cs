using BUS.ChiTietCombo;
using BUS.SanPhamDacDiem;
using System.Collections.Generic;

namespace BUS.TrangChiTiet
{
    public class DTOTrangChiTiet
    {
        public int IDCombo { get; set; }
        public string TenCombo { get; set; }
        public int? SoLuong { get; set; }
        public double? Gia { get; set; }
        //public List<ChiTietComboDTO> dsChiTietComboDTO { get; set; }
    }
}
