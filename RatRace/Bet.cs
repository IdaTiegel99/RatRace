using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RatRace
{
    public class Bet
    {
        public Player PlayerID;
        public Rat RatID;
        public double BetAmount;

        
        public Bet(Player playerID, Rat ratID, double betAmount)
        {
            PlayerID = playerID;
            RatID = ratID;
            BetAmount = betAmount;
        }
    }
        

}
