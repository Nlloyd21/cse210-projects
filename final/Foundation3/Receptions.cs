public class Reception : Event
{
    private string _email;

    public Reception(string eventTitle, string eventDescription, DateTime eventDateTime, string eventAddress, string email)
    : base(eventTitle, eventDescription, eventDateTime, eventAddress)
    {
        _email = email;
    }

    public override string GetEventType()
    {
        return "Reception";
    }
    public override string FullDetails()
    {
        return $"{base.StandardDetails()}\nType: {GetEventType()}\nRSVP Email: {_email}";
    }

}