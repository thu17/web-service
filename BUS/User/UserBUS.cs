using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.User
{
    public class UserBUS
    {
        public static UserDTO login(string email, string pwd)
        {
            //-1 admin, 0 cus
            EFModels.admin admin = AdminDAO.login(email, pwd);
            UserDTO userDTO = new UserDTO();
            if(admin != null)
            {
                userDTO = UserConverter.AdminConvertToUserDTO(admin,-1);
                return userDTO;
            }
            else
            {
                EFModels.khachhang khachhang = KhachHangDAO.login(email, pwd);
                if(khachhang != null)
                {
                    userDTO = UserConverter.CusConvertToDTO(khachhang,khachhang.Loaikhachhang);
                    return userDTO;
                }
            }
            return null;
        }
    }
}
