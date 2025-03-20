class Scripture
{
    Reference _reference = new Reference();
    List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            Word _word = new Word(word);
            _words.Add(_word);
        }
    }

    public void HideRandomWords(int numToHide)
    {
        
    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}