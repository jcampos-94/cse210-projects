public class Running : Activity
{
    private double _distance;
    public Running(DateTime date, double length, double distance) : base (date, length)
    {
        SetType("Running");
        _distance = distance;
    }

    public override double GetDistance(){return _distance;}
    public override double GetPace(){return (GetLength() / _distance);}
}
