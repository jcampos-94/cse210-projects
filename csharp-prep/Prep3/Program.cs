using System;

class Program
{
    static void Main(string[] args)
    {
        string keepPlaying = "yes";

        while (keepPlaying == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);

            int guess = -1;

            int attempts = 0;

            while (number != guess)
            {
                Console.Write("What is your guess? ");
                string valueInText = Console.ReadLine();
                guess = int.Parse(valueInText);

                if (number < guess)
                {
                    Console.WriteLine("Lower");
                }

                else if (number > guess)
                {
                    Console.WriteLine("Higher");
                }

                attempts += 1;
            }

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {attempts} attempts!");
                        
            Console.Write("Do you want to keep playing? (yes/no) ");
            keepPlaying = Console.ReadLine();
        }
    }
}