public class Cycling : Activity
{
private double _speed;

public Cycling(DateTime date, double length, double speed) : base (date, length)
{
    SetType("Cycling");
    _speed = speed;
}

public override double GetDistance(){return ((GetLength() * _speed) / 60);}
public override double GetSpeed(){return _speed;}
}
