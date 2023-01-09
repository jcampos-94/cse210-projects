using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int input = -1;
        int totalSum = 0;

        while (input != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string valueInText = Console.ReadLine();
            input = int.Parse(valueInText);

            if (input != 0)
            {
                numbers.Add(input);
            }
        }

        int largestNumber = numbers[0];
        double smallestPositive = double.PositiveInfinity;

        foreach (int number in numbers)
        {
            totalSum += number;

            if (number > largestNumber)
            {
                largestNumber = number;
            }

            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        Console.WriteLine($"The sum is: {totalSum}");

        float average = (float)totalSum / (numbers.Count);
        Console.WriteLine($"The average is: {average}");
        
        Console.WriteLine($"The largest number is: {largestNumber}");

        Console.WriteLine($"The smallest positive is: {smallestPositive}");

        numbers.Sort();
        Console.WriteLine($"The sorted list is:");
        
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}