using System;
namespace foundation2;

class Program
{

    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Address address2 = new Address("456 Elm St", "Someplace", "NY", "USA");

        Customer customer1 = new Customer("Kyle", address1);
        Customer customer2 = new Customer("Ned", address2);

        Product product1 = new Product("Laptop", "P001", 1200, 1);
        Product product2 = new Product("Mouse", "P002", 25, 2);
        Product product3 = new Product("Keyboard", "P003", 50, 1);
        Product product4 = new Product("Headphones", "P004", 100, 1);

        List<Product> order1Products = new List<Product> { product1, product2 };
        Order order1 = new Order(order1Products, customer1);

        List<Product> order2Products = new List<Product> { product3, product4 };
        Order order2 = new Order(order2Products, customer2);


        Console.WriteLine("Order 1:");
        order1.PackingLabel();
        order1.ShippingLabel();
        Console.WriteLine($"Total Price: ${order1.CalculateTotal()}");

        Console.WriteLine("\nOrder 2:");
        order2.PackingLabel();
        order2.ShippingLabel();
        Console.WriteLine($"Total Price: ${order2.CalculateTotal()}");
    }
}

