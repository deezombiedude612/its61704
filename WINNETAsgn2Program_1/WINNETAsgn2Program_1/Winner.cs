using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WINNETAsgn2Program_1
{
    public partial class Winner : Form
    {
        // Declare it globally, so that anthem can be accessed globally.
        private List<string[]> ContestantsData;
        private List<string[]> winner = new List<string[]>();
        public Winner()
        {
            InitializeComponent();
        }

        // Timer to change color of the text on every tick, creating flashing effects
        private void tmrWinner_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            label7.ForeColor = Color.FromArgb(A, R, G, B);
        }

        private void Winner_Load(object sender, EventArgs e)
        {
            // Timer will start
            tmrWinner.Start();
            tmrWinner.Enabled = true;
            Result frmResult = new Result();
            // Contestants answers will be retrieved
            ContestantsData = frmResult.loadFinalResult();
            foreach (var contestant in ContestantsData)
            {
                // For each contestant,
                string[] data = new string[4];
                // Contestant Name
                data[0] = contestant[0];
                // Score achieved by the contestant
                data[1] = frmResult.compareAnswers(contestant);
                // Manipulate contestant's country flag image file remove "Flag", in order to get Contestant Miss Universe Image File
                data[2] = contestant[1].Remove(contestant[1].Length-8)+".png";
                // Contestant country flag
                data[3] = contestant[1];
                // will be extracted and saved into temporary array then save into winner ArrayList
                winner.Add(data);
            }
            // With data of all contestants, run the method findWinner to find the winner
            findWinner(winner);
        }

        private void findWinner(List<string[]> contestants)
        {
            double[] allscore = new double[contestants.Count];
            // Convert score that is string to Double and save it into an array for comparison 
            for (int i = 0; i < contestants.Count; i++)
            {
                allscore[i] = Convert.ToDouble(contestants[i][1]);
            }
            // Sort the array that contain the score in ascending order
            Array.Sort(allscore);
            // Reverse the content in array to descending order
            // So that highest score will be the first index
            Array.Reverse(allscore);

            foreach (var contestant in contestants)
            {
                try
                {
                    // if contestant's score is same as the highest score
                    if (allscore[0].ToString() == contestant[1])
                    {
                        // Display name, score, image and country flag
                        labWin1N.Text = contestant[0];
                        labWin1S.Text = (Math.Round((allscore[0] * 100),2)).ToString() + "%";
                        pbWin1.Image = Image.FromFile(contestant[2]);
                        pbWin1C.Image = Image.FromFile(contestant[3]);
                    }
                }
                catch
                {
                    // If not enough contestant in database, nothing will happen
                }

                try
                {
                    // if contestant's score is same as the score
                    if (allscore[1].ToString() == contestant[1])
                    {
                        // Display name, score, image and country flag
                        labWin2N.Text = contestant[0];
                        labWin2S.Text = (Math.Round((allscore[1] * 100), 2)).ToString() + "%";
                        pbWin2.Image = Image.FromFile(contestant[2]);
                        pbWin2C.Image = Image.FromFile(contestant[3]);

                    }
                }
                catch
                {
                    // If not enough contestant in database, nothing will happen
                }

                try
                {
                    // if contestant's score is same as the score
                    if (allscore[2].ToString() == contestant[1])
                    {
                        // Display name, score, image and country flag
                        labWin3N.Text = contestant[0];
                        labWin3S.Text = (Math.Round((allscore[2] * 100), 2)).ToString() + "%";
                        pbWin3.Image = Image.FromFile(contestant[2]);
                        pbWin3C.Image = Image.FromFile(contestant[3]);

                    }
                }
                catch
                {
                    // If not enough contestant in database, nothing will happen
                }

                try
                {
                    // if contestant's score is same as the score
                    if (allscore[3].ToString() == contestant[1])
                    {
                        // Display name, score, image and country flag
                        labWin4N.Text = contestant[0];
                        labWin4S.Text = (Math.Round((allscore[3] * 100), 2)).ToString() + "%";
                        pbWin4.Image = Image.FromFile(contestant[2]);
                        pbWin4C.Image = Image.FromFile(contestant[3]);

                    }
                }
                catch
                {
                    // If not enough contestant in database, nothing will happen
                }

                try
                {
                    // if contestant's score is same as the score
                    if (allscore[4].ToString() == contestant[1])
                    {
                        // Display name, score, image and country flag
                        labWin5N.Text = contestant[0];
                        labWin5S.Text = (Math.Round((allscore[4] * 100), 2)).ToString() + "%";
                        pbWin5.Image = Image.FromFile(contestant[2]);
                        pbWin5C.Image = Image.FromFile(contestant[3]);
                    }
                }
                catch
                {
                    // If not enough contestant in database, nothing will happen
                }

            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Navigate back to Welcome Form
            Hide();
            Welcome main = new Welcome();
            main.Show();
        }

        private void pbWin2C_Click(object sender, EventArgs e)
        {

        }

        private void pbWin3C_Click(object sender, EventArgs e)
        {

        }

        private void pbWin4C_Click(object sender, EventArgs e)
        {

        }

        private void pbWin1C_Click(object sender, EventArgs e)
        {

        }

        private void pbWin5C_Click(object sender, EventArgs e)
        {

        }
    }
}
