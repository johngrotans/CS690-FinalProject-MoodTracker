namespace MoodTracker;

public class ConsoleUI
{
    public void Show()
    {
        string command;
        do {
            // Print the main menu options
            Console.WriteLine();
            Console.WriteLine("=== Mood Tracker ===");
            Console.WriteLine("1. Log Daily Mood");
            Console.WriteLine("2. View Mood Statistics");
            Console.WriteLine("3. View Mood History");
            Console.WriteLine("4. Manage Mood Entries");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option (1-5): ");

            // Read the input
            command = Console.ReadLine() ?? "";

            // Display message depending on input
            if (command == "1" || command == "2" || command == "3" || command == "4") {
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