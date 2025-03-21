using System.Text;

class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        if (_isHidden == false)
        {
            StringBuilder newText = new StringBuilder();
            foreach(char letter in _text)
            {
                string l = letter.ToString();
                if (l != "," && l != ";" && l != ".")
                {
                    newText.Append("_");
                }
                else{
                    newText.Append(l);
                }
            }
            _text = newText.ToString();
        }
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden == true)
        {
            Hide();
        }
        else
        {
            Show();
        }
        return ($"{_text}");
    }
}