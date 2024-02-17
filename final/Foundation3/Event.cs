public abstract class Event{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _type = "";
    protected List<Address> _addresses = new List<Address>();

    public Event(string title, string description, string date, string time, string address){
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        MakeAddress(address);
    }

    public string ShortDescription(){
        return $"We are pleased to annouce the {_type} event: {_title} on {_date}";
    }

    public string StandardDetails(){
        return $"{_title}: {_description} on {_date} at {_time} at {_addresses[0].SimpleAddress()}";
    }

    public abstract string FullDetails();

    private void MakeAddress (string address){
        string[] addross = address.Split(", ");
        string street = addross[0];
        string city = addross[1];
        string state = addross[2];
        string zip = addross[3];

        Address andy = new Address(street, city, state, zip);
        _addresses.Add(andy);
    }
}