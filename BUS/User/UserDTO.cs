using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.User
{
    public class UserDTO
    {
        public int IDUser { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? Type { get; set; }
    }
}
