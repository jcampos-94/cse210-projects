public class BreathingActivity : Activity
{
    private Animation animation = new Animation();
    private string _breathIn = "Breath in...";
    private string _breathOut = "Breath out...";
    public void DisplayBreathing(int seconds)
    {
        Console.Clear();
        _startingTime = DateTime.Now;
        _endTime = _startingTime.AddSeconds(seconds);
        DateTime currentTime = DateTime.Now;

        while (currentTime < _endTime)
        {
            Console.Write(_breathIn + "3");
            animation.Countdown();

            Console.Write(_breathOut + "3");
            animation.Countdown();

            Console.WriteLine();
            currentTime = DateTime.Now;
        }
    }
}