public abstract class Activity
{
    private string _date;
    private double _length;
    private string _type;

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    public void SetType(string type){_type = type;}

    public double GetLength(){return _length;}

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date} {_type} ({_length} min): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}
