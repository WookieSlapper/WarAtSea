using Microsoft.AspNet.Mvc;
using System.Data.SQLite;

namespace WarAtSea.Controllers
{
    public class FleetController : Controller
    {
        //
        // GET: /Fleet/

        public IActionResult FleetIndex()
        {
            ViewBag.Title = "Fleets";
            ViewBag.Message = "Call Your Units to Action:";
            return View();
        }

        public IActionResult NewFleet()
        {
            ViewBag.Title = "New Fleet";
            ViewBag.Message = "Build Your Fleet:";
            return View();
        }

        public IActionResult EditFleet()
        {
            ViewBag.Title = "Edit Fleet";
            ViewBag.Message = "Change Your Fleet";
            return View();
        }

        public IActionResult AddUnit()
        {
            ViewBag.Message = "Reinforcements En-Route";
            return View();
        }

        public IActionResult RemoveUnit()
        {
            ViewBag.Message = "Transfer Orders Incoming";
            return View();
        }

    }
}
