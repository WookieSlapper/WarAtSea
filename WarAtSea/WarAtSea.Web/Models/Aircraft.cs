using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WarAtSea.Web.Models
{
    public class Aircraft
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
                return "Aircraft";
            }
        }

        //maybe this should be a dropdown selection?
        [Required]
        [Display(Name = "Aircraft Sub-Type")]
        public string SubType { get; set; }
                
        [Required]
        [Display(Name = "Cost")]
        public int PointCost { get; set; }

        [Display(Name = "Speed")]
        public string Speed
        {
            get
            {
                return "A";
            }
        }

        public int Year { get; set; }

        [Display(Name = "Attacks")]
        public Dictionary<string, int> Attacks { get; set; }

        [Display(Name = "Armor")]
        public int? Armor { get; set; }

        [Display(Name = "Vital Armor")]
        public int? VitalArmor { get; set; }

        [Display(Name="Hull Points")]
        public int? HullPoints { get; set; }

        public Dictionary<string, string> Abilities { get; set; }

        public string Description { get; set; }
    }
}
