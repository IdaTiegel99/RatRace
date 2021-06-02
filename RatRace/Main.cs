using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RatRace
{
    public partial class Main : Form
    {
        RaceManager rm;
        Rat ratID;
        PictureBox[] images = new PictureBox[5];
        Random rnd = new Random();
        public Main()
        {
            InitializeComponent();
            rm  = new RaceManager();
            images[0] = pictureRat1;
        }
        public Main (Rat rats)
        {
            InitializeComponent();
            ratID = rats;
        }
      
        private void BtnPlayer1_Click(object sender, EventArgs e)
        {
            BetScreen Bscr = new BetScreen(rm.Players[0],rm);
            Bscr.ShowDialog();
        }

        private void BtnPlayer2_Click(object sender, EventArgs e)
        {
            BetScreen Bscr = new BetScreen(rm.Players[1], rm);
            Bscr.ShowDialog();
        }

        private void BtnPlayer3_Click(object sender, EventArgs e)
        {
            BetScreen Bscr = new BetScreen(rm.Players[2], rm);
            Bscr.ShowDialog();
        }

        private void BtnPlayer4_Click(object sender, EventArgs e)
        {
            BetScreen Bscr = new BetScreen(rm.Players[3], rm);
            Bscr.ShowDialog();
        }

        private void BtnPlayer5_Click(object sender, EventArgs e)
        {
            BetScreen Bscr = new BetScreen(rm.Players[4], rm);
            Bscr.ShowDialog();
        }

        private void BtnMove_Click(object sender, EventArgs e)
        {
            images[0].Location = new Point(images[0].Location.X +rnd.Next(1,21) +rnd.Next(1,21) , images[0].Location.Y);
        }

       

       
    }
}
