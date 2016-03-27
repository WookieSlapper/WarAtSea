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
            ViewBag.Message = "You Have Been Given Your Own Command:";
            return View();
        }

    }
}
