using System.Collections.Generic;

namespace WarAtSea.Web.Models
{
    public class ShoreBattery : Unit
    {
        public ShoreBattery()
        {
            Type = "ShoreBattery";
            Speed = 0;
            UnitTypeId = 4;
        }

        public Dictionary<int?, int?> MainGuns { get; set; }

        public Dictionary<int?, int?> AntiAir { get; set; }

        public Dictionary<int?, int?> Torpedoes { get; set; }

        public Dictionary<int?, int?> DepthCharges { get; set; }
    }
}
