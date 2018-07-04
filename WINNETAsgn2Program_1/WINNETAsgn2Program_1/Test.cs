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
    public partial class Test : Form
    {
        // Declare it globally, so that anthem can be accessed globally.
        private int activeQuestion;
        private int maxQuestion;
        private string[] questions;
        private char[] selectedAns;
        Welcome frmMain;

        public Test()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Positioning
            this.ClientSize = new System.Drawing.Size(350, 762);
            groupBox2.SetBounds(50, 180, 275, 475);
            groupBox3.SetBounds(50, 180, 275, 475);
            activeQuestion = 0;
            frmMain = new Welcome();
            // Get Name of the candidates from Welcome Form and display it
            labName.Text = frmMain.getName();
            try
            {
                // Displaying CountryFlag of the candidate
                pbFlag.Image = Image.FromFile(frmMain.getCountry());
            }
            catch
            {
                // Displaying error image when unable to getCountryFlag of the candidate
                pbFlag.Image = Image.FromFile("imgnotfound.png");
            }
            loadQuestionFile();
        }

        private void loadQuestionFile()
        {
            StreamReader datafile;
            string aLine;
            try
            {
                // Loading questions from file
                datafile = new StreamReader("muuq.txt");
                // Reading number of questions from file
                aLine = datafile.ReadLine();
                maxQuestion = Convert.ToInt32(aLine);
                // Creating arrays based on number of questions
                questions = new string[maxQuestion];
                selectedAns = new char[maxQuestion];
                int k = 0;
                while (datafile.Peek() != -1)
                {
                    // Reading questions and save in array
                    questions[k] = datafile.ReadLine();
                    k++;
                }
                datafile.Close();
            }
            catch (Exception ex)
            {
                // Displaying error messages
                MessageBox.Show("ERRORRRR : " + ex.Message);
            }
        }

        public string[] getAnswer()
        {
            // Load questions again
            loadQuestionFile();
            // Creating array that store answers with MaxQuestion size
            string[] answers = new string[maxQuestion];
            int k = 0;
            foreach(var question in questions)
            {
                // Splitting the questions
                string[] wordList = Regex.Split(question, @":");
                // Saving each answer of question into the answer array
                answers[k] = wordList[1];
                k++;
            }
            // Return the answer array
            return answers;
        }


        private void displayQuestion()
        {
            string aLine;

            aLine = questions[activeQuestion];
            string[] wordList = Regex.Split(aLine, @":");
            int quesType = Convert.ToInt32(wordList[0]);
            // If question type is 1
            if (quesType == 1)
            {
                // Hiding other question types and showing question type 1 groupbox
                groupBox1.Visible = true;
                groupBox3.Visible = false;
                groupBox2.Visible = false;
                // Resetting answers
                radType1A.Checked = false;
                radType1B.Checked = false;
                radType1C.Checked = false;
                radType1D.Checked = false;
                // Select answer again if user selected the answer previously
                if (selectedAns[activeQuestion] == 'A')
                    radType1A.Checked = true;
                else if (selectedAns[activeQuestion] == 'B')
                    radType1B.Checked = true;
                else if (selectedAns[activeQuestion] == 'C')
                    radType1C.Checked = true;
                else if (selectedAns[activeQuestion] == 'D')
                    radType1D.Checked = true;
                // Loading questions and answers 
                labQType1.Text = wordList[2];
                radType1A.Text = wordList[3];
                radType1B.Text = wordList[4];
                radType1C.Text = wordList[5];
                radType1D.Text = wordList[6];
            }
            // If question type is 2
            else if (quesType == 2)
            {
                
                // Resetting answers
                radType2A.Checked = false;
                radType2B.Checked = false;
                radType2C.Checked = false;
                radType2D.Checked = false;
                // Hiding other question types and showing question type 2 groupbox
                groupBox1.Visible = false;
                groupBox3.Visible = false;
                groupBox2.Visible = true;

                // Select answer again if user selected the answer previously
                if (selectedAns[activeQuestion] == 'A')
                    radType2A.Checked = true;
                else if (selectedAns[activeQuestion] == 'B')
                    radType2B.Checked = true;
                else if (selectedAns[activeQuestion] == 'C')
                    radType2C.Checked = true;
                else if (selectedAns[activeQuestion] == 'D')
                    radType2D.Checked = true;
                // Display questions and answers
                labQType2.Text = wordList[2];
                // Reading image string
                string picFile = wordList[3];
                // Displaying image
                picQuestion.Image = Image.FromFile(picFile);
                radType2A.Text = wordList[4];
                radType2B.Text = wordList[5];
                radType2C.Text = wordList[6];
                radType2D.Text = wordList[7];
            }
            // If question type is 3
            else if (quesType == 3)
            {
                // Hiding other question types and showing question type 3 groupbox
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = true;
                // Resetting answers
                radType3A.Checked = false;
                radType3B.Checked = false;
                radType3C.Checked = false;
                radType3D.Checked = false;
                // Select answer again if user selected the answer previously
                if (selectedAns[activeQuestion] == 'A')
                    radType3A.Checked = true;
                else if (selectedAns[activeQuestion] == 'B')
                    radType3B.Checked = true;
                else if (selectedAns[activeQuestion] == 'C')
                    radType3C.Checked = true;
                else if (selectedAns[activeQuestion] == 'D')
                    radType3D.Checked = true;
                // Display questions and answers
                labQType3.Text = wordList[2];
                // Displaying image
                pbType3A.Image = Image.FromFile(wordList[3]);
                pbType3B.Image = Image.FromFile(wordList[4]);
                pbType3C.Image = Image.FromFile(wordList[5]);
                pbType3D.Image = Image.FromFile(wordList[6]);
            }
            // Display the numbers of current and total questions
            labActiveQuestion.Text = (activeQuestion + 1) + " of " + maxQuestion;
            labDebug.Text = "";

            // Disabling previous button if it's the first question
            if (activeQuestion == 0)
            {
                btnPrev.Enabled = false;
                btnNext.Enabled = true;
            }
            // Disabling next button if it's the last question
            else if (maxQuestion == (activeQuestion + 1))
            {
                btnPrev.Enabled = true;
                btnNext.Enabled = false;
            }
            else
            {
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Switching to next question
            activeQuestion++;
            displayQuestion();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            // Going back to the previous question
            activeQuestion--;
            displayQuestion();
        }

        private void radType1A_Click(object sender, EventArgs e)
        {
            // Add answer to the array when radio button is selected
            selectedAns[activeQuestion] = 'A';
        }

        private void radType1B_Click(object sender, EventArgs e)
        {
            // Add answer to the array when radio button is selected
            selectedAns[activeQuestion] = 'B';
        }

        private void radType1C_Click(object sender, EventArgs e)
        {
            // Add answer to the array when radio button is selected
            selectedAns[activeQuestion] = 'C';
        }
        private void radType1D_Click(object sender, EventArgs e)
        {
            // Add answer to the array when radio button is selected
            selectedAns[activeQuestion] = 'D';
        }

        private void radType2A_Click(object sender, EventArgs e)
        {
            // Add answer to the array when radio button is selected
            selectedAns[activeQuestion] = 'A';
        }

        private void radType2B_Click(object sender, EventArgs e)
        {
            // Add answer to the array when radio button is selected
            selectedAns[activeQuestion] = 'B';
        }

        private void radType2C_Click(object sender, EventArgs e)
        {
            // Add answer to the array when radio button is selected
            selectedAns[activeQuestion] = 'C';
        }
        private void radType2D_Click(object sender, EventArgs e)
        {
            // Add answer to the array when radio button is selected
            selectedAns[activeQuestion] = 'D';
        }

        private void radType3A_Click(object sender, EventArgs e)
        {
            // Add answer to the array when radio button is selected
            selectedAns[activeQuestion] = 'A';
        }

        private void radType3B_Click(object sender, EventArgs e)
        {
            // Add answer to the array when radio button is selected
            selectedAns[activeQuestion] = 'B';
        }

        private void radType3C_Click(object sender, EventArgs e)
        {
            // Add answer to the array when radio button is selected
            selectedAns[activeQuestion] = 'C';
        }
        private void radType3D_Click(object sender, EventArgs e)
        {
            // Add answer to the array when radio button is selected
            selectedAns[activeQuestion] = 'D';
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (btnCancel.Visible)
            {
                // Writing results into file
                string filename = "finalresult.txt";
                StreamWriter file = new StreamWriter(filename, true);
                string aLine = "\r\n";
                // Constructing a string to write as a line
                // Name of the candidate, countryflag image file, with their selected answers
                aLine = aLine + labName.Text + ":" + frmMain.getCountry() + ":";
                for (int k = 0; k < maxQuestion; k++)
                    aLine = aLine + selectedAns[k] + ":";
                file.Write(aLine);
                file.Close();
                // Navigate back to Welcome Form
                Hide();
                frmMain.Show();
            }
            else
            {
                btnCancel.Visible = true;
                btnSubmit.Text = "Submit?";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = false;
            btnSubmit.Text = "Submit";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            displayQuestion();
        }

        private void pbType3A_Click(object sender, EventArgs e)
        {
            // Add answer to the array when picture is clicked
            selectedAns[activeQuestion] = 'A';
            radType3A.Checked = true;
        }

        private void pbType3B_Click(object sender, EventArgs e)
        {
            // Add answer to the array when picture is clicked
            selectedAns[activeQuestion] = 'B';
            radType3B.Checked = true;

        }

        private void pbType3C_Click(object sender, EventArgs e)
        {
            // Add answer to the array when picture is clicked
            selectedAns[activeQuestion] = 'C';
            radType3C.Checked = true;

        }

        private void pbType3D_Click(object sender, EventArgs e)
        {
            // Add answer to the array when picture is clicked
            selectedAns[activeQuestion] = 'D';
            radType3D.Checked = true;

        }
    }

}