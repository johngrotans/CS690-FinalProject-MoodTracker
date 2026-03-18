namespace MoodTracker;
using System.Diagnostics.CodeAnalysis; // To use ExcludeFromCodeCoverage

[ExcludeFromCodeCoverage] // Excluding Program.cs from test coverage
class Program
{
    static void Main(string[] args)
    {
        ConsoleUI theUI = new ConsoleUI();
        theUI.Show();
    }
}
