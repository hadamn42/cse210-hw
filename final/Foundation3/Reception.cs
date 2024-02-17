public class Reception : Event{
    private string _email;
    public Reception(string title, string description, string date, string time, string address, string email) : base(title, description, date, time, address)
    {
        _type = "Reception";
        _email = email;
    }

    public override string FullDetails()
    {
        return $"We are pleased to annouce {_title}. {_description} {_title} will be held on {_date} {_time} at:\n{_addresses[0].FormalAddress()}.\nPlease send your RSVP to {_email}";    
    }
}