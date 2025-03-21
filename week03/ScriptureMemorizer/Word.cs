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
        _isHidden = true;
        if (_isHidden)
        {
            StringBuilder newText = new StringBuilder();
            foreach(char letter in _text)
            {
                newText.Append("_");
            }
            _text = newText.ToString();
        }
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