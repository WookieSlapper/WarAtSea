using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace WarAtSea.Web.Models
{
    public class Unit
    {
        // Properties
        public Dictionary<string, string> Abilities { get; set; }

        [Required]
        [Display(Name = "Armor")]
        public int? Armor { get; set; }

        public Weapons.AntiAircraftGun AntiAircraftGun { get; set; }

        [Display(Name = "Unit Carrier or Transport")]
        public bool Carrier { get; set; }

        public Weapons.DepthCharge DepthCharges { get; set; }

        public string Description { get; set; }

        public bool Destroyed { get; set; }

        [Display(Name = "AntiAircraft Guns")]
        public bool HasAntiAircraftGun { get; set; }

        [Display(Name = "Depth Charge Launchers")]
        public bool HasDepthCharges { get; set; }

        [Display(Name = "Main Guns")]
        public bool HasMainGuns { get; set; }

        [Display(Name = "Secondary Guns")]
        public bool HasSecondaryGuns { get; set; }

        [Display(Name = "Tertiary Guns")]
        public bool HasTertiaryGuns { get; set; }

        [Display(Name = "Torpedo Defense")]
        public bool HasTorpedoDefense { get; set; }

        [Display(Name = "Torpedoes")]
        public bool HasTorpedoes { get; set; }

        [Required]
        [Display(Name = "Hull Points")]
        public int? HullPoints { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        [Key]
        public int ID { get; set; }

        public Weapons.MainGun MainGuns { get; set; }

        [Required]
        [Display(Name = "Nationality")]
        public string Nationality { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Cost")]
        public int PointCost { get; set; }

        public Weapons.SecondaryGun SecondaryGuns { get; set; }

        [Required]
        [Display(Name = "Speed")]
        public int Speed { get; set; }

        [Required]
        [Display(Name = "SubType")]
        public string SubType { get; set; }

        public Weapons.TertiaryGun TertiaryGuns { get; set; }

        public Weapons.Torpedo Torpedoes { get; set; }

        public bool UnitDeleted { get; set; }

        [Required]
        [Display(Name = "Type")]
        public string UnitType { get; set; }

        [DataType(DataType.Text)]
        public string Message { get; set; }

        [Required]
        [Display(Name = "Vital Armor")]
        public int? VitalArmor { get; set; }

        [Display(Name = "Year")]
        public int? Year { get; set; }

        // methods
        internal static object CreateUnitByType(string unitType, string unitSubType)
        {
            switch (unitType)
            {
                case "Aircraft":
                    return new Aircraft(unitSubType);
                case "Ship":
                    return new Ship(unitSubType);
                case "Submarine":
                    return new Submarine();
                case "ShoreBattery":
                    return new ShoreBattery();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
