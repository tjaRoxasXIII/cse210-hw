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

    }
    public override bool IsComplete()
    {
        return true;
    }
   
    public override string GetStringRepresentation()
    {
        return "";
    }
}