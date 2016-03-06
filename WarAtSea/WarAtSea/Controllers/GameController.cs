using System.Web.Mvc;

namespace WarAtSea.Controllers
{
    public class GameController : Controller
    {
        //
        // GET: /Games/

        public ActionResult Play()
        {
            ViewBag.Title = "Play";
            ViewBag.Message = "You Have Been Called to Battle:";

            return View();
        }

        public ActionResult NewGame()
        {
            ViewBag.Title = "New Game";
            //start new game data
            return View();
        }

        public ActionResult ContinueGame()
        {
            ViewBag.Title = "Continue Game";
            //get user and fetch old game data
            return View();
        }
    }
}
