public class Activity
{
    //private Menu _menu = new Menu();
    protected string[] _activityName = {"Breathing Activity", "Reflecting Activity", "Listing Activity"};
    protected string[] _description = {"This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.", "", ""};
    private string _timePrompt = "How long, in seconds would you like for your session? ";
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
        Console.ReadKey();
    }
}