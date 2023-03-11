public class ChecklistGoal : Goal
{
    public ChecklistGoal (string name, string description, int points, string goalType, string complete, int maxInstances, int currentInstances, int bonus)
        : base (name, description, points, goalType, complete)
    {
        _maxInstances = maxInstances;
        _currentInstances = currentInstances;
        _bonus = bonus;
    }

    public ChecklistGoal (List<string> goals) : base (goals)
    {
    }

    public override string CreateNewGoal()
    {
        string newGoal = $"{_name},{_description},{_points},{_goalType},{_complete},{_maxInstances},{_currentInstances},{_bonus}";
        return newGoal;
    }
    
    public void DisplayQuestion4()
    {
        Console.WriteLine("\nHow many times does this goal need to be accomplished for a bonus? ");
        string maxInstances = Console.ReadLine();
        _maxInstances = int.Parse(maxInstances);
    }

    public void DisplayQuestion5()
    {
        Console.WriteLine("\nWhat is the bonus for accomplishing it that many times? ");
        string bonus = Console.ReadLine();
        _bonus = int.Parse(bonus);
    }
    
    public override void DisplayQuestions()
    {
        Console.Clear();
        DisplayQuestion1();
        DisplayQuestion2();
        DisplayQuestion3();
        DisplayQuestion4();
        DisplayQuestion5();
    }
    
    public override int RecordEvent(int choice)
    {
        if (choice > 0 && choice <= _goals.Count())
        {
            foreach (string goal in _goals)
            {
                if (goal == _goals[choice - 1])
                {
                    Iterate(goal);

                    if (_complete == "False")
                    {
                        if ((_currentInstances + 1) < _maxInstances )
                        {
                            _goals[choice - 1] = $"{_name},{_description},{_points},{_goalType},False,{_maxInstances},{_currentInstances + 1},{_bonus}";
                        }
                        else
                        {
                            _goals[choice - 1] = $"{_name},{_description},{_points},{_goalType},True,{_maxInstances},{_currentInstances + 1},{_bonus}";
                            _points += _bonus;
                        }
                        Console.WriteLine("\nEvent recorded successfully.");
                        Console.WriteLine($"You have earned {_points} points!");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nThat event has already been completed.");
                        Console.ReadKey();
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("\nError: invalid choice.");
            Console.ReadKey();
        }
        return _points;
    }

    public int GetMaxInstances()
    {
        return _maxInstances;
    }

    public int GetBonus()
    {
        return _bonus;
    }
}