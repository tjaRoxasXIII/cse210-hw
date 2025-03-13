public class Entry
{
    // Create entry with response, prompt and date
    
    public string _entryPrompt;
    public string _date;
    public string _userResponse;

    public Entry(string prompt, string userResponse)
    {
        _date = DateTime.Now.ToString();
        _entryPrompt = prompt;
        _userResponse = userResponse;
    }

    public void Display()
    {
        Console.WriteLine(_date);
        Console.WriteLine(_entryPrompt);
        Console.WriteLine($"{_userResponse}\n");
    }

}