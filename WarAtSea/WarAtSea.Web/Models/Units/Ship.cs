using System.Collections.Generic;

namespace WarAtSea.Web.Models
{
    public class Ship : Unit
    {
        public Ship()
        {
            Type = "Ship";
            UnitTypeId = 1;
        }

        public Dictionary<int?, int?> MainGuns { get; set; }

        public Dictionary<int?, int?> SecondaryGuns { get; set; }

        public Dictionary<int?, int?> TertiaryGuns { get; set; }

        public Dictionary<int?, int?> AntiAir { get; set; }

        public Dictionary<int?, int?> Torpedoes { get; set; }

        public Dictionary<int?, int?> DepthCharges { get; set; }

        public bool Carrier { get; set; }

        public int? CarryingCapacity { get; set; }

        public List<int?> CarryUnitTypeId { get; set; }
    }
}
