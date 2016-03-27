using Microsoft.AspNet.Mvc;

namespace WarAtSea.Controllers
{
    public class FleetController : Controller
    {
        //
        // GET: /Fleet/

        public IActionResult Fleets()
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
            return View();
        }

    }
}
