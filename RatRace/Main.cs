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
        PictureBox[] images = new PictureBox[5];
        Random rnd = new Random();
        public Main()
        {
            InitializeComponent();
            rm = new RaceManager();
            images[0] = pictureRat1;
            images[1] = pictureRat2;
            images[2] = pictureRat3;
            images[3] = pictureRat4;
            images[4] = pictureRat5;

        }

        private void BtnPlayer1_Click(object sender, EventArgs e)
        {
            BetScreen Bscr = new BetScreen(rm.Players[0], rm);
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
            images[0].Location = new Point(images[0].Location.X + rnd.Next(1, 21) + rnd.Next(1, 21), images[0].Location.Y);
            //images[1].Location = new Point(images[1].Location.X + rnd.Next(1, 21) + rnd.Next(1, 21), images[1].Location.Y);
            //images[2].Location = new Point(images[2].Location.X + rnd.Next(1, 21) + rnd.Next(1, 21), images[2].Location.Y);
            //images[3].Location = new Point(images[3].Location.X + rnd.Next(1, 21) + rnd.Next(1, 21), images[3].Location.Y);
            //images[4].Location = new Point(images[4].Location.X + rnd.Next(1, 21) + rnd.Next(1, 21), images[4].Location.Y);

        }

        public void FinishLine()
        {
            InitializeComponent();
            string msg = "Hej du vandt!";

             if (images[0].Location.X == 710 )
            {
                MessageBox.Show(msg);
            }
        }



    }
}
