using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.SanPhamDacDiem
{
    public class SanPhamDacDiemDTO
    {
        public int IDSanPham_DacDiem { get; set; }

        public int IDSanPham { get; set; }

        public int IDDacDiem { get; set; }

        public string TenDacDiem { get; set; }
    }
}
