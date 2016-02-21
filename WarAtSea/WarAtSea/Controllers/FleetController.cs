using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WarAtSea.Controllers
{
    public class FleetController : Controller
    {
        //
        // GET: /Fleet/

        public ActionResult Build()
        {
            ViewBag.Title = "Fleets";
            ViewBag.Message = "You Have Been Given Your Own Command:";
            return View();
        }

    }
}
