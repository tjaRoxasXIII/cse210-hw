class Order
{
    List<Product> _products = new List<Product>();
    Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public float calculateTotalCost()
    {
        float totalCost = 0;
        foreach(Product product in _products)
        {
            totalCost += product.TotalCost();
        }
        if (_customer.AddressInUSA() == true)
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }

    public void createPackingLabel()
    {
        Console.WriteLine("Packing Label: ");
        foreach(Product product in _products)
        {
            product.DisplayLabel();
        }
    }

    public void createShippingLabel()
    {
        Console.WriteLine("Shipping Label: ");
        _customer.DisplayName();
        _customer.DisplayAddress();
    }

    public void addProduct(Product product)
    {
        _products.Add(product);
    }


}