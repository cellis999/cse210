namespace foundation2;
class Address
{
    string street;
    string city;
    string state;
    string country;
    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }
    public bool IsInUSA()
    {
        if (country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string ReturnString()
    {
        return $"{street} {city}, {state}, {country}";
    }
}