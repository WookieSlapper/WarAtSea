using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WarAtSea.Web.Models
{
    public class Fleet
    {
        [ScaffoldColumn(false)]
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Admiral")]
        public string PlayerName { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string FleetName { get; set; }

        [Display(Name = "Points")]
        public int PointValue { get; set; }

        [Display(Name = "Nationality")]
        public string Nationality { get; set; }

        [Display(Name = "Year")]
        public int Year { get; set; }

        public ICollection<Ship> Ships { get; set; }              // Not sure what this type is to be yet
        public ICollection<Aircraft> Aircraft { get; set; }           // Not sure what this type should be yet
        public ICollection<Submarine> Submarines { get; set; }         // Not sure what this type should be yet
        public ICollection<ShoreBattery> ShoreBatteries { get; set; }     // Not sure what this type should be yet

        public int? GameId { get; set; }                                // Does each fleet need a current game Id? Or, maybe a list of game Ids?

        [Display(Name = "Fleet Description")]
        public string Description { get; set; }

        public ICollection<Unit> DestroyedUnits { get; set; }
        public ICollection<Unit> DamagedUnits { get; set; }
    }
}
