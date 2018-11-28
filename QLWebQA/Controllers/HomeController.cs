using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLWebQA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [ActionName("Combo")]
        public ActionResult Combo()
        {
            return View("Combo");
        }

        [ActionName("Detail")]
        public ActionResult Detail(int id)
        {
            return View("Detail");
        }

        [ActionName("Search")]
        public ActionResult Search(int idthuonghieu, int idmausac,int kieudang)
        {
            return View("Search");
        }


        
    }
}
