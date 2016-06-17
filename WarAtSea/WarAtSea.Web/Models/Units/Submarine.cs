namespace WarAtSea.Web.Models
{
    public class Submarine : Unit
    {
        public Submarine()
        {
            HasTorpedoes = true;
            UnitType = "Submarine";
            Speed = 1;
        }
    }
}
