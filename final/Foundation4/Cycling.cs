public class Cycling : Activity
{
private double _speed;

public Cycling(string date, double length, double speed) : base (date, length)
{
    SetType("Cycling");
    _speed = speed;
}

public override double GetDistance(){return ((GetLength() * _speed) / 60);}
public override double GetSpeed(){return _speed;}
public override double GetPace(){return (60 / _speed);}
}
