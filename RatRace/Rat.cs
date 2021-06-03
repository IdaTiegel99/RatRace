using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatRace
{
    public class Rat
    {
        public PictureBox MyPictureBox;
        public int RatID;
        public int RatPosition;
        public decimal Odds;
        
        public Rat(int id, decimal odds)
        {
            RatID = id;

            Odds = odds;
        }
    }

}
