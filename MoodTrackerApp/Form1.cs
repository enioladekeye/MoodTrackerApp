using System.IO;

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

        }



        //Mood buttons, settingt the current mood to the text of the buttin thats clicked basically
        private void button1_Click(object sender, EventArgs e)
        {
            CurrentMood = btnMood0.Text;
        }

        private void btnMood1_Click(object sender, EventArgs e)
        {
            CurrentMood = btnMood1.Text;
        }

        private void btnMood2_Click(object sender, EventArgs e)
        {
            CurrentMood = btnMood2.Text;
        }

        private void btnMood3_Click(object sender, EventArgs e)
        {
            CurrentMood = btnMood3.Text;
        }

        private void btnMood4_Click(object sender, EventArgs e)
        {
            CurrentMood = btnMood4.Text;
        }

        private void btnMood5_Click(object sender, EventArgs e)
        {
            CurrentMood = btnMood5.Text;
        }


    }
}
