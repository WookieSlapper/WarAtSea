using System.Collections.Generic;

namespace WarAtSea.Web.Models
{
    public class Submarine : Unit
    {
        public Submarine()
        {
            Type = "Submarine";
            UnitTypeId = 3;
        }

        public Dictionary<int?, int?> Torpedoes { get; set; }
    }
}
