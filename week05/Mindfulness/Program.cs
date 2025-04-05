using System;

class Program
{
        
    static void Main(string[] args)
    {
        List<string> prompts = [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
            ];
    
        List<string> questions = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
            ];


        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        //BreathingActivity test = new BreathingActivity();
        ReflectingActivity test = new ReflectingActivity(prompts, questions);

        //test.ShowSpinner(30);
        //test.ShowCountDown(5);
        test.Run();
    }
}