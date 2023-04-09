using MoodAnalyser;

namespace MoodAnalyserTest
{
    [TestClass]
    public class MoodTest
    {
        [TestMethod]
        public void TestAnalyseMoodSad()
        {
            Mood analyser = new Mood("I am in Sad Mood");
            string mood = analyser.AnalyseMood();
            Assert.AreEqual("SAD", mood);
        }

        [TestMethod]
        public void TestAnalyseMoodHappy()
        {
            Mood analyser = new Mood("I am in Any Mood");
            string mood = analyser.AnalyseMood();
            Assert.AreEqual("HAPPY", mood); 
        }

    }
}      

