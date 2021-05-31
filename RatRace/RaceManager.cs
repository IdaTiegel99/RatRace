using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatRace
{
    public class RaceManager 
    {
        
        Player[] players = new Player[5];
        Rat[] rats = new Rat[5];
        Bet[] bets = new Bet[5];

        public void MakeBet(Player play, Rat rat, double amount)
        {
            Bet B = new Bet();
            B.PlayerID = play;
            B.RatID = rat;
            B.BetAmount = amount;
        }

    }
 
}

