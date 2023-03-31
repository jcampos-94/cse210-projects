using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running(new DateTime(2023, 03, 28), 30, 10);
        activities.Add(running);

        Cycling cycling = new Cycling(new DateTime(2023, 03, 30), 50, 24);
        activities.Add(cycling);

        Swimming swimming = new Swimming(new DateTime(2023, 04, 01), 20, 200);
        activities.Add(swimming);
        
        Console.Clear();
        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}