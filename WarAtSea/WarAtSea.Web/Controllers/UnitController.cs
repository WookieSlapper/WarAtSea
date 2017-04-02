using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarAtSea.Web.Controllers
{
    public class UnitController
    {
        public IActionResult UnitIndex()
        {
            ViewBag.Message = "Manage Units";
            return View();
        }

        public IActionResult AddUnit(string unitType, int unitSubType)
        {
            var unit = Models.Unit.CreateUnitByType(unitType, unitSubType);

            ViewBag.Message = "Commission a New Unit";
            return PartialViewResult();
        }

        public IActionResult EditUnit(int unitId)
        {
            ViewBag.Message = "Modifications Underway";
            return PartialViewResult();
        }

        public IActionResult DeleteUnit(int unitId)
        {
            ViewBag.Message = "Decommission Requested";
            return PartialViewResult();
        }

        public IActionResult UndoDeleteUnit(int unitId)
        {
            ViewBag.Message = "Recall Underway";
            return View();
        }

        public IActionResult SaveUnit(Models.Unit viewModel)
        {
            //TODO: save the form
            ViewBag.Message = "Launching Unit";
            return View();
        }
    }
}
