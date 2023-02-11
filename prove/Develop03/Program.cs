using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Instructions inst = new Instructions();
        Scripture verse = new Scripture();
        Words accessWords = new Words();

        Reference rInput = new Reference("", "", "", "");
        Reference r1 = new Reference("Moses", "1", "39", "For behold, this is my work and my glory— to bring to pass the immortality and eternal life of man.");
        Reference r2 = new Reference("Matthew", "5", "14", "16", "Ye are the light of the world. A city that is set on an hill cannot be hid. Neither do men light a candle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house. Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven.");
        Reference r3 = new Reference("1 Nephi", "3", "7", "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        Reference r4 = new Reference("D&C", "1", "37", "38", "Search these commandments, for they are true and faithful, and the prophecies and promises which are in them shall all be fulfilled. What I the Lord have spoken, I have spoken, and I excuse not myself; and though the heavens and the earth pass away, my word shall not pass away, but shall all be fulfilled, whether by mine own voice or by the voice of my servants, it is the same.");

        bool isChoiceValid = false;
        string choice = "";
        
        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to Scripture Memorizer. ");
            Console.WriteLine("Please select the scripture you want to memorize:");
            Console.WriteLine("1. Moses 1:39");
            Console.WriteLine("2. Matthew 5:14-16");
            Console.WriteLine("3. 1 Nephi 3:7");
            Console.WriteLine("4. D&C 1:37-38");
            choice = Console.ReadLine();

            if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
            {
                isChoiceValid = true;
            }
            else
            {
                Console.WriteLine("Not a valid choice.");
                Console.ReadKey();
            }
        } while (!isChoiceValid);

        switch (choice)
        {
            case "1":
                rInput = r1;
                break;
            case "2":
                rInput = r2;
                break;
            case "3":
                rInput = r3;
                break;
            case "4":
                rInput = r4;
                break;
        }
        
        verse.GenerateScripture(rInput.GetReference(), rInput.GetText());
        string[] scriptureTextArray = verse.GetScripture2();
        string referenceText = rInput.GetReference();

        void Continue()
        {
            string line = Console.ReadLine();
            if (line.ToLower().Trim() != "quit")
            {
                accessWords.HideWords(referenceText, scriptureTextArray);
            }
        }

        Console.Clear();
        inst.GetInstructions();
        verse.GetVerse2();
        Console.WriteLine();
        Continue();

        Console.Clear();
        Console.WriteLine("Thank you for using the program Scripture Memorizer.");
        Console.WriteLine("Have a nice day.");
    }
}
