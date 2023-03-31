public abstract class Activity
{
    private DateTime _date;
    private double _length;
    private string _type;

    public Activity(DateTime date, double length)
    {
        _date = date;
        _length = length;
    }

    public void SetType(string type){_type = type;}

    public double GetLength(){return _length;}

    public abstract double GetDistance();
    public virtual double GetSpeed(){return ((GetDistance() * 60) / GetLength());}
    public virtual double GetPace(){return(60 / GetSpeed());}

    public string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {_type} ({_length} min): Distance {GetDistance().ToString("0.0")} km, Speed: {GetSpeed().ToString("0.0")} kph, Pace: {GetPace().ToString("0.0")} min per km";
    }
}
