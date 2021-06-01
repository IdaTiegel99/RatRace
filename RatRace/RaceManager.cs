using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatRace
{
    public class RaceManager 
    {
        
        public Player[] Players = new Player[5];
        public Rat[] Rats = new Rat[5];
        public Bet[] Bets = new Bet[5];
        // public Random Rnd = new Random();

        public RaceManager()
        {
            for (int i = 0; i < 5; i++)
            {
                Players[i] = new Player(i+1/*,Rnd.Next(100,301)*/);
                Rats[i] = new Rat(i);

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

