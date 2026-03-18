namespace MoodTracker.Tests
{
    public class MoodEntryTests
    {
        [Fact]
        public void CheckCorrectEntryInputs()
        {
            // Set a date and create new entry
            var date = new DateTime(2026, 3, 16);
            var entry = new MoodEntry(1, date, "Happy", "I won the lottery.");
            
            // Check that each property was set correctly
            Assert.Equal(1, entry.EntryId);
            Assert.Equal(date, entry.Date);
            Assert.Equal("Happy", entry.Mood);
            Assert.Equal("I won the lottery.", entry.Note);
        }
    }
}
