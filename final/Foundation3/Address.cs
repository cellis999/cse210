namespace foundation3;
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
    public string ReturnString()
    {
        return $"{street} {city}, {state}, {country}";
    }
}