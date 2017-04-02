using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WarAtSea.Web.Models
{
    public class Ship : Unit
    {
        public Ship(string unitSubType)
        {
            UnitType = "Ship";
            SubType = unitSubType;
        }

        [Display(Name = "Carry Capacity")]
        public int? CarryingCapacity { get; set; }

        [Display(Name = "Unit Types Carried")]
        public Dictionary<int, string> UnitTypesCarried { get; set; }
    }
}
