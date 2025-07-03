public class Event
{
    protected string _eventTitle;
    protected string _eventDescription;
    protected DateTime _eventDateTime;
    protected string _eventAddress;

    public Event(string eventTitle, string eventDescription, DateTime eventDateTime, string eventAddress)
    {
        _eventTitle = eventTitle;
        _eventDescription = eventDescription;
        _eventDateTime = eventDateTime;
        _eventAddress = eventAddress;
    }
    public string StandardDetails()
    {
        return $"Title: {_eventTitle}\nDescription: {_eventDescription}\nDate: {_eventDateTime.ToShortDateString()}\nTime: {_eventDateTime.ToShortTimeString()}\nAddress: {_eventAddress}";
    }
    public virtual string GetEventType()
    {
        return "";
    }
    public virtual string FullDetails()
    {
        return $"{StandardDetails}\nType: {GetEventType()}";
    }
    public virtual string ShortDescription()
    {
        return $"Title: {_eventTitle}\nDate: {_eventDateTime.ToShortDateString()}\nEvent Type: {GetEventType()}";
    }

}
    
