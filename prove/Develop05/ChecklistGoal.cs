public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;

    public override void Create()
    {
        CreateBaseGoal();
        Console.Write("How many times must this goal be completed? ");
        _targetCount = int.Parse(Console.ReadLine());
        _currentCount = 0;
    }
    public ChecklistGoal(string name, string description, int points, int targetCount, int currentCount)
    : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = currentCount;
    }
    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            Console.WriteLine($"Progress: {_currentCount}/{_targetCount}");
            if (_currentCount == _targetCount)
            {
                _status = true;
                Console.WriteLine($"Checklist completed! You earned {_points} points!");
                return _points;
            }
            return 0; 
        }

        
        Console.WriteLine("This goal has already been completed.");
        return 0;
    }

    public override bool isComplete()
    {
        return _status;
    }

    public override string GetDetails()
    {
        string statusMark = _status ? "[X]" : "[ ]";
        return $"{statusMark} {_name} ({_description}) -- {_currentCount}/{_targetCount}";
    }

    public override string SaveString()
    {
        return $"Checklist Goal:{_name}:{_description}:{_points}:{_status}";
    }
}