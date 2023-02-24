public class ListingActivity : Activity
{
    private Animation animation = new Animation();
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
        animation.LongCountdown();
    }

    public void Write(int seconds)
    {
        Console.Clear();
        int count = 0;
        _startingTime = DateTime.Now;
        _endTime = _startingTime.AddSeconds(seconds);
        DateTime currentTime = DateTime.Now;

        while (currentTime < _endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            
            count += 1;
            currentTime = DateTime.Now;
        }

        Console.WriteLine($"\nYou listed {count} items!");
        animation.DashAnimation(4);
    }
}