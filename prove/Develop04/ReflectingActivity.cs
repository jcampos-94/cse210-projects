using System;
using System.Runtime;

public class ReflectingActivity : Activity
{
    private Animation animation = new Animation();
    private string[] _promptList =
        {"Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."};

    private string[] _questionList =
        {"Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"};
    public void DisplayReflectingPrompt()
    {
        Console.Clear();
        string prompt = GetPrompt(_promptList);

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($" --- {prompt} --- \n");
        Console.WriteLine("When you have something in mind, press 'Enter' to continue.");
        Console.ReadKey();

        Console.WriteLine("\nNow ponder each of the following questions in relation to this experience.");
        Console.Write("You may begin in: " + "3");
        animation.Countdown(3);
    }
    public void DisplayQuestions(int seconds)
    {
        Console.Clear();
        _startingTime = DateTime.Now;
        _endTime = _startingTime.AddSeconds(seconds);
        DateTime currentTime = DateTime.Now;

        while (currentTime < _endTime)
        {
            string question = GetPrompt(_questionList);

            Console.WriteLine($"> {question}");
            animation.DashAnimation(10);
            Console.Write("\b \b");
            currentTime = DateTime.Now;
        }
    }
}