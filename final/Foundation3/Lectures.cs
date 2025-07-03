public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;
    public Lecture(string eventTitle, string eventDescription, DateTime eventDateTime, string eventAddress, string speakerName, int capacity)
    : base(eventTitle, eventDescription, eventDateTime, eventAddress)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public override string GetEventType()
    {
        return "Lecture";
    }
    public override string FullDetails()
    {
        return $"{base.StandardDetails()}\nType: {GetEventType()}\nSpeaker: {_speakerName}\nCapacity: {_capacity}";
    }

}