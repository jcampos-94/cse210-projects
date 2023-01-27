using static System.Console;
using System.IO;

public class Journal
{
    Entry accessEntry = new Entry();
    
    private string _internalMemory = "internalmemory/MemoryFile.txt";
    
    //Starts the Journal:
    public void Start()
    {
        DisplayIntro();
        CreateMemoryFile();
        RunProgram();
        DisplayOutro();
    }

    //Check if file exists, if not, creates one:
    private void CreateMemoryFile()
    {
        if (!File.Exists(_internalMemory))
        {
            File.CreateText(_internalMemory);
        }
    }

    //Displays the Intro:
    private void DisplayIntro()
    {
        Clear();
        accessEntry.FontColor("Reset");
        WriteLine("Welcome to JournalApp.");
        accessEntry.PressAnyKey();
    }

    //Displays the Outro:
    private void DisplayOutro()
    {
        Clear();
        accessEntry.FontColor("Reset");
        WriteLine("Thanks for using JournalApp.");
        WriteLine("Goodbye.");
        accessEntry.PressAnyKey();
    }

    private void RunProgram()
    {
        string choice;

        do
        {
            choice = DisplayMenu();
            switch (choice)
            {
                case "1":
                    accessEntry.AddEntry();
                    break;
                
                case "2":
                    accessEntry.DisplayAllEntries();
                    break;

                case "3":
                    accessEntry.SaveJournal();
                    break;

                case "4":
                    accessEntry.LoadJournal();
                    break;

                case "5":
                    accessEntry.ClearAllEntries();
                    break;
                
                case "6":
                    accessEntry.DeleteJournal();
                    break;
                
                default:
                    break;
            }
        } while (choice != "7");
        
    }
    
    //Gets the user input for the Main Menu:
    private string DisplayMenu()
    {
        bool isChoiceValid = false;
        string choice = "";
        
        do
        {
            Clear();
            accessEntry.FontColor("Reset");
            WriteLine("What would you like to do?\n");
            WriteLine("1. Write a new Entry");
            WriteLine("2. Display Journal contents");
            WriteLine("3. Save Journal");
            WriteLine("4. Load Journal");
            WriteLine("5. Delete all local entries");
            WriteLine("6. Delete a saved Journal");
            WriteLine("7. Quit");

            accessEntry.FontColor("DarkYellow");
            choice = ReadLine().Trim();
            accessEntry.FontColor("Reset");

            if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5" || choice == "6" || choice == "7")
            {
                isChoiceValid = true;
            }
            else
            {
                accessEntry.NotAValidChoice(choice);
            }
        } while (!isChoiceValid);

        return choice;
    }
}