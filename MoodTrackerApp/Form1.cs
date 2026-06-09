using System.IO;
using System.Text.Json;
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
            var entry = new TrackerEntry
            {
                Date = dateTimePicker1.Value,
                Mood = CurrentMood,
                Stress = (int)numStress.Value,
                Energy = (int)numEnergy.Value,
                Notes = txtNotes.Text
            };

            // Makes the json file like, easy to read for people?
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(entry, options);

            File.WriteAllText("moodtracker.json", jsonString);

            addToListBox(entry);
            clearEntry();
        }

        //Mood buttons, settingt the current mood to the text of the button thats clicked basically
        private void button1_Click(object sender, EventArgs e)
        {
            CurrentMood = btnMood0.Text;
            clearColours();
            btnMood0.BackColor = Color.Beige;
        }

        private void btnMood1_Click(object sender, EventArgs e)
        {
            CurrentMood = btnMood1.Text;
            clearColours();
            btnMood1.BackColor = Color.Beige;
        }

        private void btnMood2_Click_1(object sender, EventArgs e)
        {
            CurrentMood = btnMood2.Text;
            clearColours();
            btnMood2.BackColor = Color.Beige;
        }

        private void btnMood3_Click_1(object sender, EventArgs e)
        {
            CurrentMood = btnMood3.Text;
            clearColours();
            btnMood3.BackColor = Color.Beige;
        }

        private void btnMood4_Click_1(object sender, EventArgs e)
        {
            CurrentMood = btnMood4.Text;
            clearColours();
            btnMood4.BackColor = Color.Beige;
        }

        private void btnMood5_Click_1(object sender, EventArgs e)
        {
            CurrentMood = btnMood5.Text;
            clearColours();
            btnMood5.BackColor = Color.Beige;
        }


        public void addToListBox(TrackerEntry entry)
        {
            listBox1.Items.Add($"{entry.Date.ToShortDateString()} - Mood: {entry.Mood}");
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
        public void clearEntry()
        {
            clearColours();
            CurrentMood = null;
            numEnergy.Value = 0;
            numStress.Value = 0;
            txtNotes.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedItem = listBox1.SelectedItem.ToString() ?? "";
                string datePart = selectedItem.Split('-')[0].Trim();
                DateTime selectedDate = DateTime.Parse(datePart);
                string jsonString = File.ReadAllText("moodtracker.json");
                TrackerEntry entry = JsonSerializer.Deserialize<TrackerEntry>(jsonString) ?? new TrackerEntry();

                if (entry.Date == selectedDate.Date)
                {
                    numEnergy.Value = entry.Energy;
                    numStress.Value = entry.Stress;
                    txtNotes.Text = entry.Notes;

                    clearColours();
                    switch (entry.Mood)
                    {
                        case "Very Bad":
                            btnMood0.BackColor = Color.Beige;
                            break;
                        case "Bad":
                            btnMood1.BackColor = Color.Beige;
                            break;
                        case "Neutral":
                            btnMood2.BackColor = Color.Beige;
                            break;
                        case "Good":
                            btnMood3.BackColor = Color.Beige;
                            break;
                        case "Very Good":
                            btnMood4.BackColor = Color.Beige;
                            break;
                        case "Excellent":
                            btnMood5.BackColor = Color.Beige;
                            break;
                    }
                }
            }
        }

        private void btnCLear_Click(object sender, EventArgs e)
        {
            clearEntry();
        }
    }
}