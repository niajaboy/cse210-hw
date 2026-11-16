
using System;

class Program
{
    static void Main(string[] args)
    {
        // First customer
        Address address1 = new Address(
            "123 Main Street",
            "Dallas",
            "Texas",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        // Products for first order
        Product product1 = new Product("Laptop", "P101", 500, 1);
        Product product2 = new Product("Mouse", "P102", 20, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        // Second customer
        Address address2 = new Address(
            "15 Rayfield Road",
            "Jos",
            "Plateau",
            "Nigeria"
        );

        Customer customer2 = new Customer("David James", address2);

        // Products for second order
        Product product3 = new Product("Keyboard", "P103", 30, 1);
        Product product4 = new Product("Monitor", "P104", 150, 2);
        Product product5 = new Product("Headphones", "P105", 40, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display first order
        Console.WriteLine("ORDER 1");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.GetTotalCost());

        Console.WriteLine();

        // Display second order
        Console.WriteLine("ORDER 2");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.GetTotalCost());
    }
}