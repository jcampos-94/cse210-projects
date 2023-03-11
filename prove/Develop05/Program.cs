using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal sg = new SimpleGoal("", "", 0, "", "");
        EternalGoal eg = new EternalGoal("", "", 0, "", "");
        ChecklistGoal cg = new ChecklistGoal("", "", 0, "", "", 0, 0, 0);
        
        Menu menu = new Menu();
        int score = 0;

        int choice;
        int choice1;
        int choice5;
        
        List<string> goals = new List<string>();
        string newGoal;

        do
        {
            string input = menu.DisplayMenu(score);
            choice = int.Parse(input);
            switch (choice)
            {
                case 1:
                    do
                    {
                        string input1 = menu.DisplayMenu1();
                        choice1 = int.Parse(input1);
                        switch (choice1)
                        {
                            case 1:
                                sg.DisplayQuestions();

                                sg = new SimpleGoal(sg.GetName(), sg.GetDescription(), sg.GetPoints(), "1", "False");
                                newGoal = sg.CreateNewGoal();
                                goals.Add(newGoal);

                                sg.EventSuccess();
                                break;
                            
                            case 2:
                                eg.DisplayQuestions();

                                eg = new EternalGoal(eg.GetName(), eg.GetDescription(), eg.GetPoints(), "2", "False");
                                newGoal = eg.CreateNewGoal();
                                goals.Add(newGoal);

                                eg.EventSuccess();
                                break;
                            
                            case 3:
                                cg.DisplayQuestions();

                                cg = new ChecklistGoal(cg.GetName(), cg.GetDescription(), cg.GetPoints(), "3", "False", cg.GetMaxInstances(), 0, cg.GetBonus());
                                newGoal = cg.CreateNewGoal();
                                goals.Add(newGoal);

                                cg.EventSuccess();
                                break;
                            
                            default:
                                break;
                        }
                    } while (choice1 != 1 && choice1 != 2 && choice1 != 3);
                    break;
                
                case 2:
                    sg = new SimpleGoal(goals);
                    sg.DisplayGoals();
                    break;

                case 3:
                    sg = new SimpleGoal(goals, score);
                    sg.Save(goals, score);
                    break;

                case 4:
                    sg = new SimpleGoal(goals, score);
                    sg.Load();
                    score = sg.GetScore();
                    sg.GetGoals();
                    Console.ReadKey();
                    break;
                
                case 5:
                    sg = new SimpleGoal(goals);
                    string input5 = sg.DisplayNames();
                    choice5 = int.Parse(input5);
                    string goalType = sg.CheckGoalType(choice5);
                    if (goalType == "1") //SimpleGoals
                    {
                        score += sg.RecordEvent(choice5);
                        goals = sg.GetGoals();
                    }
                    
                    else if (goalType == "2") //EternalGoals
                    {
                        eg = new EternalGoal(goals);
                        score += eg.RecordEvent(choice5);
                        goals = eg.GetGoals();
                    }

                    else if (goalType == "3") //ChecklistGoals
                    {
                        cg = new ChecklistGoal(goals);
                        score += cg.RecordEvent(choice5);
                        goals = cg.GetGoals();
                    }
                    break;
                
                default:
                    break;
            }
        } while (choice != 6);
    }
}