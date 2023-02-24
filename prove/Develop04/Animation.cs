public class Animation
{
    public void GetReady()
    {
        Console.Clear();

        Console.WriteLine("Get Ready...");
        DashAnimation(3);
        
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