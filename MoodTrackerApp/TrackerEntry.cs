using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodTrackerApp
{
    public class TrackerEntry
    {
        public DateTime Date { get; set; }
        public string? Mood { get; set; }
        public int Stress { get; set; }
        public int Energy { get; set; }
        public string? Notes { get; set; }

        public TrackerEntry(string? mood, int stress, int energy, string? notes)
        {
            Date = DateTime.Now;
            Mood = mood;
            Stress = stress;
            Energy = energy;
            Notes = notes; //Somethig to note for here is that this box literally cant take commas for now so we need to make that possible somewwhere along the line k?
        }


    }

    
}
