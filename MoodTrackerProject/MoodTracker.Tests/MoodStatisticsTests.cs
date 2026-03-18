namespace MoodTracker.Tests
{
    public class MoodStatisticsTests
    {
        [Fact]
        public void CheckGetMoodCount()
        {
            // Create a test list
            var entries = new List<MoodEntry>
            {
                new MoodEntry(1, DateTime.Now, "Happy", ""),
                new MoodEntry(2, DateTime.Now, "Sad", ""),
                new MoodEntry(3, DateTime.Now, "Happy", ""),
            };
            
            var stats = new MoodStatistics(entries);
            // Get mood count
            var result = stats.GetMoodCount();

            Assert.Equal(2, result["Happy"]);
            Assert.Equal(1, result["Sad"]);
        }

        [Fact]
        public void CheckGetMostFrequentMood()
        {
            // Create a test list
            var entries = new List<MoodEntry>
            {
                new MoodEntry(1, DateTime.Now, "Happy", ""),
                new MoodEntry(2, DateTime.Now, "Sad", ""),
                new MoodEntry(3, DateTime.Now, "Happy", ""),
            };
            var stats = new MoodStatistics(entries);
            // Happy should be returned as most frequent
            Assert.Equal("Happy", stats.GetMostFrequentMood());
        }

        [Fact]
        public void CheckMostFrequentMoodEmpty()
        {
            // No entries
            var stats = new MoodStatistics(new List<MoodEntry>());
            // Return empty
            Assert.Equal("", stats.GetMostFrequentMood());
        }
    }
}