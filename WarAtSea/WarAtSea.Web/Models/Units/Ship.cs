using System.ComponentModel.DataAnnotations;
using WarAtSea.Web.Models.Weapons;

namespace WarAtSea.Web.Models
{
    public enum ShipSubType
    {
        Destroyer,
        Cruiser,
        Battleship,
        Carrier,
        Transport,
        Auxilliary
    }

    public class Ship : Unit
    {
        public Ship()
        {
            UnitType = "Ship";
        }

        [Required]
        [Display(Name = "SubType")]
        public new ShipSubType SubType { get; set; }

        [Display(Name = "Main Guns")]
        public MainGun MainGuns { get; set; }

        [Display(Name = "Secondary Guns")]
        public bool HasSecondaryGuns { get; set; }
        public SecondaryGun SecondaryGuns { get; set; }

        [Display(Name = "Tertiary Guns")]
        public bool HasTertiaryGuns { get; set; }
        public TertiaryGun TertiaryGuns { get; set; }
    }
}
