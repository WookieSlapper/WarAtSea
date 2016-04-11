using System.ComponentModel.DataAnnotations;

namespace WarAtSea.Web.Models
{
    public class Aircraft : Unit
    {
        public Aircraft()
        {
            Type = "Aircraft";
            UnitTypeId = 2;
            HullPoints = 1;
        }

        [Required]
        [Display(Name = "Speed")]
        public new string Speed
        {
            get
            {
                return "A";
            }
        }
    }
}
