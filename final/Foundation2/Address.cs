using System.Reflection.Metadata.Ecma335;

public class Address{
    private string _streetAddress;
    private string _city;
    private string _statProv;
    private string _country;
    private string _zipPostal;

    public Address(string streetAddress, string city, string statProv, string zipPostal, string country){
        _streetAddress = streetAddress;
        _city = city;
        _statProv = statProv;
        _zipPostal = zipPostal;
        _country = country;
    }

    public bool IsInUSA(){
        bool inUSA;
        if (_country == "USA"){
            inUSA = true;
        }
        else if (_country == "United States"){
            inUSA = true;
        }
        else if (_country == "US"){
            inUSA = true;
        }
        else{
            inUSA = false;
        }

        return inUSA;
    }

    public string ShipAddress(){
        if (IsInUSA() == true){
            return $"{_streetAddress}\n{_city}, {_statProv} {_zipPostal}";
        }
        else{
            return $"{_streetAddress}\n{_city}, {_statProv} {_zipPostal} {_country}";
        }
    }
}