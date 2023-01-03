using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string valueInText = Console.ReadLine();
        int grade = int.Parse(valueInText);
        string letter = "";

        int remainder = grade % 10;
        string sign = "";

        if (grade < 94 && grade > 59)
        {
            if (remainder >= 7)
            {
                sign = "+";
            }

            else if (remainder < 3)
            {
                sign = "-";
            }
        }

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else if (grade < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}{sign}");
        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Good luck next time!");
        }

    }
}