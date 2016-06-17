using System.Collections.Generic;
using WarAtSea.Web.Models;

namespace WarAtSea.Web.DataAccessLayer
{
    public class UnitInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<WarAtSeaContext>
    {
        protected override void Seed(WarAtSeaContext context)
        {
            var ships = new List<Ship>
            {
                new Ship
                {
                    Abilities = new Dictionary<string, string>(),
                    Armor = 2,
                    Description = "As part of the Lend-Lease program, the United States built almost forty CVEs, or escort carriers, for Britain. The Lend-Lease carriers played a crucial part in winning the Battle of the Atlantic. HMS Fencer was one of these. She provided protection for a strike against the Tirpitz on 3 April 1944, and on 1-2 May 1944, the Fencer's aircraft managed the impressive feat of sinking three U-boats in only two days.",
                    HasAntiAircraftGuns = true,
                    HullPoints = 3,
                    ID = 11160,
                    MainGuns = new Models.Weapons.MainGun(),
                    Nationality = "UK",
                    Name = "HMS Fencer",
                    PointCost = 14,
                    Speed = 1,
                    SubType = ShipSubType.Carrier,
                    VitalArmor = 8,
                    Year = 1943,
                },
            };
            ships.ForEach(s => context.Units.Add(s));
            context.SaveChanges();

            var planes = new List<Aircraft>
            {
                new Aircraft
                {
                    Abilities = new Dictionary<string, string>(),
                    Armor = 3,
                    Description = "On 10 November 1940, the HMS Illustrious launched a surprise nighttime raid of twenty-one Swordfish against the Italian naval base at Taranto. The torpedo bombers sank the battleship Conte di Cavour and badly damaged the battleships Littorio and Caio Dulio, losing only two planes. The raid's success inspired Admiral Yamamoto of the Imperial Japanese Navy to plan the attack on Pearl Harbor.",
                    HasDepthCharges = true,
                    HasTorpedoes = true,
                    ID = 14264,
                    Name = "Swordfish Mk. II",
                    Nationality = "UK",
                    PointCost = 10,
                    SubType = AircraftSubType.TorpedoBomber,
                    VitalArmor = 6,
                    Year = 1939
                },
            };
            planes.ForEach(s => context.Units.Add(s));
            context.SaveChanges();

            var submarines = new List<Submarine>
            {
                new Submarine
                {
                    Abilities = new Dictionary<string, string>(),
                    Armor = 3,
                    Description = "On 26 June 1944, the HMS Truculent encountered a Japanese convoy in the Malacca Strait and sank two transports and an escort vessel. Tragically, one of the ships she sank was the Harugiku Maru, which carried over 700 prisoners. The Japanese did not recognize Red Cross conventions, so the transport was not marked in any way.",
                    HullPoints = 2,
                    ID = 12264,
                    Name = "HMS Truculent",
                    Nationality = "UK",
                    PointCost = 12,
                    VitalArmor = 6,
                    Year = 1943
                }
            };
            submarines.ForEach(s => context.Units.Add(s));
            context.SaveChanges();
        }
    }
}
