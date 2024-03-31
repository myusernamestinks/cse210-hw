using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("7894 W. 2000 N.", "Anytown", "CA", "USA");
        Address address2 = new Address("1231 westt", "Sometown", "NY", "Canada");

        Customer customer1 = new Customer("John Cena", address1);
        Customer customer2 = new Customer("Justin Time", address2);

        Product product1 = new Product("Laptop", 1031, 827.0, 1);
        Product product2 = new Product("Phone", 1012, 531.0, 2);
        Product product3 = new Product("Tablet", 1023, 330.0, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("Order 1 Details:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.TotalCost()}");

        Console.WriteLine("\nOrder 2 Details:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.TotalCost()}");
    }
}
