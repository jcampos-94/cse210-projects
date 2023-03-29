using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("28 Mar 2023", 30, 10);
        activities.Add(running);

        Cycling cycling = new Cycling("28 Mar 2023", 50, 24);
        activities.Add(cycling);

        Swimming swimming = new Swimming("28 Mar 2023", 20, 200);
        activities.Add(swimming);
        
        Console.Clear();
        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}