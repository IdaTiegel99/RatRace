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
    public partial class NewGame : Form
    {
        Rat _ratWin;
        RaceManager _raceManager;

        
       

        public NewGame(Rat rats, RaceManager rm)
        {
            InitializeComponent();
            _ratWin = rats;
            rottelbl.Text ="Rat " + rats.RatID + " Wins!";
            rottelbl.Update();

            double tingelingelater = 0;
            _raceManager = rm;
            label2.Text = "Player ";
            foreach (Bet item in _raceManager.Bets)
            {
                if (item.RatID == rats)
                {
                  label2.Text += item.PlayerID.PlayerID + " Wins!";
                    tingelingelater = item.RatID.Odds * item.BetAmount;
                }
                break;
            }
            label3.Text = "Gevinst " +tingelingelater;

        }


        public void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void rottelbl_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
