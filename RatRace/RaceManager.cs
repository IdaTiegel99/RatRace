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

        public RaceManager()
        {
            for (int i = 0; i < 5; i++)
            {
                players[i] = new Player(i);
                rats[i] = new Rat(i);

            }
        }

        public void MakeBet(Player play, Rat rat, double amount)
        {
            Bet B = new Bet();
            B.PlayerID = play;
            B.RatID = rat;
            B.BetAmount = amount;
        }

    }
 
}

