using System.IO.Compression;
using System.Numerics;

namespace foundation2;
class Order
{
    List<Product> products;
    Customer customer;
    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }
    float total = 0;
    public float CalculateTotal()
    {
        foreach (Product product in products)
        {
            total += product.CalculateTotalCost();
        }
        total += CalculateShipping();
        return total;
    }
    public void PackingLabel()
    {
        foreach (Product product in products)
        {
            Console.WriteLine($"{product.name} : {product.id}");
        }
    }
    public void ShippingLabel()
    {
        Console.WriteLine($"{customer.name}: {customer.ReturnAddress()}");
    }
    float CalculateShipping()
    {
        if (customer.IsInUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
}