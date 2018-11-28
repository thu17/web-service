using BUS.ChiTietSanPham;
using BUS.SanPhamDacDiem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.SanPham
{
    public class SanPhamDTO
    {
        public int IDSanPham { get; set; }
        public string TenSanPham { get; set; }

        public double? GiaBan { get; set; }

        public int? SoLuongTong { get; set; }

        public List<string> URLAnh { get; set; }

        public int IDThuongHieu { get; set; }

        public string TenThuongHieu { get; set; }

        public List<ChiTietSanPhamDTO> dsChiTietSanPhamDTO { get; set; }

        
    }
}
