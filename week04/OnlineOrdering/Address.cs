class Address
{
    string _streetAddress;
    string _city;
    string _state_province;
    string _country;

    public Address(string street, string city, string state_province, string country)
    {
        _streetAddress = street;
        _city = city;
        _state_province = state_province;
        _country = country;
    }

    public bool inUSA()
    {
        if (_country.ToLower() == "usa")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void DisplayAddress()
    {
        Console.WriteLine($"{_streetAddress}, {_city}");
        Console.WriteLine($"{_state_province}, {_country}");
        Console.WriteLine();
    }


}