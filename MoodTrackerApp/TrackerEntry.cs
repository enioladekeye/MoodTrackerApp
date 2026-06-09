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

    }  
}
