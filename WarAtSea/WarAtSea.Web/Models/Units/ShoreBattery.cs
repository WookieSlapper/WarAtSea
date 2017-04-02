using System;

namespace WarAtSea.Web.Models
{
    public class ShoreBattery : Unit
    {
        public ShoreBattery()
        {
            UnitType = "ShoreBattery";
            Speed = 0;
            UnitTypeID = 4;
        }

        internal static object CreateBattery()
        {
            throw new NotImplementedException();
        }
    }
}
