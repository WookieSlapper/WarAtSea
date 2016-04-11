using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WarAtSea.Web.Models
{
    public class Unit
    {
        //Constructors

        // Properties
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
        [Display(Name = "Attack")]
        public Dictionary<int, Dictionary<int?, int?>> Attack { get; set; }

        [Required]
        [Display(Name = "Armor")]
        public int? Armor { get; set; }

        [Required]
        [Display(Name = "Vital Armor")]
        public int? VitalArmor { get; set; }

        [Required]
        [Display(Name = "Hull Points")]
        public int? HullPoints { get; set; }

        [Display(Name = "Main Guns")]
        public Dictionary<int?, int?> MainGuns { get; set; }
        public bool Attacked_Main { get; set; }

        [Display(Name = "Secondary Guns")]
        public bool HasSecondaryGuns { get; set; }
        public Dictionary<int?, int?> SecondaryGuns { get; set; }
        public bool Attacked_Secondary { get; set; }

        [Display(Name = "Tertiary Guns")]
        public bool HasTertiaryGuns { get; set; }
        public Dictionary<int?, int?> TertiaryGuns { get; set; }
        public bool Attacked_Tertiary { get; set; }

        [Display(Name = "Anti-Air Batteries")]
        public bool HasAntiAir { get; set; }
        public Dictionary<int?, int?> AntiAir { get; set; }
        public bool Attacked_AntiAir { get; set; }

        [Display(Name = "Torpedoes")]
        public bool HasTorpedoes { get; set; }
        public Dictionary<int?, int?> Torpedoes { get; set; }
        public bool Attacked_Torpedoes { get; set; }

        [Display(Name = "Depth Charge Launchers")]
        public bool HasDepthCharges { get; set; }
        public Dictionary<int?, int?> DepthCharges { get; set; }
        public bool Attacked_DepthCharges { get; set; }

        [Display(Name = "Unit Carrier or Transport")]
        public bool Carrier { get; set; }

        [Display(Name = "Carry Capacity")]
        public int? CarryingCapacity { get; set; }

        [Display(Name = "Unit Type")]
        public List<int?> CarryUnitTypeId { get; set; }

        public Dictionary<string, string> Abilities { get; set; }

        public string Description { get; set; }

        public bool Destroyed { get; set; }

        public bool UnitDeleted { get; set; }

    }
}
