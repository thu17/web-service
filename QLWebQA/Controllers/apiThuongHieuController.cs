using BUS.ThuongHieu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QLWebQA.Controllers
{
    public class apiThuongHieuController : ApiController
    {
        [ActionName("getall")]
        public IHttpActionResult getAll()
        {
            List<ThuongHieuDTO> dtoes = new List<ThuongHieuDTO>();
            dtoes = ThuongHieuBUS.getAll();
            if (dtoes == null)
                return NotFound();
            return Ok(dtoes);
        }
        [ActionName("bynhomhang")]
        public IHttpActionResult getByNhomHang(int id)
        {
            List<ThuongHieuDTO> dtoes = new List<ThuongHieuDTO>();
            dtoes = ThuongHieuBUS.getByNhomHang(id);
            if (dtoes == null)
                return NotFound();
            return Ok(dtoes);
        }
    }
}
