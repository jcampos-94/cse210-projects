public class ListingActivity : Activity
{
    private string[] _promptList =
        {"Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"};
    public void DisplayListingPrompt()
    {
        Console.Clear();
        string prompt = GetPrompt(_promptList);

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {prompt} --- \n");

        Console.Write("You may begin in: " + "9");
        Countdown(9);
    }
    public void Write(int seconds)
    {
        Console.Clear();
        int count = 0;
        GetEndTime(seconds);

        while (DateTime.Now < _endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            
            count += 1;
        }

        Console.WriteLine($"\nYou listed {count} items!");
        DashAnimation(4);
    }
}