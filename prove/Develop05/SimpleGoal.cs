public class SimpleGoal : Goal
{
    public SimpleGoal (string name, string description, int points, string goalType, string complete)
        : base (name, description, points, goalType, complete)
    {
    }

    public SimpleGoal (List<string> goals) : base (goals)
    {
    }

    public SimpleGoal (List<string> goals, int score) : base (goals, score)
    {
    }

    public override int RecordEvent(int choice)
    {
        if (choice > 0 && choice <= _goals.Count())
        {
            foreach (string goal in _goals)
            {
                if (goal == _goals[choice - 1])
                {
                    string[] parts = goal.Split(",");
                    _name = parts[0];
                    _description = parts[1];
                    _points = int.Parse(parts[2]);
                    _goalType = parts[3];
                    _complete = parts[4];
                    
                    if (_complete == "False")
                    {
                        _goals[choice - 1] = $"{_name},{_description},{_points},{_goalType},True";
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
}