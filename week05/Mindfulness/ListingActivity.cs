class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(int count, List<string> prompts) :base("name", "description", 30)
    {
        _count = count;
        _prompts = prompts;
    }

    public void Run()
    {

    }

    public void GetRandomPrompt()
    {

    }

    public List<string> GetListFromUser()
    {
        return [];
    }
}