using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity activity0 = new BreathingActivity();
        Menu menu = new Menu();
        int choice;
        do
        {
            string input = menu.DisplayMenu();
            choice = int.Parse(input);
            switch (choice)
            {
                case 1:
                    int seconds = activity0.DisplayStartingMessage(0);
                    menu.GetReady();
                    activity0.DisplayBreathing(seconds);
                    activity0.DisplayEndMessage(seconds, 0);
                    break;
                
                case 2:
                    
                    break;

                case 3:
                    
                    break;
                
                default:
                    break;
            }
        } while (choice != 4);
    }
}