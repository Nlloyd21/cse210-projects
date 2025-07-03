using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1600 Natures Way", "Lindenhurst", "IL", "USA");
        Address address2 = new Address("22 Ballard Rd", "Pelham", "NH", "USA");
        Address address3 = new Address("241 Scary Dr", "London", "Endland", "UK");

        Customer customer1 = new Customer("Noah Lloyd", address3);
        Customer customer2 = new Customer("Raj Patil", address2);
        Customer customer3 = new Customer("Giselle", address1);

        Product product1 = new Product("Laptop", "LP-351", 255, 1);
        Product product2 = new Product("Microphone", "MM-111", 10, 1);
        Product product3 = new Product("Colored Pencils", "CC-142", 5.99, 5);
        Product product4 = new Product("Erasers", "ST-143", 0.69, 3);

        Order order1 = new Order(customer1);
        order1.Add(product1);
        order1.Add(product2);

        Order order2 = new Order(customer2);
        order2.Add(product3);
        order2.Add(product4);
        order2.Add(product1);

        Order order3 = new Order(customer3);
        order3.Add(product2);
        order3.Add(product1);

        Console.WriteLine("----------------------");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: {order1.GetTotalCost()}");

        Console.WriteLine("\n----------------------");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: {order2.GetTotalCost()}");
        
        Console.WriteLine("\n----------------------");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Total Price: {order3.GetTotalCost()}");
    }
}