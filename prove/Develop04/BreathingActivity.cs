public class BreathingActivity : Activity
{
    private Animation animation = new Animation();
    private string _breathIn = "Breath in...";
    private string _breathOut = "Breath out...";
    public void DisplayBreathing(int seconds)
    {
        Console.Clear();
        GetEndTime(seconds);

        while (DateTime.Now < _endTime)
        {
            Console.Write(_breathIn + "3");
            animation.Countdown(3);

            Console.Write(_breathOut + "3");
            animation.Countdown(3);

            Console.WriteLine();
        }
    }
}