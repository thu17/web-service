using BUS.MauSac;
using System.Collections.Generic;
using System.Web.Http;

namespace QLWebQA.Controllers
{
    public class apiMauSacController : ApiController
    {
        [ActionName("getlistmausacbysanphamid")]
        public IHttpActionResult GetListMauSacBySanPhamId(int id)
        {
            List<MauSacDTO> list = new List<MauSacDTO>();
            list = MauSacBUS.getListMauSacBySanPhamId(id);
            if (list == null)
                return NotFound();
            return Ok(list);
        }

        [ActionName("getallms")]
        public IHttpActionResult GetAll()
        {
            List<MauSacDTO> list = new List<MauSacDTO>();
            list = MauSacBUS.getAll();
            if (list == null)
                return NotFound();
            return Ok(list);
        }
    }
}
