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
    public void Countdown()
    {
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");

        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("");

        Console.WriteLine();
    }
    public void LongCountdown()
    {
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("8");

        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("7");

        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("6");

        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("5");

        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("4");

        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("3");

        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");

        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("");

        Console.WriteLine();
    }
}