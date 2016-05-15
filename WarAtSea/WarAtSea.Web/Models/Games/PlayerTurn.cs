using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarAtSea.Web.Models.Games
{
    public class PlayerTurn
    {
        // Properties
        public int PlayerId { get; set; }

        // Methods
        public void StartPlayerTurn()
        {

        }

        public void MoveUnits()
        {

        }

        public void MoveAirUnits()
        {
            // this will be tricky... in the game players alternate placing units. That would be very time-consuming in a web game.
            // Unless.... if all moves were declared but kept hidden until opponent deployed, then revealed...
        }

        public Unit MakeASurfaceAttackAndUpdateUnits(Unit attackingUnit, Unit defendingUnit, int range, int attackType)
        {
            var attacks = attackingUnit.Attack;

            foreach (var intKey in attacks)
            {
                foreach (var dictionary in intKey.Value)
                    if (dictionary.Key == range)
                    {
                        var dice = new Utilities.Dice.DiceRoller();
                        var attackValue = dictionary.Value;
                        var rolls = dice.RollDice((int)attackValue);
                        var hits = dice.CalculateHits(rolls);
                        var results = dice.ApplyDamage(defendingUnit, hits);
                    }
            }

            return defendingUnit;
        }

        public Unit MakeAnAntiAirAttackAndUpdateUnits(Unit attackingUnit, Unit defendintUnit)
        {
            return defendintUnit;
        }

        public Unit MakeATorpedoAttackAndUpdateUnits(Unit attackingUnit, Unit defendingUnit)
        {
            return defendingUnit;
        }

        public Unit MakeADepthChargeAttackAndUpdateUnits(Unit attackingUnit, Unit defendingUnit)
        {
            return defendingUnit;
        }

        public void ReturnAirUnitsToBase()
        {

        }

        public void EndTurn(PlayerTurn playerTurn)
        {
            //reset "Attacked" booleans
            //check for destroyed units
            //rebase air units
        }
    }
}
