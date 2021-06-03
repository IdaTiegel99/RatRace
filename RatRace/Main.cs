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
        string _op1 = "Only Player 1 can place bets. This button is just for show...";
        string _op1t = "It's not a bug, but a feature.";
        public int RatIdInt;
        RaceManager _rm;
        PictureBox[] _images = new PictureBox[5];
        Random _rnd = new Random();
        public Main()
        {
            InitializeComponent();
            _rm = new RaceManager();
            _images[0] = pictureRat1;
            _images[1] = pictureRat2;
            _images[2] = pictureRat3;
            _images[3] = pictureRat4;
            _images[4] = pictureRat5;

        }

        public Main(Rat rID)
        {
            RatIdInt = rID.RatID;
        }

        private void BtnPlayer1_Click(object sender, EventArgs e)
        {
            BetScreen Bscr = new BetScreen(_rm.Players[0], _rm);
            Bscr.ShowDialog();
        }

        private void BtnPlayer2_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(_op1, _op1t);
        }

        private void BtnPlayer3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_op1, _op1t);
        }

        private void BtnPlayer4_Click(object sender, EventArgs e)
        { 
            MessageBox.Show(_op1, _op1t); 
        }

        private void BtnPlayer5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_op1, _op1t);
        }

        private void BtnMove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                _images[i].Location = new Point(_images[i].Location.X + _rnd.Next(1, 21) + _rnd.Next(1, 21), _images[i].Location.Y);
                if (_images[i].Location.X > 700)
                {
                    
                    NewGame ng = new NewGame(_rm.Rats[i],_rm);
                    ng.ShowDialog();
                    return;
                }
            }
        }

        private void pictureRat3_Click(object sender, EventArgs e)
        {

        }
    }
}

