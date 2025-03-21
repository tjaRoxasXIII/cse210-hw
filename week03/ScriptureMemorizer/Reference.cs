class Reference
{
    string _book;
    int _chapter;
    int _verse;
    int _endVerse = 0;

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public string GetDisplayText()
    {
        string fullReference;
        if (_endVerse != 0)
        {
            fullReference = ($"{_book} {_chapter}:{_verse}-{_endVerse}");
        }
        else
        {
            fullReference = ($"{_book} {_chapter}:{_verse}");
        }
        return fullReference;
    }

}