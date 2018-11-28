using BUS.KichCo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QLWebQA.Controllers
{
    public class apiKichCoController : ApiController
    {
        [ActionName("getlistkichcobyidsanphamanhidmausac")]
        public IHttpActionResult GetListKichCoByIdSanPhamAnhIdMauSac(int sp, int ms)
        {
            var list = KichCoBUS.getListKichCoByIdSanPhamAndIdMauSac(sp, ms);
            if (list == null)
                return NotFound();
            return Ok(list);
        }
    }
}
