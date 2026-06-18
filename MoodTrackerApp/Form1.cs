using System.IO;
using System.Text.Json;
using System.Security.Cryptography.X509Certificates;

namespace MoodTrackerApp
{
    public partial class Form1 : Form
    {
        // List to hold all the entries, and a variable to hold the current mood
        private List<TrackerEntry> entries = new List<TrackerEntry>();
        public string? CurrentEntry { get; set; }
        public string? CurrentMood;

        public Form1()
        {
            InitializeComponent();
            LoadEntries();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Creates a new entry based on the current selected values in the form
            var entry = new TrackerEntry
            {
                Date = dateTimePicker1.Value,
                Mood = CurrentMood,
                Stress = (int)numStress.Value,
                Energy = (int)numEnergy.Value,
                Notes = txtNotes.Text
            };

            // Chooses whether to overwrite an existing entry or add a new one based on whether an item in the listbox is selected
            if (listBox1.SelectedIndex != -1)
            {
                entries[listBox1.SelectedIndex] = entry; // overwrite
            }
            else
            {
                entries.Add(entry); // new entry
            }

            // COnverts the list of entries to JSON and saves it to a file, then reloads the entries to update the listbox
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(entries, options);

            File.WriteAllText("moodtracker.json", jsonString); //

            LoadEntries(); //refresh the ui 
            clearEntry(); //clear the form for the next entry
            listBox1.ClearSelected(); //makes sure nothing is selected in the listbox after saving
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

        // Helper method to add an entry to the listbox in the format "Date - Mood"
        public void addToListBox(TrackerEntry entry)
        {
            listBox1.Items.Add($"{entry.Date.ToShortDateString()} - Mood: {entry.Mood}");
        }

        // Helper method to reset the background colour of all the mood buttons to white
        public void clearColours()
        {
            btnMood0.BackColor = Color.White;
            btnMood1.BackColor = Color.White;
            btnMood2.BackColor = Color.White;
            btnMood3.BackColor = Color.White;
            btnMood4.BackColor = Color.White;
            btnMood5.BackColor = Color.White;
        }

        // Method to load entries from the JSON file
        private void LoadEntries()
        {
            if (File.Exists("moodtracker.json")) //if the file exists, read it and convert the JSON back into a list of TrackerEntry objects, then add each entry to the listbox
            {
                string json = File.ReadAllText("moodtracker.json");

                entries = JsonSerializer.Deserialize<List<TrackerEntry>>(json)
                          ?? new List<TrackerEntry>();

                listBox1.Items.Clear();

                // display each entry in the listbox
                foreach (TrackerEntry entry in entries)
                {
                    addToListBox(entry);
                }
            }
        }

        //pretty self explanaatory, clears the form and resets the current mood and the selected index of the listbox
        public void clearEntry()
        {
            btnCLear.Text = "Clear";

            listBox1.SelectedIndex = -1;

            clearColours();
            CurrentMood = null;
            numEnergy.Value = 0;
            numStress.Value = 0;
            txtNotes.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        // when an entry is selected in the listbox load its data into the form
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex == -1)
            {
                btnCLear.Text = "Clear"; // if no entry is selected, make sure the clear button says clear
                return;
            }

            btnCLear.Text = "Delete"; // changes the text of the clear button to delete when an entry is selected to make it more clear that it will delete the entry

            TrackerEntry entry = entries[listBox1.SelectedIndex]; // gets the selected entry from the list based on the selected index of the listbox

            // loads the data from the entry into the form
            dateTimePicker1.Value = entry.Date;
            CurrentMood = entry.Mood;

            numEnergy.Value = entry.Energy;
            numStress.Value = entry.Stress;
            txtNotes.Text = entry.Notes;

            clearColours();

            switch (entry.Mood)
            {
                case "Dead Inside":
                    btnMood0.BackColor = Color.Beige;
                    break;

                case "Awful":
                    btnMood1.BackColor = Color.Beige;
                    break;

                case "Bad":
                    btnMood2.BackColor = Color.Beige;
                    break;

                case "Alright":
                    btnMood3.BackColor = Color.Beige;
                    break;

                case "Good":
                    btnMood4.BackColor = Color.Beige;
                    break;

                case "Great!":
                    btnMood5.BackColor = Color.Beige;
                    break;
            }
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            clearEntry();
        }

        private void btnCLear_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1) // if an entry is selected, remove it from the list of entries, update the JSON file, and remove it from the listbox
            {
                int index = listBox1.SelectedIndex;

                entries.RemoveAt(index); //

                string json = JsonSerializer.Serialize(
                    entries,
                    new JsonSerializerOptions { WriteIndented = true });

                File.WriteAllText("moodtracker.json", json); 

                listBox1.Items.RemoveAt(index);

                clearEntry();
            }
            else // if no entry is selected, just clear the form
            {
                clearEntry();
            }
        }
    }
}