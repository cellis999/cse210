namespace foundation3;
class Reception : Event
{
    string rsvp;
    public Reception(string title, string description, string date, string time, Address address, string rsvp) : base(title, description, date, time, address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
        this.rsvp = rsvp;
    }

    public override string FullDetails()
    {
        return $"{title}: {description}\n{date}, {time} @ {address.ReturnString()}\n{rsvp}";
    }
}