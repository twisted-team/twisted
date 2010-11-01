using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Repositories;


namespace MvcApplication1.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Bienvenido";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Map()
        {
            var mapRepository = new MapRepository();
            var map = mapRepository.GetById(1);
            return Json(map,JsonRequestBehavior.AllowGet);
        }

    }
}
