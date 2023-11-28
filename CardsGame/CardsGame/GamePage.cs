using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardsGame
{
    public partial class GamePage : Form
    {
        int score = 0;
        int cardLeft = 52;

        int rounds = 0;
        Form1 obj = new Form1();
        public GamePage()
        {
            InitializeComponent();
        }

        private void cardSelection_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("DO YOU REALLY WANT TO EXIT THE GAME?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                // Close();

            }
            else if (result == DialogResult.Yes)
            {
                //this.Close();
                //Form1 obj = new Form1();
                obj.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GamePage_Load(object sender, EventArgs e)
        {

        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnPause_Click(object sender, EventArgs e)
        {

            btnPause.Text = "RESUME";

            MessageBox.Show("THE GAME IS PAUSED, PRESS OK TO RESUME");
            btnPause.Text = "PAUSE";
        }
        int a = 0, b = 0, c = 51;
        private void btnPlay_Click(object sender, EventArgs e)
        {

            try
            {


                --cardLeft;
                cardLeft = cardLeft - 2;
                if (rounds > 26)
                {
                    lblCardsLeft.Text = "Cards Left " + cardLeft;
                    cardLeft = 52;
                }


                picComputer.Left += 1;
                picYou.Left += 1;


                if (picYou.Visible)
                {
                   
                    score += 1;
                    txtComputer.Text = score.ToString();
                    score += 2;
                    txtHigh.Text = score.ToString();
                    score += 1;
                    txtYour.Text = score.ToString();
                    cardLeft -= 1;
                    txtLeftCards.Text = cardLeft.ToString();
                    lblStatus.Text = "You WIN!! ".ToString();
                }
                else if (score > 26)
                {
                    MessageBox.Show("You WIN!! ");
                }
                else
                {
                    MessageBox.Show("You WIN!! ");
                }
            }


            catch (Exception Error)
            {
                MessageBox.Show("Empty");
            }

        


            try
            {
                ++rounds;

                if (rounds > 26)
                {
                    MessageBox.Show("GAME OVER!!!");
                }
                else
                {
                    lblRounds.Text = "Rounds  " + rounds.ToString();
                }
                
                {
                  
                }
            
                


                Random random = new Random();
                int v = random.Next(0, 51);
                int v1 = random.Next(0, 51);
                picYou.Image = imageList1.Images[v];
                picComputer.Image = imageList1.Images[v1];

                if (rounds > 26)
                {
                  

                }
             

                if (v == 51)
                {
                    a = 0;
                    b = 0;
                    c = 0;
                }
            
            }
            catch (Exception c) 
            {
                MessageBox.Show("Empty");
            }
            
        } 
       
        private void Rounds_Click(object sender, EventArgs e)
        {

        }


        private void ColorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDig = new ColorDialog();
            if (colorDig.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDig.Color;
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("DO YOU WANT TO RESTART THE GAME?", "RESTART", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)

            {
                txtComputer.Text = " " + 0;
                txtYour.Text = " " + 0;
                txtHigh.Text = " " + 0;
                txtLeftCards.Text = " " + 0;
                lblRounds.Text = "Rounds " + 0;
                rounds = 0;
            }
             else if (result == DialogResult.No)
            {
               
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void rateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rate us on\n\nhttp//cards/game.ac.za");
        }

        private void playOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ooops!!! Error 404 NOT FOUND");
        }

        private void txtYour_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void languageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
