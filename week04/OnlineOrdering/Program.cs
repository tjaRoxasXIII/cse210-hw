using System;

class Program
{
    

    static void Main(string[] args)
    {
        List<Product> order_products = [new Product("paper", 101, 10, 1), new Product("pencil", 102, 0.10f, 25), new Product("stapler", 103, 12, 3), new Product("eraser", 104, 1.50f, 15)];


        Address address1 = new Address("123 Test Drive", "Davenport", "FL", "USA");
        Customer customer1 = new Customer("John", address1);
        Order order1 = new Order(customer1);

        Address address2 = new Address("321 Zaragoza", "Juarez", "Chihuahua", "Mexico");
        Customer customer2 = new Customer("John", address2);
        Order order2 = new Order(customer2);

        Address address3 = new Address("6 Chome-1-1 Inter Park", "Kobe", "Hokkaido", "Japan");
        Customer customer3 = new Customer("John", address3);
        Order order3 = new Order(customer3);

        order1.addProduct(order_products[0]);
        order1.addProduct(order_products[3]);

        order2.addProduct(order_products[1]);
        order2.addProduct(order_products[1]);
        order2.addProduct(order_products[2]);

        order3.addProduct(order_products[0]);
        order3.addProduct(order_products[1]);
        order3.addProduct(order_products[2]);
        order3.addProduct(order_products[3]);


        Console.WriteLine("Details for order 1: \n");

        order1.createPackingLabel();
        Console.WriteLine();
        order1.createShippingLabel();
        Console.WriteLine();
        Console.WriteLine($"Order Total: ${order1.calculateTotalCost()}\n");

        Console.WriteLine("Details for order 2: \n");
        order2.createPackingLabel();
        Console.WriteLine();
        order2.createShippingLabel();
        Console.WriteLine();
        Console.WriteLine($"Order Total: ${order2.calculateTotalCost()}\n");

        Console.WriteLine("Details for order 3: \n");

        order3.createPackingLabel();
        Console.WriteLine();
        order3.createShippingLabel();
        Console.WriteLine();
        Console.WriteLine($"Order Total: ${order3.calculateTotalCost()}\n");

    }
}