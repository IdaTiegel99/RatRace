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
    public partial class BetScreen : Form
    {
        Player _plays;
        Player _playsId;
        RaceManager _raceManager;

        public BetScreen(Player play, RaceManager rm)
        {
            InitializeComponent();
            _plays = play;
            label2.Text = "" + play.Money;
            label2.Update();
            _playsId = play;
            label1.Text = "Player " + play.PlayerID + " Bets";
            _raceManager = rm;
        }

        private void BetRat1_Click(object sender, EventArgs e)
        {
            //raceManager.Rats[0]; // Hier ist deine ratte mein fräulein!
        }

        private void BetRat2_Click(object sender, EventArgs e)
        {

        }

        private void BetRat3_Click(object sender, EventArgs e)
        {

        }

        private void BetRat4_Click(object sender, EventArgs e)
        {

        }

        private void BetRat5_Click(object sender, EventArgs e)
        {

        }

        private void BetDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
