public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    public bool _status;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    protected void CreateBaseGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.WriteLine("Please give a short description of your goal: ");
        _description = Console.ReadLine();
        Console.WriteLine("How many points is this goal worth? ");
        string stringGoalPoints = Console.ReadLine();
        _points = Convert.ToInt32(stringGoalPoints);
        _status = false;
    }
    public abstract int RecordEvent();

    public abstract bool isComplete();

    public virtual string GetDetails()
    {
        string statusMark = _status ? "[X]" : "[ ]";
        return $"{statusMark} {_name} {_description}";
    }
    public int Points
    {
        get { return _points; }
    }
    public abstract string SaveString();
    public abstract void Create();
}
