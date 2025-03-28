class Product
{
    string _name;
    int _productID;
    float _price;
    int _quantity;

    public Product(string name, int productID, float price, int quantity=1)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public float TotalCost()
    {
        return _quantity * _price;
    }

    public void DisplayLabel()
    {
        Console.WriteLine($"{_name} - {_productID}");
    }
}