using static System.Console;
using System.IO;

public class Entry
{
    private string _internalMemory = "internalmemory/MemoryFile.txt";
    private string _savedFiles = "savedfiles/";

    private string GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }
    
    //Displays all entries in the Journal:
    public void DisplayAllEntries()
    {
        Clear();
        string journalText = File.ReadAllText(_internalMemory);
        FontColor("DarkGreen");
        WriteLine("=== Journal Entries: ===");
        FontColor("DarkCyan");
        WriteLine(journalText);
        FontColor("DarkGreen");
        WriteLine("========================");
        PressAnyKey();
    }

    //Clears all Journal Contents:
    public void ClearAllEntries()
    {
        Clear();
        FontColor("White");
        File.WriteAllText(_internalMemory, "");
        WriteLine("All entries have been deleted.");
        PressAnyKey();
    }

    public void AddEntry()
    {
        Clear();
        FontColor("White");
        WriteLine("What do you want to add?");
        FontColor("DarkGray");
        WriteLine("Type EXIT to stop.\n");
        FontColor("DarkYellow");
        
        string newEntry = "";
        bool canContinue = true;
        while (canContinue)
        {
            string line = ReadLine();
            if (line.ToLower().Trim() == "exit")
            {
                canContinue = false;
            }
            else
            {
                newEntry += (line + "\n");
            }
        }
        
        File.AppendAllText(_internalMemory, $"\n{GetDate()} What did you do today?\n\n{newEntry}\n");
        FontColor("White");
        WriteLine("\nThe entry has been added successfully.");
        PressAnyKey();
    }

    //Saves a copy of the Journal:
    public void SaveJournal()
    {
        bool isChoiceValid = false;
        
        do
        {
            Clear();
            FontColor("White");
            WriteLine("This program saves all entries into its internal memory every time a new entry is added.");
            WriteLine("This option will copy the Journal contents into a different file.");
            WriteLine("Do you wish to continue?");
            WriteLine("1. Yes");
            WriteLine("2. No");

            FontColor("DarkYellow");
            string choice = ReadLine().Trim();

            if (choice == "1")
            {
                Clear();
                isChoiceValid = true;
                FontColor("White");
                WriteLine("What will be the name of the Journal?");
                FontColor("DarkYellow");
                string file = ReadLine().Trim();

                string journalText = File.ReadAllText(_internalMemory);

                File.WriteAllText(_savedFiles+file+".txt", journalText);
                Clear();
                FontColor("White");
                WriteLine($"The Journal has been saved as '{file}.txt'");
                PressAnyKey();
            }

            else if (choice == "2")
            {
                isChoiceValid = true;
            }

            else
            {
                NotAValidChoice(choice);
            }
        } while(!isChoiceValid);

    }

    //Replaces the contents MemoryFile.txt with the contects of a loaded Journal:
    public void LoadJournal()
    {
        bool isChoiceValid = false;
        
        do
        {
            Clear();
            FontColor("White");
            WriteLine("This option will take a previously saved journal");
            WriteLine("and use its contents to replace the internal memory.");
            WriteLine("Do you wish to continue?");
            WriteLine("1. Yes");
            WriteLine("2. No");

            FontColor("DarkYellow");
            string choice = ReadLine().Trim();

            if (choice == "1")
            {
                Clear();
                isChoiceValid = true;
                FontColor("White");
                WriteLine("Which Journal do you wish to load?");
                FontColor("DarkYellow");
                string file = ReadLine().Trim();

                string journalText = File.ReadAllText(_savedFiles+file+".txt");

                File.WriteAllText(_internalMemory, journalText);
                Clear();
                FontColor("White");
                WriteLine($"The Journal '{file}.txt' has been loaded.");
                PressAnyKey();
            }

            else if (choice == "2")
            {
                isChoiceValid = true;
            }

            else
            {
                NotAValidChoice(choice);
            }
        } while(!isChoiceValid);
    }
    
    //Waits for the user to press a key:
    public void PressAnyKey()
    {
        FontColor("DarkGray");
        Write("Press any key to continue...");
        ReadKey(true);
    }

    //Message when choosing an invalid choice:
    public void NotAValidChoice(string choice)
    {
        FontColor("DarkRed");
        WriteLine($"'{choice}' is not a valid choice. Please choose 1-6.");
        PressAnyKey();
    }

    //Allows easy access to the colors used in the Journal:
    public void FontColor(string color)
    {
        if (color == "White")
        {
        ForegroundColor = ConsoleColor.White;
        }

        else if (color == "DarkGray")
        {
            ForegroundColor = ConsoleColor.DarkGray;
        }

        else if (color == "DarkGreen")
        {
            ForegroundColor = ConsoleColor.DarkGreen;
        }

        else if (color == "DarkCyan")
        {
            ForegroundColor = ConsoleColor.DarkCyan;
        }
        
        else if (color == "DarkYellow")
        {
            ForegroundColor = ConsoleColor.DarkYellow;
        }

        else if (color == "DarkRed")
        {
            ForegroundColor = ConsoleColor.DarkRed;
        }
    }
};