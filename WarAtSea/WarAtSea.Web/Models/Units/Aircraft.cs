using System.ComponentModel.DataAnnotations;

namespace WarAtSea.Web.Models
{
    public enum AircraftSubType
    {
        Fighter,
        DiveBomber,
        TorpedoBomber,
        Bomber
    }

    public class Aircraft : Unit
    {
        public Aircraft()
        {
            UnitType = "Aircraft";
            HullPoints = 1;
        }
        
        [Display(Name = "Speed")]
        public new string Speed
        {
            get
            {
                return "A";
            }
        }

        [Required]
        [Display(Name = "SubType")]
        public new AircraftSubType SubType { get; set; }

        [Display(Name = "Land Based")]
        public bool IsLandBased { get; set; }

        public bool ExpertFighter { get; set; }
        public bool ExpertBomber { get; set; }
        public bool HighLevelBomber { get; set; }
        public bool DefensiveArmor { get; set; }
        public bool Strafing { get; set; }
    }
}
