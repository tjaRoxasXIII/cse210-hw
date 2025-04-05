class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity(List<string> prompts) :base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 30)
    {
        _prompts = prompts;
    }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        Console.WriteLine("Please list as many items as you can think of: ");
        List<string> responseList = GetListFromUser();
        Console.WriteLine($"You listed {DisplayCount(responseList)} item(s).");

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random rnd = new Random();
        int r_prompt = rnd.Next(_prompts.Count);
        Console.WriteLine(_prompts[r_prompt]);
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = [];
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(base.GetDuration());

        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            Console.Write("- ");
            string response = Console.ReadLine();

            userList.Add(response);

            currentTime = DateTime.Now;

        }

        return userList;
    }

    public int DisplayCount(List<string> responses)
    {
        return responses.Count();
    }
}