using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Mood
    {
        private string message;

        public Mood(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            if (message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "Unknown";
            }
        }
    }
}
