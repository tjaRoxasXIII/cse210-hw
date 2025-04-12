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
        ListGoalDetails();
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }
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
                Goal sGoal = new SimpleGoal(name, description, points);
                _goals.Add(sGoal);
                break;
            case "2":
                Goal eGoal = new EternalGoal(name, description, points);
                _goals.Add(eGoal);
                break;
            case "3":
                Console.Write("Target Count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus Points on Completion: ");
                int bonus = int.Parse(Console.ReadLine());
                Goal cGoal = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(cGoal);
                break;
        }
    }
    
    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you complete?");
        ListGoalDetails();
        Console.WriteLine("");
        string choice = Console.ReadLine();
        int intChoice = Int32.Parse(choice) - 1;
        

        _goals[intChoice].RecordEvent();
        
        _score += _goals[intChoice].AddPoints();

    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {
         
    }

    public int ReturnScore()
    {
        return _score;
    }
}