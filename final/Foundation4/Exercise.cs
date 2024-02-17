public abstract class Exercise{
    protected string _date;
    // protected var _date = DateOnly.FromDateTime(DateTime.Today);
    protected double _duration;
    protected double _distance;
    protected double _speed;
    protected double _pace;
    protected string _type;


    public Exercise(string date, double duration){
        _date = date;
        _duration = duration;
    }

    public void Summary(){
        SetRemainders();
        Console.WriteLine($"{_date} {_type} ({_duration} min)- Distance {_distance:N2} miles, Speed: {_speed:N2} mph, Pace: {_pace:N2} min per mile");
    }

    public virtual double CalcDistance(){
        return _speed * (_duration/60);
    }

    public virtual double CalcSpeed(){
        return (_distance / _duration) * 60;
    }
    public virtual double CalcPace(){
        return _duration / _distance;
    }

    public abstract void SetRemainders();



}