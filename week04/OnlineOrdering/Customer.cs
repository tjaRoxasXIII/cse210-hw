class Customer
{
    string _name;
    Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public void DisplayName()
    {
        Console.WriteLine(_name);
    }

    public bool AddressInUSA()
    {
        if (_address.inUSA() == true)
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
        _address.DisplayAddress();
    }

}