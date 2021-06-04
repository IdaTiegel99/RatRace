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
        Player _playsId;
        RaceManager _raceManager;


        public BetScreen(Player play, RaceManager rm)
        {
            InitializeComponent();
            double MoneyDraw = play.Money -  0;
            label2.Text = "" + MoneyDraw;
            label2.Update();
            _playsId = play;
            label1.Text = "Player " + play.PlayerID + " Bets";
            _raceManager = rm;

            BetRat1.Text = "Bet on Rat 1. \n" + "Odds: " + _raceManager.Rats[0].Odds;
            BetRat2.Text = "Bet on Rat 2. \n" + "Odds: " + _raceManager.Rats[1].Odds;
            BetRat3.Text = "Bet on Rat 3. \n" + "Odds: " + _raceManager.Rats[2].Odds;
            BetRat4.Text = "Bet on Rat 4. \n" + "Odds: " + _raceManager.Rats[3].Odds;
            BetRat5.Text = "Bet on Rat 5. \n" + "Odds: " + _raceManager.Rats[4].Odds;
        }

      

        private void BetRat1_Click(object sender, EventArgs e)
        {
            _raceManager.MakeBet(_playsId, _raceManager.Rats[0],(double)AmountPicker.Value); 
        }

        private void BetRat2_Click(object sender, EventArgs e)
        {
            _raceManager.MakeBet(_playsId, _raceManager.Rats[1], (double)AmountPicker.Value);

        }

        private void BetRat3_Click(object sender, EventArgs e)
        {
            _raceManager.MakeBet(_playsId, _raceManager.Rats[2], (double)AmountPicker.Value);

        }

        private void BetRat4_Click(object sender, EventArgs e)
        {
            _raceManager.MakeBet(_playsId, _raceManager.Rats[3], (double)AmountPicker.Value);

        }

        private void BetRat5_Click(object sender, EventArgs e)
        {
            _raceManager.MakeBet(_playsId, _raceManager.Rats[4], (double)AmountPicker.Value);

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
