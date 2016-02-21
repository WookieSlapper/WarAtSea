using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WarAtSea.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            ViewBag.Message = "A Message from the Commander-in-Chief:";

            return View();
        }

        public ActionResult Rules()
        {
            ViewBag.Title = "Rules";
            ViewBag.Message = "Your Rules of Engagement:";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Contact";
            ViewBag.Message = "Report to HQ:";

            return View();
        }
    }
}
