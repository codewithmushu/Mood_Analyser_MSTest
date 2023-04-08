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
            if (message.Contains("happy"))
            {
                return "Happy";
            }
            else if (message.Contains("sad"))
            {
                return "Sad";
            }
            else
            {
                return "Unknown";
            }
        }
    }
}
