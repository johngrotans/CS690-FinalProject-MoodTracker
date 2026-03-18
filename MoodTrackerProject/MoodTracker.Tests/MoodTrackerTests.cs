namespace MoodTracker.Tests
{
    public class MoodTrackerTests
    {
        [Fact]
        public void CheckAddEntry()
        {
            // Create fresh tracker
            if (File.Exists("mood-entries.txt")) File.Delete("mood-entries.txt");
            var tracker = new MoodTracker();

            // Add entry
            tracker.AddEntry("Happy", "I won the lottery.");

            // List entry
            Assert.Single(tracker.GetAllEntries());
        }

        [Fact]
        public void CheckEditEntry()
        {
            // Create fresh tracker
            if (File.Exists("mood-entries.txt")) File.Delete("mood-entries.txt");
            var tracker = new MoodTracker();
            tracker.AddEntry("Happy", "I won the lottery.");
            int id = tracker.GetAllEntries()[0].EntryId;

            // Edit entry
            tracker.EditEntry(id, "Sad", "I fell in the mud.");

            // Mood and note should be updated
            var entry = tracker.GetAllEntries()[0];
            Assert.Equal("Sad", entry.Mood);
            Assert.Equal("I fell in the mud.", entry.Note);
        }

        [Fact]
        public void CheckDeleteEntry()
        {
            // Create fresh tracker
            if (File.Exists("mood-entries.txt")) File.Delete("mood-entries.txt");
            var tracker = new MoodTracker();
            tracker.AddEntry("Happy", "I won the lottery.");
            int id = tracker.GetAllEntries()[0].EntryId;

            // Delete entry
            tracker.DeleteEntry(id);

            // List should be empty
            Assert.Empty(tracker.GetAllEntries());
        }

        [Fact]
        public void CheckLoadFile()
        {
            // Create a file to load
            if (File.Exists("mood-entries.txt")) File.Delete("mood-entries.txt");
            File.WriteAllLines("mood-entries.txt", new[] { "1:20240101:Happy:I won the lottery." });

            // Load entry from file
            var tracker = new MoodTracker();

            Assert.Single(tracker.GetAllEntries());
            Assert.Equal("Happy", tracker.GetAllEntries()[0].Mood);
        }

        [Fact]
        public void CheckEntryExists()
        {
            if (File.Exists("mood-entries.txt")) File.Delete("mood-entries.txt");
            var tracker = new MoodTracker();
            tracker.AddEntry("Happy", "I won the lottery.");
            int id = tracker.GetAllEntries()[0].EntryId;

            Assert.True(tracker.EntryExists(id));
        }

        [Fact]
        public void CheckEntryDoesntExist()
        {
            if (File.Exists("mood-entries.txt")) File.Delete("mood-entries.txt");
            var tracker = new MoodTracker();

            Assert.False(tracker.EntryExists(999));
        }
    }
}