using System.Collections.Concurrent;
using System.Net.Sockets;

namespace foundation2;
class Customer
{
    public string name;
    Address address;
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }
    public bool IsInUSA()
    {
        return address.IsInUSA();
    }

    public string ReturnAddress()
    {
        return address.ReturnString();
    }
}