public class Outdoor : Event{
    private string _weather;
    public Outdoor(string title, string description, string date, string time, string address, string weather) : base(title, description, date, time, address)
    {
        _type = "Outdoor";
        _weather = weather;
    }

    public override string FullDetails()
    {
        return $"{_title}: {_description} {_date} {_time} at:\n{_addresses[0].FormalAddress()}\nPlease be aware that the weather condition that day will be {_weather}.";    
    }
}