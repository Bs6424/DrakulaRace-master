using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrakulaRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Setup Defaults
            setup();
        }

        // Setup all the base elements for the race
        public void setup()
        {
            // Get's the start position
            int startPos = VampBlack.Left;

            // Calculates the length of the race track
            int RaceTrackLength = TrackLengthPanel.Width - VampBlack.Right;

            // Initializes all the racing vehicles
            Data.vampire[0] = new Vampire() { VampImage = VampBlack, startPos = startPos, finalPos = RaceTrackLength };
            Data.vampire[1] = new Vampire() { VampImage = VampGreen, startPos = startPos, finalPos = RaceTrackLength };
            Data.vampire[2] = new Vampire() { VampImage = VampPurple, startPos = startPos, finalPos = RaceTrackLength };
            Data.vampire[3] = new Vampire() { VampImage = VampBlue, startPos = startPos, finalPos = RaceTrackLength };

            // Initialize all the gamblers
            Data.bettor[0] = new BetPlacer() { balance = 65, activity = label1, listOfBettors = radioButton1, name = "Player 1" };
            Data.bettor[1] = new BetPlacer() { balance = 75, activity = label2, listOfBettors = radioButton2, name = "Player 2" };
            Data.bettor[2] = new BetPlacer() { balance = 55, activity = label3, listOfBettors = radioButton3, name = "Player 3" };

            // Update all the activity labels to default
            Data.bettor[0].UpdateActivity();
            Data.bettor[1].UpdateActivity();
            Data.bettor[2].UpdateActivity();

            // Reset all the starts to defaults
            Data.bettor[0].ResetStats();
            Data.bettor[1].ResetStats();
            Data.bettor[2].ResetStats();
        }

        public void ResetPositions()
        {
            Data.vampire[0].MoveToStart();
            Data.vampire[1].MoveToStart();
            Data.vampire[2].MoveToStart();
            Data.vampire[3].MoveToStart();
        }

        public void ResetBidsText()
        {
            label1.Text = "Player 1 hasn't placed a bit.";
            label2.Text = "Player 2 hasn't placed a bit.";
            label3.Text = "Player 3 hasn't placed a bit.";
        }

        public void announceWinner(int winner)
        {
            MessageBox.Show("Vampire #" + winner + " is the winning Vampire!");
            for (int i = 0; i < Data.bettor.Length; i++)
            {
                Data.bettor[i].collectWinningAmount(winner);
                Data.bettor[i].UpdateActivity();
                ResetPositions();
                ResetBidsText();
            }
        }

        private void RaceTime_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Data.vampire.Length; i++)
            {
                Data.vampire[Data.rand.Next(0, 4)].isAccelerating();
                if (Data.vampire[i].isAccelerating())
                {
                    RaceTime.Stop();
                    RaceTime.Enabled = false;
                    StartRace.Enabled = true;
                    announceWinner(i + 1);
                }
            }
        }

        private void PlaceBet_Click(object sender, EventArgs e)
        {
            Data.bettor[Data.currentGambler].betting((int)numericUpDown1.Value, (int)numericUpDown2.Value);
            Data.bettor[Data.currentGambler].UpdateActivity();
        }

        private void StartRace_Click(object sender, EventArgs e)
        {
            RaceTime.Start();
            StartRace.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Data.currentGambler = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Data.currentGambler = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Data.currentGambler = 2;
        }
    }
}
