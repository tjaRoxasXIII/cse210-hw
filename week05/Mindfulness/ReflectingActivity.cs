class ReflectingActivity : Activity
{
    List<string> _prompts;
    List<string> _questions;

    public ReflectingActivity(List<string> prompts, List<string> questions) :base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 30)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random rnd = new Random();
        int r_prompt = rnd.Next(_prompts.Count);
        Console.WriteLine(_prompts[r_prompt]);
        Console.WriteLine();
        Thread.Sleep(3000);
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(base.GetDuration());

        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            int r_question = rnd.Next(_questions.Count);
            Console.WriteLine(_questions[r_question]);
            ShowSpinner(15);
            Console.Clear();

            Console.WriteLine(_prompts[r_prompt]);
            Console.WriteLine();

            currentTime = DateTime.Now;

        }
        
        Console.Clear();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        return "";
    }
    
    public string GetRandomQuestion()
    {
        return "";
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayRandomQuestions()
    {
        
    }
    
}