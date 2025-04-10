public class SimpleGoal : Goal
{
    bool _isComplete;

    public SimpleGoal(string name, string description, string points, bool isComplete) :base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public void RecordEvent()
    {
        _isComplete = true;
    }

    public bool IsComplete()
    {
        return _isComplete;
    }

    public string GetStringRepresentation()
    {
        if(_isComplete == true)
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }
    }
}