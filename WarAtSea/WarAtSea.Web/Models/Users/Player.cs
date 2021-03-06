﻿using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Linq;
using System.Threading.Tasks;
using WarAtSea.Web.Models.Games;

namespace WarAtSea.Web.Models
{
    public class Player
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime? LastLoginDate { get; set; }

        public virtual ICollection<Game> Games { get; set; }
        public virtual ICollection<Fleet> Fleets { get; set; }
    }
}
