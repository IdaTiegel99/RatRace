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
        public List<Bet> Bets = new List<Bet>();
        public Random Rnd = new Random();

        public RaceManager()
        {
            for (int i = 0; i < 5; i++)
            {
                Players[i] = new Player(i+1/*,Rnd.Next(100,301)*/);
                Rats[i] = new Rat(i+1, (double)(Rnd.Next(1,11)));

            }
        }

        public bool MakeBet(Player play, Rat rat, double amount)
        {
            if (play.Money >= amount)
            {
            Bet B = new Bet(play,rat,amount);
            play.Money -= amount;
            Bets.Add(B);
                return true;
            }
            else
            {
                return false;
            }
         

        }

    }
 
}

