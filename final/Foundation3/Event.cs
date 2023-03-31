public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private string _time;
    private Address _address;
    private string _type;

    public Event(string title, string description, DateTime date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string DisplayStandardDetails()
    {
        return $"{_title}:\n{_description}\nDate and Time: {_date.ToString("MMM dd, yyyy")} at {_time}\nLocation: {_address.FullAddress()}";
    }
    
    public string DisplayShortDescription()
    {
        return $"{_type} - {_title}:\n{_date.ToString("MMM dd, yyyy")}";
    }
    
    public void SetEventType(string type){_type = type;}

    public string GetTitle(){return _title;}
    public string GetDescription(){return _description;}
    public DateTime GetDate(){return _date;}
    public string GetTime(){return _time;}
    public Address GetAddress(){return _address;}
    public string GetEventType(){return _type;}
}
