using System;
using System.Text.RegularExpressions;
public class Scripture
{
    private List<string> wordList = new List<string>();
    private string[] _scriptureTextArray;
    private string _reference;

    public void GenerateScripture(string reference, string text)
    {
        _reference = reference;
        string[] splitText = text.Split(" ");
        foreach (string word in splitText)
        {
            wordList.Add(word);
        }
        _scriptureTextArray = wordList.ToArray();
    }

    public void GetVerse(string reference, string[] _scriptureTextArray)
    {
        Console.WriteLine($"\n{reference}");
        foreach (string word in _scriptureTextArray)
        {
            Console.Write($"{word} ");
        }
    }

    public void GetVerse2()
    {
        Console.WriteLine($"\n{_reference}");
        foreach (string word in _scriptureTextArray)
        {
            Console.Write($"{word} ");
        }
    }

    public string[] GetScripture(string [] _scriptureTextArray)
    {
        return _scriptureTextArray;
    }

    public string[] GetScripture2()
    {
        return _scriptureTextArray;
    }
}