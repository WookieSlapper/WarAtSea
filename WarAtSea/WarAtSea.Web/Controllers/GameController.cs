﻿using Microsoft.AspNet.Mvc;

namespace WarAtSea.Controllers
{
    public class GameController : Controller
    {
        //
        // GET: /Games/

        public IActionResult Games()
        {
            ViewBag.Title = "Games";
            ViewBag.Message = "You Have Been Called to Battle:";

            return View();
        }

        public IActionResult NewGame()
        {
            ViewBag.Title = "New Game";
            //start new game data
            return View();
        }

        public IActionResult ContinueGame()
        {
            ViewBag.Title = "Continue Game";
            //get user and fetch old game data
            return View();
        }
    }
}