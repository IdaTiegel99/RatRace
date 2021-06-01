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
        public Main()
        {
            InitializeComponent();
            rm  = new RaceManager();
        }

      
        private void BtnPlayer1_Click(object sender, EventArgs e)
        {
            BetScreen Bscr = new BetScreen(rm.Players[0]);
            Bscr.ShowDialog();
        }

        private void BtnPlayer2_Click(object sender, EventArgs e)
        {
            BetScreen Bscr = new BetScreen(rm.Players[1]);
            Bscr.ShowDialog();
        }

        private void BtnPlayer3_Click(object sender, EventArgs e)
        {
            BetScreen Bscr = new BetScreen(rm.Players[2]);
            Bscr.ShowDialog();
        }

        private void BtnPlayer4_Click(object sender, EventArgs e)
        {
            BetScreen Bscr = new BetScreen(rm.Players[3]);
            Bscr.ShowDialog();
        }

        private void BtnPlayer5_Click(object sender, EventArgs e)
        {
            BetScreen Bscr = new BetScreen(rm.Players[4]);
            Bscr.ShowDialog();
        }

        private void BtnMove_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
