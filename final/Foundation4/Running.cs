public class Running : Exercise{
    public Running (string date, float duration, float distance) : base(date, duration)
    {
        _distance = distance;
        _type = "Running";        
            }

    public override void SetRemainders(){
        _pace = CalcPace();
        _speed = CalcSpeed();
    }

    public override double CalcSpeed()
    {
        return 60 / _pace;
    }
}