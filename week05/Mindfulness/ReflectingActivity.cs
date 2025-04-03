class ReflectingActivity : Activity
{
    List<string> _prompts;
    List<string> _questions;

    public ReflectingActivity(List<string> prompts, List<string> questions) :base("name", "description", 30)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {

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