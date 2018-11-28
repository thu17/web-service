using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ChiTietSanPham
{
    public class ChiTietSanPhamConverter
    {
        public static ChiTietSanPhamDTO ConvertToDTO (EFModels.ChiTietSanPham ct)
        {
            return new ChiTietSanPhamDTO
            {
                IDChitietSanPham = ct.IDChitietSanPham,
                IDSanPham = ct.IDSanPham,
                TenSanPham = ct.SanPham.TenSanPham,
                IDKichCo = ct.IDKichCo,
                KichCo = ct.KichCo.C_KichCo,
                IDMauSac = ct.IDMauSac,
                MauSac = ct.MauSac.C_MauSac
            };
        }
    }
}
