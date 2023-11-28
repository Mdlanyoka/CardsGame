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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tCsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This game programmed for windows\n" +
                "Click buttons you cannot touch them to play\n" +
                " ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            GamePage gameWindow = new GamePage();

            gameWindow.Show();
         }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HOW TO PLAY?\n\nThe deck has 52 cards and they are decreasing by 2 if you play\n" +
                "There are 26 rounds to play. If player's card is greater than the computer's cards, the player WINS\n" +
                "And if it appear cards with the same number both player and computer it a Tie.\n" +
                "If you play until the deck is finished you can Press Restart to start again the game\n" +
                "Playing cards are removed from the deck after appearing on screen. ");
        }

        private void MenuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Card game created for windows programming class\n\nCreated by Nhlakanipho Nsibande\n\nVersion 1.0 2022", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
