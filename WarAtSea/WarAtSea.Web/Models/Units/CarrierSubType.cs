using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WarAtSea.Web.Models.Units
{
    public class CarrierSubType
    {
        [Display(Name = "Carry Capacity")]
        public int? CarryingCapacity { get; set; }

        [Display(Name = "Unit Type")]
        public ICollection<int?> CarryUnitTypeID { get; set; }
    }
}
