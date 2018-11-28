using BUS;
using BUS.TrangChiTiet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QLWebQA.Controllers
{
    public class apiComboController : ApiController
    {
        [ActionName("getlistcombo")]
        public IHttpActionResult GetListCombo()
        {
            var comboDtoes = ComboBUS.showComboes();
            if (comboDtoes == null)
                return NotFound();
            return Ok(comboDtoes);
        }
        [ActionName("getlistitems")]
        public IHttpActionResult GetListItems()
        {
            var comboDtoes = ComboBUS.showItems();
            if (comboDtoes == null)
                return NotFound();
            return Ok(comboDtoes);
        }
        [ActionName("getanitembyid")]
        public IHttpActionResult GetAnItemById(int id)
        {
            ComboDTO dto = ComboBUS.getById(id);
            if (dto == null)
                return NotFound();
            return Ok(dto);
        }
        [HttpGet]
        [ActionName("search")]
        public IHttpActionResult Search(int idthuonghieu,int idmausac, int kieudang)
        {
            List<ComboDTO> combodtoes = new List<ComboDTO>();
            combodtoes = ComboBUS.Search(idthuonghieu, idmausac, kieudang);
            if (combodtoes == null)
                return NotFound();
            return Ok(combodtoes);
        }

                
    }
}
