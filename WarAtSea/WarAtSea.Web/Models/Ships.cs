using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace WarAtSea.Web.Models
{
    public class Ships
    {
        [ScaffoldColumn(false)]
        [Key]
        public int UnitId { get; set; }

        [Display(Name = "Nationality")]
        public string Nationality { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Type")]
        public string Type
        {
            get
            {
                return "Ship";
            }
        }

        //maybe this should be a dropdown selection?
        [Required]
        [Display(Name = "Ship Sub-Type")]
        public string SubType { get; set; }

        [Required]
        [Display(Name = "Cost")]
        public int PointCost { get; set; }

        [Display(Name = "Speed")]
        public int Speed { get; set; }

        public int Year { get; set; }

        [Display(Name = "Attacks")]
        public Dictionary<string, int> Attacks { get; set; }

        [Display(Name = "Armor")]
        public int? Armor { get; set; }

        [Display(Name = "Vital Armor")]
        public int? VitalArmor { get; set; }

        [Display(Name = "Hull Points")]
        public int? HullPoints { get; set; }

        public Dictionary<string, string> Abilities { get; set; }

        public string Description { get; set; }
    }
}
