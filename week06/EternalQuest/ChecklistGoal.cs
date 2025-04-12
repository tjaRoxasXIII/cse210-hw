class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) :base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if(_amountCompleted != _target)
        {
            _amountCompleted += 1;
            IsComplete();
            GetStringRepresentation();
        }
        else
        {
            Console.WriteLine("This task has already been completed");
            _points = "0";
        }
    }
    public override bool IsComplete()
    {
        if(_amountCompleted == _target)
        {
            int pts = Int32.Parse(_points) + _bonus;
            _points = pts.ToString();
            return true;
        }
        else
        {
            return false;
        }
    }
   
    public override string GetStringRepresentation()
    {
        return $"{_amountCompleted}/{_target} - {_name}: {_points} points";
    }
}