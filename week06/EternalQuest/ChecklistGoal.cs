class ChecklistGoal : Goal
{
    int _amountCompleted;
    int _target;
    int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) :base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        IsComplete();
        GetStringRepresentation();
    }
    public override bool IsComplete()
    {
        if(_amountCompleted == _target)
        {
            _points += _bonus;
            return true;
        }
        else
        {
            return false;
        }
    }
   
    public override string GetStringRepresentation()
    {
        return $"{_amountCompleted}/{_target} {_name} | {_description} | {_points}";
    }
}