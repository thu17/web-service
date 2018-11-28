using BUS.SanPham;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QLWebQA.Controllers
{
    public class apiSanPhamController : ApiController
    {
        [ActionName("getlistsanphambycomboid")]
        public IHttpActionResult GetListSanPhamByComboId(int id)
        {
            var list = SanPhamBUS.getListItemByComboId(id);
            if (list == null)
                return NotFound();
            return Ok(list);
        }
    }
}
