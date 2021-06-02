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

        public NewGame()
        {
            InitializeComponent();
        }

        public NewGame(Rat rats, RaceManager rm)
        {
            InitializeComponent();
            _ratWin = rats;
            label3.Text ="" + rats.RatID;
            label3.Update();
            _raceManager = rm;
        }


        public void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
