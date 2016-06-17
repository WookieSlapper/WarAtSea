using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarAtSea.Web.Models.Users;

namespace WarAtSea.Web.Models
{
    public class Game
    {
        public int Id { get; set; }
        public int FleetId { get; set; }
        public int UserId { get; set; }

        public bool Deleted { get; set; }

        public virtual ICollection<Fleet> Fleets { get; set; }
        public virtual ICollection<Player> Users { get; set; }
    }
}
