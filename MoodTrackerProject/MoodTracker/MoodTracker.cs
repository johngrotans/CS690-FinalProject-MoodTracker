namespace MoodTracker;

// Handles mood entries and saves them to a file
public class MoodTracker
{
    List<MoodEntry> entries;
    int nextId;
    string fileName = "mood-entries.txt";

    public MoodTracker()
    {
        entries = new List<MoodEntry>();
        nextId = 1;

        // Load from file if it exists
        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);

            // Store id, date, and mood
            foreach (string line in lines)
            {
                string[] parts = line.Split(':');
                int id = int.Parse(parts[0]);
                DateTime date = DateTime.ParseExact(parts[1], "yyyyMMdd", null);
                string mood = parts[2];
                string note = parts[3];
                entries.Add(new MoodEntry(id, date, mood, note));
                nextId = id + 1;
            }
        }
    }

    // Add a mood entry and save to file
    public void AddEntry(string mood, string note)
    {
        MoodEntry entry = new MoodEntry(nextId, DateTime.Now, mood, note);
        entries.Add(entry);
        nextId++;

        // Write all entries to file
        List<string> lines = new List<string>();
        foreach (MoodEntry moodEntry in entries)
            lines.Add(moodEntry.EntryId + ":" + moodEntry.Date.ToString("yyyyMMdd") + ":" + moodEntry.Mood + ":" + moodEntry.Note);
        File.WriteAllLines(fileName, lines);
    }

    // Return the full list of entries
    public List<MoodEntry> GetAllEntries()
    {
        return entries;
    }
}