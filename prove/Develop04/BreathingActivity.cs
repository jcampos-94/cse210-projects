public class BreathingActivity : Activity
{
    private string _breathIn = "Breath in...";
    private string _breathOut = "Breath out...";
    public void DisplayBreathing(int seconds)
    {
        Console.Clear();
        GetEndTime(seconds);

        while (DateTime.Now < _endTime)
        {
            Console.Write(_breathIn + "3");
            Countdown(3);

            Console.Write(_breathOut + "3");
            Countdown(3);

            Console.WriteLine();
        }
    }
}