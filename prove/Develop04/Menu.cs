public class Menu
{
    public string DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Breathing Activity");
        Console.WriteLine("  2. Reflecting Activity");
        Console.WriteLine("  3. Listing Activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();
        return choice;
    }

    public void GetReady()
    {
        Console.Clear();
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(3);
        while (start < end)
        {
            Console.WriteLine("Get Ready...");
            Console.Write("/");

            Thread.Sleep(500);

            Console.Write("\b \b"); // Erase the + character
            Console.Write(@"\");

            Thread.Sleep(500);
            Console.Clear();

            start = DateTime.Now;
        }
    }
}