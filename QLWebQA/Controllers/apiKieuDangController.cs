using BUS.KieuDang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QLWebQA.Controllers
{
    public class apiKieuDangController : ApiController
    {
        [ActionName("getallkd")]
        public IHttpActionResult GetAll()
        {
            List<KieuDangDTO> list = new List<KieuDangDTO>();
            list = KieuDangBUS.getAll();
            if (list == null)
                return NotFound();
            return Ok(list);
        }
    }
}
