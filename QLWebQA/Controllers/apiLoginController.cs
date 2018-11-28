using BUS.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QLWebQA.Controllers
{
    public class apiLoginController : ApiController
    {
        [ActionName("login")]
        [HttpGet]
        public IHttpActionResult login(string email, string pwd)
        {
            UserDTO user = UserBUS.login(email,pwd);
            if (user == null)
                return NotFound();
            return Ok(user);
        }
    }
}
