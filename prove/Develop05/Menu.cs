public class Menu
{
    string _level;
    
    public void GetLevel(int score)
    {
        if (score < 100)
        {
          _level = "Initiate";
        }
        else if (score < 200)
        {
            _level = "Apprentice";
        }
        else if (score < 400)
        {
            _level = "Disciple";
        }
        else if (score < 700)
        {
            _level = "Veteran";
        }
        else if (score >= 700)
        {
            _level = "Master";
        }
    }

    public string DisplayMenu(int score)
    {
        Console.Clear();
        GetLevel(score);

        Console.WriteLine($"Level: {_level}");
        Console.WriteLine($"You have {score} points.\n");

        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create new goal");
        Console.WriteLine("  2. Display goals");
        Console.WriteLine("  3. Save goals");
        Console.WriteLine("  4. Load goals");
        Console.WriteLine("  5. Record event");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();
        return choice;
    }

    public string DisplayMenu1()
    {
        Console.Clear();
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple goal");
        Console.WriteLine("  2. Eternal goal");
        Console.WriteLine("  3. Checklist goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();
        return choice;
    }

    public string Displayquestion1()
    {
        Console.WriteLine("What is the name of the goal? ");
        string name = Console.ReadLine();
        return name;
    }

    public string Displayquestion2()
    {
        Console.WriteLine("\nWhat is a short description of it? ");
        string description = Console.ReadLine();
        return description;
    }

    public string Displayquestion3()
    {
        Console.WriteLine("\nWhat is the amount of points associated with this goal? ");
        string points = Console.ReadLine();
        return points;
    }
}