class SimpleGoal : Goal
{
    bool _isComplete = false;

    public SimpleGoal(string name, string description, string points) :base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        if(!_isComplete)
        {
            IsComplete();
            GetStringRepresentation();
        }
        else
        {
            Console.WriteLine("This goal has already been completed");
            _points = "0";
        }
    }
    public override bool IsComplete()
    {
        return _isComplete = true;
    }
   
    public override string GetStringRepresentation()
    {
        if(!_isComplete)
        {
            return $"[ ] {_name} | {_description} | {_points}";

        }
        else
        {
            return $"[X] {_name} | {_description} | {_points}";
        }
    }
    
}