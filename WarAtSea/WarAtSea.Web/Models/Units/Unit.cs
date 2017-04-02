using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace WarAtSea.Web.Models
{
    public class Unit
    {
        // Properties
        [Required]
        [ScaffoldColumn(false)]
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Nationality")]
        public string Nationality { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Type")]
        public string UnitType { get; set; }

        [Required]
        [Display(Name = "Cost")]
        public int PointCost { get; set; }

        [Required]
        [Display(Name = "Speed")]
        public int Speed { get; set; }

        [Display(Name = "Year")]
        public int? Year { get; set; }

        [Required]
        [Display(Name = "Armor")]
        public int? Armor { get; set; }

        [Required]
        [Display(Name = "Vital Armor")]
        public int? VitalArmor { get; set; }

        [Required]
        [Display(Name = "Hull Points")]
        public int? HullPoints { get; set; }

        [Display(Name = "AntiAircraft Guns")]
        public bool HasAntiAircraftGuns { get; set; }

        [Display(Name = "Torpedoes")]
        public bool HasTorpedoes { get; set; }

        [Display(Name = "Depth Charge Launchers")]
        public bool HasDepthCharges { get; set; }

        [Display(Name = "Unit Carrier or Transport")]
        public bool Carrier { get; set; }

        [Display(Name = "Torpedo Defense")]
        public bool HasTorpedoDefense { get; set; }

        public Dictionary<string, string> Abilities { get; set; }

        public string Description { get; set; }

        public bool Destroyed { get; set; }

        public bool UnitDeleted { get; set; }

        // methods
        internal static object CreateUnitByType(string unitType, string unitSubType)
        {
            switch (unitType)
            {
                case "Aircraft":
                    return Aircraft.CreateAircraft(unitType, unitSubType);
                case "Ship":
                    return Ship.CreateShip(unitType, unitSubType);
                case "Submarine":
                    return Submarine.CreateSub(unitType);
                case "ShoreBattery":
                    return ShoreBattery.CreateBattery(unitType);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
