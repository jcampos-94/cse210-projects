public class Reception : Event
{
    private string _rsvp;
    
    public Reception(string title, string description, DateTime date, string time, Address address, string rsvp)
        : base (title, description, date, time, address)
    {
        SetEventType("Reception");
        _rsvp = rsvp;
    }

    public string DisplayReceptionDetails()
    {
        return $"{GetEventType()} - {GetTitle()}:\n{GetDescription()}\nDate and Time: {GetDate().ToString("MMM dd, yyyy")} at {GetTime()}\nLocation: {GetAddress().FullAddress()}\nRSVP: {_rsvp}";
    }
}