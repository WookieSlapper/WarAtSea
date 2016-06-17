using System.Collections.Generic;

namespace WarAtSea.Web.Models.Weapons
{
    public class Torpedo
    {
        public List<int> Ranges { get; set; }
        public List<int> AttackValues { get; set; }

        public Dictionary<int, int> AttackTable { get; set; }

        public bool Fired { get; set; }
    }
}
