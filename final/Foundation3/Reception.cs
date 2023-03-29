public class Reception : Event
{
    private string _rsvp;
    
    public Reception(string title, string description, string date, string time, Address address, string rsvp)
        : base (title, description, date, time, address)
    {
        SetEventType("Reception");
        _rsvp = rsvp;
    }

    public string DisplayReceptionDetails()
    {
        return $"{GetEventType()} - {GetTitle()}:\n{GetDescription()}\nDate and Time: {GetDate()} at {GetTime()}\nLocation: {GetAddress().FullAddress()}\nRSVP: {_rsvp}";
    }
}