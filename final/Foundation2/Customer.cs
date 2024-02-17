public class Customer{
    private string _name;
    private Address _address;
    private bool _isInUS;

    public Customer(string name, Address address){
        _name = name;
        _address = address;
    }

    public bool InUS(){
        _isInUS = _address.IsInUSA();
        return _isInUS;
    }

    public string AddressLabel(){
        return $"Shipping Label:\n{_name}\n{_address.ShipAddress()}";
    }
}