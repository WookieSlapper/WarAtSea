using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarAtSea.Web.Models.Games
{
    public class Round
    {
        public int RoundId { get; set; }

        public void RollInitiative()
        {
            var roller = new Utilities.Dice.DiceRoller();
            roller.InitiativeRoll();
        }

        //PlayerTurn.StartPlayerTurn();
        //PlayerTurn.EndPlayerTurn();
        //Change players and start turn
    }
}
