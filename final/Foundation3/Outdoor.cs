namespace foundation3;
class Outdoor : Event
{
    string forecast;
    public Outdoor(string title, string description, string date, string time, Address address, string forecast) : base(title, description, date, time, address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
        this.forecast = forecast;
    }

    public override string FullDetails()
    {
        return $"{title}: {description}\n{date}, {time} @ {address.ReturnString()}\n{forecast}";
    }
}