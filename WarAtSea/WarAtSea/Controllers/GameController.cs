﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

    }
}
