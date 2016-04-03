using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WarAtSea.Web.Models
{
    public class Unit
    {
        [Required]
        [ScaffoldColumn(false)]
        [Key]
        public int UnitId { get; set; }

        [Required]
        [Display(Name = "Nationality")]
        public string Nationality { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Type")]
        public string Type { get; set; }

        [Required]
        public int UnitTypeId { get; set; }

        [Display(Name = "SubType")]
        public string SubType { get; set; }

        public int? UnitSubTypeId { get; set; }

        [Required]
        [Display(Name = "Cost")]
        public int PointCost { get; set; }

        [Required]
        [Display(Name = "Speed")]
        public int Speed { get; set; }

        [Required]
        public int Year { get; set; }

        //TODO: Not sure what type this should be : this will be basically a table of an attack type matched to a range from 0-3
        [Display(Name = "Attacks")]
        public Dictionary<string, Dictionary<int, int>> Attacks { get; set; }

        [Required]
        [Display(Name = "Armor")]
        public int? Armor { get; set; }

        [Required]
        [Display(Name = "Vital Armor")]
        public int? VitalArmor { get; set; }

        [Required]
        [Display(Name = "Hull Points")]
        public int? HullPoints { get; set; }

        public Dictionary<string, string> Abilities { get; set; }

        public string Description { get; set; }
    }
}
