using BUS.NhomHang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QLWebQA.Controllers
{
    public class apiNhomHangController : ApiController
    {
        [ActionName("getall")]
        public IHttpActionResult GetAll()
        {
            List<NhomHangDTO> dtoes = new List<NhomHangDTO>();
            dtoes = NhomHangBUS.getAll();
            if (dtoes == null)
                return NotFound();
            return Ok(dtoes);
        }
    }
}
