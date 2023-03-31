public class Swimming : Activity
{
private double _laps;

public Swimming(DateTime date, double length, double laps) : base (date, length)
{
    SetType("Swimming");
    _laps = laps;
}

public override double GetDistance(){return ((_laps * 50) / 1000);}
}
