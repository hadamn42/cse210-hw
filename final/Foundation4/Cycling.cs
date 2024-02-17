using System.Runtime.CompilerServices;

public class Cycling : Exercise {
    public Cycling(string date, float duration, float speed) : base(date, duration)
    {
        _speed = speed;
        _type = "Cycling";

    }

    public override void SetRemainders(){
        _distance = CalcDistance();
        _pace = CalcPace();
    }

    public override double CalcPace(){
        return 60 / _speed;
    }
}