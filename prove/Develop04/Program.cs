using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity activity0 = new BreathingActivity();
        ReflectingActivity activity1 = new ReflectingActivity();
        ListingActivity activity2 = new ListingActivity();
        Menu menu = new Menu();
        Animation animation = new Animation();
        int choice;
        int seconds;
        do
        {
            string input = menu.DisplayMenu();
            choice = int.Parse(input);
            switch (choice)
            {
                case 1:
                    seconds = activity0.DisplayStartingMessage(0);
                    animation.GetReady();
                    activity0.DisplayBreathing(seconds);
                    activity0.DisplayEndMessage(seconds, 0);
                    break;
                
                case 2:
                    seconds = activity1.DisplayStartingMessage(1);
                    animation.GetReady();
                    activity1.DisplayReflectingPrompt();
                    activity1.DisplayQuestions(seconds);
                    activity1.DisplayEndMessage(seconds, 1);
                    break;

                case 3:
                    seconds = activity2.DisplayStartingMessage(2);
                    animation.GetReady();
                    activity2.DisplayListingPrompt();
                    activity2.Write(seconds);
                    activity2.DisplayEndMessage(seconds, 2);
                    break;
                
                default:
                    break;
            }
        } while (choice != 4);
    }
}