using Microsoft.AspNet.Mvc;

namespace WarAtSea.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Home";
            ViewData["Message"] = "A Message from the Commander-in-Chief:";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Title = "About";
            ViewData["Message"] = "A Briefing on War at Sea:";

            return View();
        }

        public IActionResult Rules()
        {
            ViewBag.Title = "Rules";
            ViewData["Message"] = "Your Rules of Engagement:";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Title = "Contact";
            ViewData["Message"] = "Report to HQ:";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
        
}
