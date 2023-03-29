public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        SetEventType("Lecture");
        _speaker = speaker;
        _capacity = capacity;
    }

    public string DisplayLectureDetails()
    {
        return $"{GetEventType()} - {GetTitle()}:\n{GetDescription()}\nSpeaker: {_speaker}\nDate and Time: {GetDate()} at {GetTime()}\nLocation: {GetAddress().FullAddress()}\nCapacity: {_capacity} people.";
    }
}
