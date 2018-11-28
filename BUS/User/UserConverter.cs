using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.User
{
    public class UserConverter
    {
        public static UserDTO AdminConvertToUserDTO(EFModels.admin e, int? type)
        {
            return new UserDTO
            {
                IDUser = e.IDAdmin,
                Email = e.Email,
                Password = e.Password,
                Type = type
            };
        }

        public static UserDTO CusConvertToDTO(EFModels.khachhang e, int? type)
        {
            return new UserDTO
            {
                IDUser = e.IDkhachhang,
                Email = e.Email,
                Password = e.Password,
                Type = type
            };
        }
    }
}
