namespace MoodTracker;

// Log and store a single mood entry
public class MoodEntry
{
    public int EntryId { get; set; }
    public DateTime Date { get; set; }
    public string Mood { get; set; }
    public string Note { get; set; }

    // Create a new mood entry constructor
    public MoodEntry(int entryId, DateTime date, string mood, string note)
    {
        EntryId = entryId;
        Date = date;
        Mood = mood;
        Note = note;
    }
}