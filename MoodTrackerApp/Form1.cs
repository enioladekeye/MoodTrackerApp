using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace MoodTrackerApp
{
    public partial class Form1 : Form
    {
        public string? CurrentEntry { get; set; }

        public string? CurrentMood;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TrackerEntry entry = new TrackerEntry(CurrentMood, (int)numStress.Value, (int)numEnergy.Value, txtNotes.Text);

            string filepath = "moodtracker.json";

            if (File.Exists(filepath))
            {

            }

            else
            {

            }
        }



        //Mood buttons, settingt the current mood to the text of the button thats clicked basically
        private void button1_Click(object sender, EventArgs e)
        {
            CurrentMood = btnMood0.Text;
            clearColours();
            btnMood0.BackColor = Color.FloralWhite;
        }

        private void btnMood1_Click(object sender, EventArgs e)
        {
            CurrentMood = btnMood1.Text;
            clearColours();
            btnMood1.BackColor = Color.FloralWhite;
            Console.WriteLine("Mood set to " + CurrentMood);
        }


        public void clearColours()
        {
            btnMood0.BackColor = Color.White;
            btnMood1.BackColor = Color.White;
            btnMood2.BackColor = Color.White;
            btnMood3.BackColor = Color.White;
            btnMood4.BackColor = Color.White;
            btnMood5.BackColor = Color.White;
        }

        private void btnMood2_Click_1(object sender, EventArgs e)
        {
            CurrentMood = btnMood2.Text;
            clearColours();
            btnMood2.BackColor = Color.FloralWhite;
        }

        private void btnMood3_Click_1(object sender, EventArgs e)
        {
            CurrentMood = btnMood3.Text;
            clearColours();
            btnMood3.BackColor = Color.FloralWhite;
        }

        private void btnMood4_Click_1(object sender, EventArgs e)
        {
            CurrentMood = btnMood4.Text;
            clearColours();
            btnMood4.BackColor = Color.FloralWhite;
        }

        private void btnMood5_Click_1(object sender, EventArgs e)
        {
            CurrentMood = btnMood5.Text;
            clearColours();
            btnMood5.BackColor = Color.FloralWhite;
        }
    }
}
