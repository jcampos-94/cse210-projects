using System.Text.RegularExpressions;
public class Words
{
    private Scripture myScripture = new Scripture();
    private Instructions inst = new Instructions();
    
    public void HideWords(string reference, string[] _scriptureTextArray)
        {
            Console.Clear();
            int attempts = 3;

            while (attempts > 0 && !myScripture.GetScripture(_scriptureTextArray).All(word => word.StartsWith("_")))
            {
                Random r = new Random();
                int rInt = r.Next(0, myScripture.GetScripture(_scriptureTextArray).Length);
                foreach (string word in myScripture.GetScripture(_scriptureTextArray))
                {
                    if ( word == myScripture.GetScripture(_scriptureTextArray)[rInt] && !myScripture.GetScripture(_scriptureTextArray)[rInt].StartsWith("_"))
                    {
                        myScripture.GetScripture(_scriptureTextArray)[rInt] = Regex.Replace(myScripture.GetScripture(_scriptureTextArray)[rInt], "[A-Za-z]", "_");
                        attempts -= 1;
                    }
                }
            }
            inst.GetInstructions();
            myScripture.GetVerse(reference, _scriptureTextArray);
            Console.WriteLine();

            string line = Console.ReadLine();
            
            if (line.ToLower().Trim() != "quit")
            {
                CheckWords(reference, myScripture.GetScripture(_scriptureTextArray));
            }
    }

    private void CheckWords(string reference, string[] scripture)
    {
        if (!scripture.All(word => word.StartsWith("_")))
        {
            HideWords(reference, scripture);
        }
    }
}