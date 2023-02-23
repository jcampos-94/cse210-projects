public class BreathingActivity : Activity
{
    //private Menu _menu = new Menu();
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
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("2");

            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("1");
            
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("");

            Console.WriteLine();

            Console.Write(_breathOut + "2");
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("1");

            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("\n");

            Console.WriteLine();

            currentTime = DateTime.Now;
        }
    }
}