using System;

class Program
{

    static void Main(string[] args)
    {
        List<string> r_prompts = [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
            ];
    
        List<string> r_questions = [
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
        List<string> l_prompts = [
           "Who are people that you appreciate?",
           "What are personal strengths of yours?",
           "Who are people that you have helped this week?",
           "When have you felt the Holy Ghost this month?",
           "Who are some of your personal heroes?"
        ];


        bool isRunning = true;
        string userResponse;
        
        
        while(isRunning == true)
        {
            Console.WriteLine("Welcome to the Mindfulness App!  Please make a selection to get started: ");
            Console.WriteLine("1. Breathing Exercise");
            Console.WriteLine("2. Reflection Exercise");
            Console.WriteLine("3. Listing Exercise");
            Console.WriteLine("4. Quit");
            userResponse = Console.ReadLine();
                
            
            if(userResponse == "1")
            {
                Console.WriteLine("How long would you like to perform this exercise in seconds?");
                int activityTime = Int32.Parse(Console.ReadLine());
                BreathingActivity ba = new BreathingActivity();
                ba._duration = activityTime;
                ba.Run();
                userResponse = "1";
            }
            if(userResponse == "2")
            {
                Console.WriteLine("How long would you like to perform this exercise in seconds?");
                int activityTime = Int32.Parse(Console.ReadLine());
                ReflectingActivity ra = new ReflectingActivity(r_prompts, r_questions);
                ra._duration = activityTime;
                ra.Run();
                userResponse = "2";
            }
            if(userResponse == "3")
            {
                Console.WriteLine("How long would you like to perform this exercise in seconds?");
                int activityTime = Int32.Parse(Console.ReadLine());
                ListingActivity la = new ListingActivity(l_prompts);
                la._duration = activityTime;
                la.Run();
                userResponse = "3";
            }
            if(userResponse == "4")
            {
                Console.WriteLine("Thank you and have a good day!");
                isRunning = false;
            }
        
        }
    }
    
}

    