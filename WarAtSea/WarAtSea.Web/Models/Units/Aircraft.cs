using System.ComponentModel.DataAnnotations;

namespace WarAtSea.Web.Models
{
    public class Aircraft : Unit
    {
        // constructors
        public Aircraft(string unitSubType)
        {
            UnitType = "Aircraft";
            HullPoints = 1;
            SubType = unitSubType;
        }

        // properties
        [Display(Name = "Speed")]
        public new string Speed
        {
            get
            {
                return "A";
            }
        }

        [Display(Name = "Land Based")]
        public bool IsLandBased { get; set; }

        [Display(Name= "Expert Fighter")]
        public bool ExpertFighter { get; set; }

        [Display(Name= "Expert Bomber")]
        public bool ExpertBomber { get; set; }

        [Display(Name= "High Level Bomber")]
        public bool HighLevelBomber { get; set; }

        [Display(Name= "Defensive Armor")]
        public bool DefensiveArmor { get; set; }

        [Display(Name= "Strafing")]
        public bool Strafing { get; set; }

        [Display(Name = "Multi-Role")]
        public bool MultiRole { get; set; }
    }
}


