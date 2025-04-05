class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    Random rnd = new Random();


    public ReflectingActivity(List<string> prompts, List<string> questions) :base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 30)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {

        DisplayStartingMessage();
        Console.Clear();

        string r_prompt = GetRandomPrompt();
        Console.WriteLine(r_prompt);
        Console.WriteLine();
        Thread.Sleep(3000);
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(base.GetDuration());

        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            DisplayRandomQuestions();
            ShowSpinner(15);
            Console.Clear();

            Console.WriteLine(r_prompt);
            Console.WriteLine();

            currentTime = DateTime.Now;

        }
        
        Console.Clear();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int r_prompt = rnd.Next(_prompts.Count);
        return _prompts[r_prompt];
    }
    
    public string GetRandomQuestion()
    {
        int r_question = rnd.Next(_questions.Count);
        return _questions[r_question];
    }

    public void DisplayRandomQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }
    
}