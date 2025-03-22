class Scripture
{
    Reference _reference = new Reference("", 1, 1, 1);
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
        int i = 0;
        bool stopHiding = IsCompletelyHidden();
        
        if (numToHide > UnhiddenWordsRemaining())
        {
            numToHide = UnhiddenWordsRemaining();
        }

        while (i != numToHide)
        {
            Random rnd = new Random();
            int index = rnd.Next(_words.Count);
            if (!_words[index].IsHidden() && stopHiding == false)
            {
                _words[index].Hide();
                i++;

            }
            
        }
    }

    public string GetDisplayText()
    {
        string newText = "";
        foreach (Word word in _words)
        {
            
            newText += word.GetDisplayText() + " ";
        }
        return ($"{_reference.GetDisplayText()}\n {newText}");
    }

    public bool IsCompletelyHidden()
    {
        bool fullyHidden = true;
        foreach(Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                fullyHidden = false;
                break;
            }
        }
        return fullyHidden;
    }

    public int UnhiddenWordsRemaining()
    {
        int remainingWords = 0;
        foreach(Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                remainingWords++;
            }
        }

        return remainingWords;

    }
}