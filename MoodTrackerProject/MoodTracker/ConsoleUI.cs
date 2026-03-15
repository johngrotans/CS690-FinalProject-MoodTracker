namespace MoodTracker;

public class ConsoleUI
{
    MoodTracker tracker;

    public ConsoleUI() {
        tracker = new MoodTracker();
    }

    public void Show()
    {
        string command;
        do {
            // Print the main menu options
            Console.WriteLine();
            Console.WriteLine("===== Mood Tracker =====");
            Console.WriteLine("1. Log Daily Mood");
            Console.WriteLine("2. View Mood Statistics");
            Console.WriteLine("3. View Mood History");
            Console.WriteLine("4. Manage Mood Entries");
            Console.WriteLine("5. Exit");
            Console.WriteLine("=========================");
            Console.Write("Choose an option (1-5): ");

            // Read the input
            command = Console.ReadLine() ?? "";

            // Prompt for option 1 log daily mood
            if (command == "1") {
                Console.WriteLine();

                string mood = "";

                // Loop until valid input selected
                while (true) {
                    Console.WriteLine("=== How are you feeling today? ===");
                    Console.WriteLine("  1. Happy");
                    Console.WriteLine("  2. Sad");
                    Console.WriteLine("  3. Tired");
                    Console.WriteLine("  4. Awake");
                    Console.WriteLine("  5. Stressed");
                    Console.WriteLine("  6. Calm");
                    Console.WriteLine("==================================");
                    Console.Write("Choose a mood (1-6): ");

                    string moodInput = Console.ReadLine() ?? "";

                    if (moodInput == "1") { mood = "Happy"; break; }
                    else if (moodInput == "2") { mood = "Sad"; break; }
                    else if (moodInput == "3") { mood = "Tired"; break; }
                    else if (moodInput == "4") { mood = "Awake"; break; }
                    else if (moodInput == "5") { mood = "Stressed"; break; }
                    else if (moodInput == "6") { mood = "Calm"; break; }
                    else {
                        Console.WriteLine();
                        Console.WriteLine("Invalid option. Please try again.");
                    }
                }          

                // Prompt for optional note
                Console.WriteLine();
                Console.Write("Add a note or press Enter to skip: ");
                string note = Console.ReadLine() ?? "";

                // Save input
                tracker.AddEntry(mood, note);
                Console.WriteLine();
                Console.WriteLine("Mood saved successfully.");
                
            } else if (command == "3") {
                Console.WriteLine();
                Console.WriteLine("===== Mood History =====");

                List<MoodEntry> entries = tracker.GetAllEntries();

                // Check if there are any entries
                if (entries.Count == 0)
                {
                    Console.WriteLine("No entries yet. Select option 1 to log daily mood.");
                }
                else
                {
                    // Display each entry with date, mood, and note
                    foreach (MoodEntry entry in entries)
                    {
                        Console.WriteLine("ID: " + entry.EntryId);
                        Console.WriteLine("Date: " + entry.Date.ToString("yyyyMMdd"));
                        Console.WriteLine("Mood: " + entry.Mood);
                        Console.WriteLine("Note: " + (entry.Note == "" ? "No note" : entry.Note));
                        Console.WriteLine("========================");
                    }
                }
            // Display message depending on input
            } else if (command == "2" || command == "4") {
                Console.WriteLine();
                Console.WriteLine("To be completed.");
            } else if (command == "5") {
                Console.WriteLine();
                Console.WriteLine("Goodbye!");
            } else {
                Console.WriteLine();
                Console.WriteLine("Invalid option. Please enter a number from 1 to 5.");
            }
        } while (command != "5");
    }
}