using System;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static GoalHandler manager = new GoalHandler(0, goals);

    static void Main()
    {
        bool running = true;
        while (running)
        {
            int score = manager.ReturnScore();

           // Console.Clear();
            Console.WriteLine($"Score: {score}");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            switch (Console.ReadLine())
            {
                case "1": manager.CreateGoal(); break;
                case "2": manager.ListGoals(); break;
                case "3": manager.RecordEvent(); break;
                case "4": manager.SaveGoals(); break;
                case "5": manager.LoadGoals(); break;
                case "6": running = false; break;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }
}