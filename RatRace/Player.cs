using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatRace
{
    public class Player
    {
        public int PlayerID;
     
        public double Money;


        public Player(int id)
        {
            PlayerID = id;

            Money = 100;
        }
    }
}
