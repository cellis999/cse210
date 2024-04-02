namespace foundation3;
class Lecture : Event
{
    string speaker;
    string capacity;
    public Lecture(string title, string description, string date, string time, Address address, string speaker, string capacity) : base(title, description, date, time, address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string FullDetails()
    {
        return $"{title}: {description}\n{date}, {time} @ {address.ReturnString()}\n{speaker} Max Capacity: {capacity}";
    }
}