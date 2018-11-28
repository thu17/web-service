using BUS.ChiTietSanPham;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.SanPham
{
    public class SanPhamConverter
    {
        //public static SanPhamDTO ConvertToDTO(EFModels.SanPham sanpham, List<ChiTietSanPhamDTO> list)
        //{
        //    return new SanPhamDTO
        //    {
        //        IDSanPham = sanpham.IDSanPham,
        //        TenSanPham = sanpham.TenSanPham,
        //        GiaBan = sanpham.GiaBan,
        //        SoLuongTong = sanpham.SoLuongTong,
        //        URLAnh = sanpham.URLAnh,
        //        IDThuongHieu = sanpham.IDThuongHieu,
        //        TenThuongHieu = sanpham.ThuongHieu.C_ThuongHieu,
        //        dsChiTietSanPhamDTO = list
        //    };
        //}

        public static SanPhamDTO ConvertToDTO(EFModels.SanPham sanPham)
        {
            List < EFModels.ChiTietSanPham > chiTietSanPhamEntities = sanPham.ChiTietSanPhams.ToList();
            List<ChiTietSanPhamDTO> chiTietSanPhamDTOes = new List<ChiTietSanPhamDTO>();
            foreach (var item in chiTietSanPhamEntities)
            {
                chiTietSanPhamDTOes.Add(ChiTietSanPhamConverter.ConvertToDTO(item));
            }
            return new SanPhamDTO
            {
                IDSanPham = sanPham.IDSanPham,
                TenSanPham = sanPham.TenSanPham,
                GiaBan = sanPham.GiaBan,
                SoLuongTong = sanPham.SoLuongTong,
                URLAnh = ImageUrl.getImageUrl(sanPham.URLAnh),
                IDThuongHieu = sanPham.IDThuongHieu,
                TenThuongHieu = sanPham.ThuongHieu.C_ThuongHieu,
                dsChiTietSanPhamDTO = chiTietSanPhamDTOes
            };
        }
        public static SanPhamDTO ConvertToSimpleDTO(EFModels.SanPham sp)
        {
            return new SanPhamDTO
            {
                IDSanPham = sp.IDSanPham,
                TenSanPham = sp.TenSanPham
            };
        }

        public static List<SanPhamDTO> ConvertToSimpleDTOes (List<EFModels.SanPham> sps)
        {
            List<SanPhamDTO> list = new List<SanPhamDTO>();
            foreach (var item in sps)
            {
                list.Add(ConvertToSimpleDTO(item));
            }
            return list;
        }
    }
}
