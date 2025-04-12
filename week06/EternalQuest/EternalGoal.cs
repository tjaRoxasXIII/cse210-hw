class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) :base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        IsComplete();
        GetStringRepresentation();
    }
    public override bool IsComplete()
    {
        return true;
    }
   
    public override string GetStringRepresentation()
    {
        return $"{_name} | {_description} | {_points}";
    }
}