namespace MoodTracker;

// Mood statistics
public class MoodStatistics
{
    List<MoodEntry> entries;

    public MoodStatistics(List<MoodEntry> entries)
    {
        this.entries = entries;
    }

    // Returns total count of each mood
    public Dictionary<string, int> GetMoodCount()
    {
        Dictionary<string, int> moodCount = new Dictionary<string, int>();

        foreach (MoodEntry entry in entries)
        {
            // Add mood to dictionary
            if (!moodCount.ContainsKey(entry.Mood))
                moodCount.Add(entry.Mood, 0);

            // Increment the count
            moodCount[entry.Mood]++;
        }

        return moodCount;
    }

    // Get the most frequently selected mood
    public string GetMostFrequentMood()
    {
        Dictionary<string, int> moodCount = GetMoodCount();

        string mostFrequent = "";
        int highest = -1;

        foreach (KeyValuePair<string, int> pair in moodCount)
        {
            if (pair.Value > highest)
            {
                mostFrequent = pair.Key;
                highest = pair.Value;
            }
        }

        return mostFrequent;
    }
}