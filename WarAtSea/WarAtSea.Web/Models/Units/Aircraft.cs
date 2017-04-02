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

        [Required]
        [Display(Name = "SubType")]
        public string SubType { get; set; }

        [Display(Name = "Land Based")]
        public bool IsLandBased { get; set; }

        public bool ExpertFighter { get; set; }
        public bool ExpertBomber { get; set; }
        public bool HighLevelBomber { get; set; }
        public bool DefensiveArmor { get; set; }
        public bool Strafing { get; set; }

        // methods
        internal static Aircraft CreateAircraft(string unitType, string unitSubType)
        {
            var aircraft = new Aircraft(unitSubType);
            return aircraft;
        }
    }
}


