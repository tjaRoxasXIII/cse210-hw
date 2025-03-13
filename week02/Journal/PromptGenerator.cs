public class PromptGenerator
{
   public List<string> _prompts = [
    "What was the best part of your day today?", 
    "Who was your favorite person to interact with today?",
    "How did your activity today bless someone else?",
    "If I had one thing I could do over today, what would it be?",
    "How did I see the hand of the Lord in my life today?"
    ];

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int prompt_selector = rnd.Next(_prompts.Count);
        string prompt = _prompts[prompt_selector];

        return prompt;
    }

}
