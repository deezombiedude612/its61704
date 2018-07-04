using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WINNETAsgn2Program_1
{
    public partial class Welcome : Form
    {
        // Encapsulating data
        private static string name = "";
        private static string canCountry = "";
        // Declare it globally, so that anthem can be accessed globally.
        private SoundPlayer anthem;

        public Welcome()
        {
            InitializeComponent();
            
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            // Stop the background music
            try
            {
                anthem.Stop();
            }
            catch
            {
                // Does not catch anything because it is not important as long as it proceed
            }
            // Passing value from TextBox to variable in order to be used in next form
            name = txtName.Text;
            // Navigating to Test Form
            Test form1 = new Test();
            Hide();
            form1.Show();
        }

        // Getter for Name, used to display name in Test Form
        public string getName()
        {
            return name;
        }
        // Getter for Country image file, used to store country image file in finalresult.txt
        public string getCountry()
        {
            return canCountry;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        // Timer to change color of the text on every tick, creating flashing effects
        private void tmrFlashing_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255);
            label2.ForeColor = Color.FromArgb(A, R, G, B);
        }

        // When the form loads
        private void Main_Load(object sender, EventArgs e)
        {
            // Timer will start
            tmrFlashing.Start();
            tmrFlashing.Enabled = true;
            gbTest.Visible = false;
            // Positioning both groupboxes
            gbTest.SetBounds(130, 330, 254, 239);
            gbMenu.SetBounds(130, 330, 200, 200);
            // Fixing Client's Size
            this.ClientSize = new System.Drawing.Size(500, 600);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCountry.SelectedItem.ToString() == "Republic of Korea")
            {
                // If selected country is Republic of Korea
                // Anthem of the country will be played in loop
                anthem = new SoundPlayer("KoreaAnthem.wav");
                anthem.Stop();
                anthem.PlayLooping();
                // Pictures of the country will be displayed
                pb1.Image = Image.FromFile("korea1.jpg");
                pb2.Image = Image.FromFile("korea2.jpg");
                pb3.Image = Image.FromFile("korea3.JPG");
                pb4.Image = Image.FromFile("korea4.png");
                pb5.Image = Image.FromFile("korea5.jpg");
                // Candidate Country will be set to the global variable for later use
                canCountry = "Republic of KoreaFlag.png";
            }
            else if (cbCountry.SelectedItem.ToString() == "Latvia")
            {
                // If selected country is Latvia
                // Anthem of the country will be played in loop
                anthem = new SoundPlayer("LatviaAnthem.wav");
                anthem.Stop();
                anthem.PlayLooping();
                // Pictures of the country will be displayed
                pb1.Image = Image.FromFile("latvia1.png");
                pb2.Image = Image.FromFile("latvia2.png");
                pb3.Image = Image.FromFile("latvia3.png");
                pb4.Image = Image.FromFile("latvia4.png");
                pb5.Image = Image.FromFile("latvia5.png");
                // Candidate Country will be set to the global variable for later use
                canCountry = "LatviaFlag.png";

            }
            else if (cbCountry.SelectedItem.ToString() == "Maldives")
            {
                // If selected country is Maldives
                // Anthem of the country will be played in loop
                anthem = new SoundPlayer("MaldivesAnthem.wav");
                anthem.Stop();
                anthem.PlayLooping();
                // Pictures of the country will be displayed
                pb1.Image = Image.FromFile("maldives1.jpg");
                pb2.Image = Image.FromFile("maldives2.jpg");
                pb3.Image = Image.FromFile("maldives3.jpg");
                pb4.Image = Image.FromFile("maldives4.jpg");
                pb5.Image = Image.FromFile("maldives5.jpg");
                // Candidate Country will be set to the global variable for later use
                canCountry = "MaldivesFlag.png";

            }
            else if (cbCountry.SelectedItem.ToString() == "Oman")
            {
                // If selected country is Oman
                // Anthem of the country will be played in loop
                anthem = new SoundPlayer("OmanAnthem.wav");
                anthem.Stop();
                anthem.PlayLooping();
                // Pictures of the country will be displayed
                pb1.Image = Image.FromFile("Oman1.jpg");
                pb2.Image = Image.FromFile("Oman2.jpg");
                pb3.Image = Image.FromFile("Oman3.jpg");
                pb4.Image = Image.FromFile("Oman4.jpg");
                pb4.Image = Image.FromFile("Oman5.jpg");
                // Candidate Country will be set to the global variable for later use
                canCountry = "OmanFlag.png";

            }
            else if (cbCountry.SelectedItem.ToString() == "Mozambique")
            {
                // If selected country is Mozambique
                // Anthem of the country will be played in loop
                anthem = new SoundPlayer("mozambiquenationalanthem.wav");
                anthem.Stop();
                anthem.PlayLooping();
                // Pictures of the country will be displayed
                pb1.Image = Image.FromFile("mozam1.jpg");
                pb2.Image = Image.FromFile("mozam2.jpg");
                pb3.Image = Image.FromFile("mozam3.jpg");
                pb4.Image = Image.FromFile("mozam4.jpg");
                pb4.Image = Image.FromFile("mozam5.jpg");
                // Candidate Country will be set to the global variable for later use
                canCountry = "MozambiqueFlag.png";
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            // When "Attempt Test !" is selected, Menu will switched to Test Menu
            gbMenu.Visible = false;
            gbTest.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Application will exit
            Application.Exit();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            // Stop the background music
            try
            {
                anthem.Stop();
            }
            catch
            {
                // Does not catch anything because it is not important as long as it proceed
            }
            // Navigating to Result Form
            Result result = new Result();
            Hide();
            result.Show();
        }

        private void btnWinner_Click(object sender, EventArgs e)
        {
            // Stop the background music
            try
            {
                anthem.Stop();
            }
            catch
            {
                // Does not catch anything because it is not important as long as it proceed
            }
            // Navigating to Winner Form
            Winner winner = new Winner();
            Hide();
            winner.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            gbMenu.Visible = true;
            gbTest.Visible = false;
        }
    }
}
