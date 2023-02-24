public class Menu
{
    public string DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Breathing Activity");
        Console.WriteLine("  2. Reflecting Activity");
        Console.WriteLine("  3. Listing Activity");
        Console.WriteLine("  4. No Pun Intended");
        Console.WriteLine("  5. Quit");
        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();
        return choice;
    }
}