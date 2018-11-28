using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ChiTietSanPham
{
    public class ChiTietSanPhamDTO
    {
        public int IDChitietSanPham { get; set; }
        public int IDSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int IDKichCo { get; set; }
        public string KichCo { get; set; }
        public int IDMauSac { get; set; }
        public string MauSac { get; set; }
    }
}
