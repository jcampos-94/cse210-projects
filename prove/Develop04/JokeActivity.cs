public class JokeActivity : Activity
{
    private string[] _jokesList =
        {"It doesn't matter how much you push the envelope. It'll still be stationary.",
        "A book just fell on my head, I only have my shelf to blame.",
        "Bakers trade bread recipes on a knead-to-know basis.",
        "A backwards poet writes inverse.",
        "I used to be addicted to soap. But I'm clean now.",
        "3.14% of sailors are Pi Rates.",
        "I stayed up all night wondering where the sun went. Then it dawned on me.",
        "Why did the scarecrow get a promotion? He was outstanding in his field.",
        "I tried to catch some fog earlier. I mist.",
        "You wanna hear a joke about pizza? Never mind, it was too cheesy.",
        "I'm reading a book about anti-gravity. It's impossible to put down.",
        "I'm glad I know sign language. It's become quite handy.",
        "I forgot how to throw a boomerang. But it came back to me.",
        "When a clock is hungry... It goes back four seconds.",
        "I once heard a joke about amnesia... But I forgot how it goes.",
        "When the power went out at the school... The children... were de-lighted.",
        "I didn't have the faintest idea... as to why I passed out.",
        "There was once a crossed-eyed teacher... who had issues controlling his pupils.",
        "Those two men drinking battery acid will soon be charged.",
        "The midget psychic escaped prison. He was a small medium at large.",
        "A criminal`s best asset... is his lie-ability."
        };
    
    public void DisplayJokes(int seconds)
    {
        Console.Clear();
        GetEndTime(seconds);

        while (DateTime.Now < _endTime)
        {
            string prompt = GetPrompt(_jokesList);
            Console.WriteLine($"> {prompt}");
            DashAnimation(4);
            Console.Write("\b \b");
        }
    }
}