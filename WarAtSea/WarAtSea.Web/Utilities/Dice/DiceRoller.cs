using System;
using System.Collections.Generic;

namespace WarAtSea.Web.Utilities.Dice
{
    public class DiceRoller
    {
        public List<int> RollDice(int? numberOfDice)
        {
            var resultList = new List<int>();

            var random = new Random();

            // roll at least one die; this is the minimum number of dice that can be rolled in an attack
            do
            {
                int randomNumber = random.Next(1, 7);
                resultList.Add(randomNumber);
            }
            // should still roll once even if numberOfDice is null
            while (resultList.Count < numberOfDice);

            return resultList;
        }

        public int InitiativeRoll()
        {
            var roll = RollDice(2);
            return roll[0] + roll[1];
        }

        public int CalculateHits(List<int> diceRollResults)
        {
            var hits = 0;

            foreach (var result in diceRollResults)
            {
                if (result == 4 || result == 5)
                {
                    hits++;
                }
                if (result == 6)
                {
                    hits += 2;
                }
            }

            return hits;
        }

        public Models.Unit ApplyDamage(Models.Unit unit, int hits)
        {
            var hullPoints = unit.HullPoints;
            var armor = unit.Armor;
            var vitalArmor = unit.VitalArmor;

            //TODO: need to incorporate a way to reduce hit total if attack type is torpedo and ship has torpedo defense
            if (hits >= armor)
            {
                if (hits >= vitalArmor)
                {
                    unit.Destroyed = true;
                }

                hullPoints--;
            }

            if (hullPoints <= 0)
            {
                unit.Destroyed = true;
            }

            return unit;
        }
    }
}
