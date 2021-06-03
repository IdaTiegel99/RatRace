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
        public double Odds;
        
        public Rat(int id, double odds)
        {
            RatID = id;

            Odds = 1+ odds/10;
        }
    }

}
