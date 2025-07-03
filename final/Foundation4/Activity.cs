public class Activity
{
    protected DateTime _date;
    protected int _minutes;


    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public int GetMinutes()
    {
        return _minutes;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public virtual string GetSummary()
    {
        return $"{_date.ToShortDateString()} {this.GetType().Name} ({_minutes} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} MPH, Pace: {GetPace()} min per mile";
    }


} 