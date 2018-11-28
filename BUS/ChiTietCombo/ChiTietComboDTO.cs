using BUS.SanPham;
using BUS.SanPhamDacDiem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ChiTietCombo
{
    public class ChiTietComboDTO
    {
        public int IDChiTietCombo { get; set; }

        public int IDCombo { get; set; }
        public int IDSanPham { get; set; }
        public SanPhamDTO SanPhamDTO { get; set; }
        public List<SanPhamDacDiemDTO> dsSanPhamDacDiemDTO { get; set; }
    }
}
