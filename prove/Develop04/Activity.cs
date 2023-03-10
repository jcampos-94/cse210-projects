public class Activity
{
    protected string[] _activityName = {"Breathing Activity", "Reflecting Activity", "Listing Activity", "No Pun Intended Activity"};
    protected string[] _description = {"This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.",
        "This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
        "This activity will help you relax by telling you small, innocent jokes."};
    private string _timePrompt = "How long, in seconds, would you like for your session? ";
    protected DateTime _startingTime;
    protected DateTime _endTime;
    public int DisplayStartingMessage(int index)
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName[index]}\n");
        Console.WriteLine($"{_description[index]}");
        Console.Write($"\n{_timePrompt}");
        string input = Console.ReadLine();
        int seconds = int.Parse(input);
        return seconds;
    }
    public void DisplayEndMessage(int seconds, int index)
    {
        Console.Clear();
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed another {seconds} seconds of the {_activityName[index]}.");
        Console.WriteLine("Press 'Enter' to continue.");
        Console.ReadKey();
    }
    public string GetPrompt(string[] list)
    {
        Random rnd = new Random();
        int value = rnd.Next(0, list.Length);
        return list[value];
    }
    public DateTime GetEndTime(int seconds)
    {
        _startingTime = DateTime.Now;
        _endTime = _startingTime.AddSeconds(seconds);
        return _endTime;
    }
    public void DashAnimation( int time)
    {
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(time);
        while (start < end)
        {
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write(@"\");
            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);

            start = DateTime.Now;
        }
    }
    public void GetReady()
    {
        Console.Clear();

        Console.WriteLine("Get Ready...");
        DashAnimation(3);
        
    }
    public void Countdown(int number)
    {
        int value = number;

        while (value > 0)
        {
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write($"{value - 1}");
        value -= 1;
        }
        Console.Write("\b \b");

        Console.WriteLine();
    }
}