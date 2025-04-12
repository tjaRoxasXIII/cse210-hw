class GoalHandler
{
    private int _score;
    List<Goal> _goals;

    public GoalHandler(int score, List<Goal> goals)
    {
        _score = score;
        _goals = goals;
    }

    public void Start()
    {

    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void ListGoalDetails()
    {

    }

    public void CreateGoal()
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Option: ");
        string choice = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.Write("Points: ");
        string points = Console.ReadLine();

        switch (choice)
        {
            case "1":
                new SimpleGoal(name, description, points);
                break;
            case "2":
                new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("Target Count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus Points on Completion: ");
                int bonus = int.Parse(Console.ReadLine());
                new ChecklistGoal(name, description, points, target, bonus);
                break;
        }
    }
    
    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {
         
    }
}