public class Swimming : Exercise {
    private double _numLaps;

    public Swimming(string date, float duration, double numLaps) : base(date, duration)
    {
        _numLaps = numLaps;
        _type = "Swimming";     
    }

    public override void SetRemainders(){
        _distance = CalcDistance();
        _speed = CalcSpeed();
        _pace = CalcPace();
    }

    public override double CalcDistance()
    {
        return _numLaps * 0.031;
    }
}