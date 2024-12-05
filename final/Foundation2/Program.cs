using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Order 1//
        Address address1 = new Address("100 Center St", "Springville", "UT", "USA");

        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);

        Product product1_O1 = new Product("Watch", "W100", 22.00f, 1);
        Product product2_O1 = new Product("Wallet", "W200", 14.50f, 1);
        Product product3_O1 = new Product("Ring", "R100", 8.59f, 2);
        order1.AddProduct(product1_O1);
        order1.AddProduct(product2_O1);
        order1.AddProduct(product3_O1);

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.CreatePackingLabel());

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order1.CreateShippingLabel());

        Console.WriteLine("\nOrder Total:");
        Console.WriteLine("$" + order1.CalculateTotal());
        Console.WriteLine("");

        //Order 2//
        Address address2 = new Address("500 Main St", "Springville", "NS", "Canada");

        Customer customer2 = new Customer("Jane Doe", address2);

        Order order2 = new Order(customer2);

        Product product1_O2 = new Product("Cat Shirt", "S100", 23.49f, 1);
        Product product2_O2 = new Product("Ring", "R100", 8.59f, 1);
        Product product3_O2 = new Product("Bracelet", "B100", 6.25f, 1);
        order2.AddProduct(product1_O2);
        order2.AddProduct(product2_O2);
        order2.AddProduct(product3_O2);

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.CreatePackingLabel());

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order2.CreateShippingLabel());

        Console.WriteLine("\nOrder Total:");
        Console.WriteLine("$" + order2.CalculateTotal());
        Console.WriteLine("");
    }
}