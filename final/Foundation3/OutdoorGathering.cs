public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weather)
        : base (title, description, date, time, address)
    {
        SetEventType("Outdoor Gathering");
        _weather = weather;
    }

    public string DisplayOutdoorDetails()
    {
        return $"{GetEventType()} - {GetTitle()}:\n{GetDescription()}\nDate and Time: {GetDate().ToString("MMM dd, yyyy")} at {GetTime()}\nLocation: {GetAddress().FullAddress()}\nExpected Weather: {_weather}";
    }
}
