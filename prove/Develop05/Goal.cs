using System.IO;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected string _goalType;
    protected List<string> _goals = new List<string>();
    protected string _complete;
    protected int _maxInstances;
    protected int _currentInstances;
    protected int _bonus;
    private string _fileName;
    private int _score;
  
    public Goal (string name, string description, int points, string goalType, string complete)
    {
        _name = name;
        _description = description;
        _points = points;
        _goalType = goalType;
        _complete = complete;
    }

    public Goal (List<string> goals)
    {
        _goals = goals;
    }

    public Goal (List<string> goals, int score)
    {
        _goals = goals;
        _score = score;
    }

    public virtual string CreateNewGoal()
    {
        string newGoal = $"{_name},{_description},{_points},{_goalType},{_complete}";
        return newGoal;
    }

    public abstract int RecordEvent(int choice);
    
    public void DisplayQuestion1()
    {
        Console.WriteLine("What is the name of the goal? ");
        string name = Console.ReadLine();
        _name = name;
    }

    public void DisplayQuestion2()
    {
        Console.WriteLine("\nWhat is a short description of it? ");
        string description = Console.ReadLine();
        _description = description;
    }

    public void DisplayQuestion3()
    {
        Console.WriteLine("\nWhat is the amount of points associated with this goal? ");
        string points = Console.ReadLine();
        _points = int.Parse(points);
    }

    public virtual void DisplayQuestions()
    {
        Console.Clear();
        DisplayQuestion1();
        DisplayQuestion2();
        DisplayQuestion3();
    }

    public void EventSuccess()
    {
        Console.WriteLine("\nEvent created successfully.");
        Console.ReadKey();
    }
    
    public void Iterate(string goal)
    {
        string[] parts = goal.Split(",");
        _name = parts[0];
        _description = parts[1];
        _points = int.Parse(parts[2]);
        _goalType = parts[3];
        _complete = parts[4];
        if (parts.Count() == 8)
        {
            _maxInstances = int.Parse(parts[5]);
            _currentInstances = int.Parse(parts[6]);
            _bonus = int.Parse(parts[7]);
        }
    }
    
    public void DisplayGoals()
    {
        Console.Clear();
        int n = 1;
        foreach (string goal in _goals)
        {
            Iterate(goal);

            if (_complete == "False" && (_goalType == "1" || _goalType == "2"))
            {
                Console.WriteLine($"{n}. [ ] {_name} ({_description})");
            }
            else if (_complete == "True" && _goalType == "1")
            {
                Console.WriteLine($"{n}. [X] {_name} ({_description})");
            }
            else if (_complete == "False" && (_goalType == "3"))
            {
                Console.WriteLine($"{n}. [ ] {_name} ({_description}) -- Currently completed: {_currentInstances}/{_maxInstances}");
            }
            else if (_complete == "True" && (_goalType == "3"))
            {
                Console.WriteLine($"{n}. [X] {_name} ({_description}) -- Finished: {_currentInstances}/{_maxInstances}");
            }
            n += 1;
        }
        Console.ReadKey();
    }
    
    public string DisplayNames()
    {
        Console.Clear();
        int n = 1;
        foreach (string goal in _goals)
        {
            string[] parts = goal.Split(",");
            string name = parts[0];
            Console.WriteLine($"{n}. {name}");
            n += 1;
        }
                
        Console.Write("Which goal would you like to register? ");
        string choice = Console.ReadLine();
        return choice;
    }

    public string CheckGoalType(int choice)
    {
        foreach (string goal in _goals)
            {
                if (goal == _goals[choice - 1])
                {
                    string[] parts = goal.Split(",");
                    _goalType = parts[3];
                }
            }
        return _goalType;
    }
    
    public List<string> GetGoals()
    {
        return _goals;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public int GetScore()
    {
        return _score;
    }

    public void SetScore(string score)
    {
        _score = int.Parse(score);
    }

    public void Save(List<string> goals, int score)
    {
        Console.Clear();
        Console.Write("Write a name for your save file (without '.txt'): ");
        _fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter($"{_fileName}.txt"))
        {
            outputFile.WriteLine(score);

            foreach (string goal in goals)
            outputFile.WriteLine(goal);
        }

        Console.WriteLine($"\n'{_fileName}.txt' saved successfully.");
        Console.ReadKey();
    }

    public void Load()
    {
        Console.Clear();
        Console.Write("Write the name of your save file (without '.txt'): ");
        _fileName = Console.ReadLine();
        
        
        if (File.Exists($"{_fileName}.txt"))
        {
            _goals.Clear();
            string[] lines = System.IO.File.ReadAllLines($"{_fileName}.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");

                if (parts.Count() == 1)
                {
                    string score = parts[0];
                    SetScore(score);
                }
                else
                {
                    _name = parts[0];
                    _description = parts[1];
                    _points = int.Parse(parts[2]);
                    _goalType = parts[3];
                    _complete = parts[4];

                    string newGoal = $"{_name},{_description},{_points},{_goalType},{_complete}";

                    if (parts.Count() == 8)
                    {
                        _maxInstances = int.Parse(parts[5]);
                        _currentInstances = int.Parse(parts[6]);
                        _bonus = int.Parse(parts[7]);

                        newGoal = $"{_name},{_description},{_points},{_goalType},{_complete},{_maxInstances},{_currentInstances},{_bonus}";
                    }

                    _goals.Add(newGoal);
                }
            }
            Console.WriteLine("File loaded successfully.");
        }
        else
        {
            Console.WriteLine("File doesn't exist.");
        }
    }
}