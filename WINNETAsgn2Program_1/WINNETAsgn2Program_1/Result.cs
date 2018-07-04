using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace WINNETAsgn2Program_1
{
    public partial class Result : Form
    {
        // Declare it globally, so that anthem can be accessed globally.
        private List<string[]> ContestantsData;
        Test frmTest = new Test();

        public Result()
        {
            InitializeComponent();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            // Load contestant data
            loadFinalResult();
            gbResult.Visible = false;
        }

        // Method to load final result
        public List<string[]> loadFinalResult()
        {
            StreamReader datafile;
            string aLine;
            try
            {
                // Reading finalresult file for contestants answers
                datafile = new StreamReader("finalresult.txt");
                ContestantsData = new List<string[]>();

                aLine = datafile.ReadLine();
                while (datafile.Peek() != -1)
                {
                    aLine = datafile.ReadLine();
                    string[] wordList = Regex.Split(aLine, @":");
                    // Storing all the answers inside arraylist
                    ContestantsData.Add(wordList);
                }
                datafile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRORRRR : " + ex.Message);
            }
            foreach (var item in ContestantsData)
            {
                // Add name of the contestant into the combobox
                cbName.Items.Add(item[0]);
            }
            return ContestantsData;

        }
        // Method to compare answers
        public string compareAnswers(string[] selectedAns)
        {
            listAnswers.Clear();
            // Get questions' answers by running the method in Test Form
            string[] answer = frmTest.getAnswer();
            string ans;
            // Keeping track of number of correct answers
            int noOfCorrect = 0;
            for (int i = 1; i < answer.Length+1; i++)
            {
                // If answer selected by contestant is correct,
                if (answer[i - 1] == selectedAns[i + 1])
                {
                    // Answer will be displayed in the ListView in Green Color with a ✓ behind
                    ans = i + ". " + selectedAns[i + 1] + " ✓";
                    listAnswers.Items.Add(ans);
                    listAnswers.Items[i-1].ForeColor = Color.Green;
                    noOfCorrect++;
                }
                else
                {
                    // If answer selected by contestant is incorrect,
                    // Answer will be displayed in Red Color with X behind
                    ans = i + ". " + selectedAns[i + 1] + " X";
                    listAnswers.Items.Add(ans);
                    listAnswers.Items[i - 1].ForeColor = Color.Red;
                }

            }
            // Display number of correct the contestant get
            labCorrect.Text = noOfCorrect.ToString();
            // Calculate the score
            double score = Convert.ToDouble(noOfCorrect) / answer.Length;
            // Displaying it in percentage
            labPercent.Text = (Math.Round((score * 100))).ToString() + "%";
            // returning score
            return score.ToString();

        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // If the groupbox is not visible then make it visible
                if (gbResult.Visible == false)
                    gbResult.Visible = true;
                foreach (var item in ContestantsData)
                {
                    // Display contestant name, country flag and test result
                    if (cbName.SelectedItem.ToString() == item[0])
                    {
                        labName.Text = item[0];
                        pbResultCountry.Image = Image.FromFile(item[1]);
                        compareAnswers(item);
                        break;
                    }
                }
            }
            catch
            {

            }
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Navigate back to Welcome Form
            Hide();
            Welcome main = new Welcome();
            main.Show();

        }

        private void btnWinner_Click(object sender, EventArgs e)
        {
            // Navigate to Winner Form
            Hide();
            Winner winner = new Winner();
            winner.Show();
        }
    }


}
