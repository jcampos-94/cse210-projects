public class Reference
{
    private string _book;
    private string _chapter;
    private string _beginVerse;
    private string _endVerse;
    private string _text;
    private string _reference;

    public Reference(string book, string chapter, string verse, string text)
    {
        _book = book;
        _chapter = chapter;
        _beginVerse = verse;
        _reference = $"{book} {chapter}:{verse}";
        _text = text;
    }

    public Reference(string book, string chapter, string verse1, string verse2, string text)
    {
        _book = book;
        _chapter = chapter;
        _beginVerse = verse1;
        _endVerse = verse2;
        _reference = $"{book} {chapter}:{verse1}-{verse2}";
        _text = text;
    }
    
    public string GetReference()
    {
        return _reference;
    }

    public string GetText()
    {
        return _text;
    }
}