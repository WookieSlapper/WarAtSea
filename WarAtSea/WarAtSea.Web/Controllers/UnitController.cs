using Microsoft.AspNet.Mvc;

namespace WarAtSea.Web.Controllers
{
    public class UnitController
    {
        public IActionResult UnitIndex()
        {
            //ViewBag.Message = "Manage Units";
            return viewResult();
        }

        public IActionResult AddUnit(string unitType, string unitSubType)
        {
            var unit = Models.Unit.CreateUnitByType(unitType, unitSubType);

            ViewData["Message"] = "Commission a New Unit";
            return new ViewResult();
        }

        public IActionResult EditUnit(int unitId)
        {
            ViewData["Message"] = "Modifications Underway";
            return new PartialViewResult();
        }

        public IActionResult DeleteUnit(int unitId)
        {
            ViewData["Message"] = "Decommission Requested";
            return new PartialViewResult();
        }

        public IActionResult UndoDeleteUnit(int unitId)
        {
            ViewData["Message"] = "Recall Underway";
            return new PartialViewResult();
        }

        public IActionResult SaveUnit(Models.Unit viewModel)
        {
            //TODO: save the form
            ViewData["Message"] = "Launching Unit";
            return new ViewResult();
        }
    }
}
