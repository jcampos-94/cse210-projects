using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int choice;
        int seconds;
        
        do
        {
            string input = menu.DisplayMenu();
            choice = int.Parse(input);
            switch (choice)
            {
                case 1:
                    BreathingActivity activity0 = new BreathingActivity();
                    seconds = activity0.DisplayStartingMessage(0);
                    activity0.GetReady();
                    activity0.DisplayBreathing(seconds);
                    activity0.DisplayEndMessage(seconds, 0);
                    break;
                
                case 2:
                    ReflectingActivity activity1 = new ReflectingActivity();
                    seconds = activity1.DisplayStartingMessage(1);
                    activity1.GetReady();
                    activity1.DisplayReflectingPrompt();
                    activity1.DisplayQuestions(seconds);
                    activity1.DisplayEndMessage(seconds, 1);
                    break;

                case 3:
                    ListingActivity activity2 = new ListingActivity();
                    seconds = activity2.DisplayStartingMessage(2);
                    activity2.GetReady();
                    activity2.DisplayListingPrompt();
                    activity2.Write(seconds);
                    activity2.DisplayEndMessage(seconds, 2);
                    break;

                case 4:
                    JokeActivity activity3 = new JokeActivity();
                    seconds = activity3.DisplayStartingMessage(3);
                    activity3.GetReady();
                    activity3.DisplayJokes(seconds);
                    activity3.DisplayEndMessage(seconds, 3);
                    break;
                
                default:
                    break;
            }
        } while (choice != 5);
        Console.Clear();
        Console.Write("Goodbye.");
    }
}