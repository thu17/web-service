using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.SanPhamDacDiem
{
    public class SanPhamDacDiemConverter
    {
        public static SanPhamDacDiemDTO ConvertToDto (EFModels.SanPham_DacDiem entity)
        {
            return new SanPhamDacDiemDTO
            {
                IDSanPham_DacDiem = entity.IDSanPham_DacDiem,
                IDDacDiem =entity.IDDacDiem,
                IDSanPham = entity.IDSanPham,
                TenDacDiem = entity.DacDiem.C_DacDiem
            };
        }
    }
}
