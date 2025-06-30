public class SimpleGoal : Goal
{

    public SimpleGoal(string name, string description, int points)
    : base(name, description, points)
    {

    }
    public override void Create()
    {
        CreateBaseGoal();
    }
    public override int RecordEvent()
    {
        if (!_status)
        {
            _status = true;
            Console.WriteLine($"Congratulations! You have earned {_points} for completing your goal: {_name}");
            return _points;
        }
        else
        {
            Console.WriteLine($"Your goal {_name} has already been marked as completed");
            return 0;
        }
    }
    public override bool isComplete()
    {
        return _status;
    }
    public override string GetDetails()
    {
        string statusMark = _status ? "[X]" : "[ ]";
        return $"{statusMark} {_name} ({_description})";
    }
    public override string SaveString()
{
    return $"SimpleGoal:{_name}:{_description}:{_points}:{_status}";
}

}
