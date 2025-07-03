public class Swimming : Activity
{
    private int _lapsSwimmed;

    public Swimming(DateTime date, int minutes, int laps)
    : base(date, minutes)
    {
        _lapsSwimmed = laps;
    }

    public override double GetDistance()
    {
        double distanceMiles = _lapsSwimmed * 50 / 1000 * 0.62;
        return distanceMiles;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }
    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }


}