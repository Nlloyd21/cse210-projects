public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string eventTitle, string eventDescription, DateTime eventDateTime, string eventAddress, string weather)
    : base(eventTitle, eventDescription, eventDateTime, eventAddress)
    {
        _weather = weather;
    }

    public override string GetEventType()
    {
        return "Outdoor Gathering";
    }
    public override string FullDetails()
    {
        return $"{base.StandardDetails()}\nType: {GetEventType()}\nWeather: {_weather}";
    }

}