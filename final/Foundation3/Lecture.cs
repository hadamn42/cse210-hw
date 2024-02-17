public class Lecture : Event{
    private string _speaker;
    private int _capacity;
    
    public Lecture(string title, string description, string date, string time, string address, string speaker, string capacity) : base(title, description, date, time, address)
    {
        _type = "Lecture";
        _speaker = speaker;
        _capacity = int.Parse(capacity);
    }

    public override string FullDetails()
    {
        return $"{_speaker} will talk on {_title}: {_description} on {_date} {_time} at:\n{_addresses[0].FormalAddress()}.\nPlease be aware that we have a max capacity of {_capacity}";    
    }
}