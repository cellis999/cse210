using System.Collections.Specialized;

namespace foundation2;
class Product
{
    public string name;
    public string id;
    float price;
    int quantity;
    public Product(string name, string id, float price, int quantity)
    {
        this.name = name;
        this.id = id;
        this.price = price;
        this.quantity = quantity;
    }
    public float CalculateTotalCost()
    {
        float totalCost = price * quantity;
        return totalCost;
    }
}