using Microsoft.VisualBasic;

namespace foundation3;
class Event
{
    public string title;
    public string description;
    public string date;
    public string time;
    public Address address;
    public Event(string title, string description, string date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }
    public string StandardDetails()
    {
        return $"{title}: {description}\n{date}, {time} @ {address.ReturnString()}";
    }
    public virtual string FullDetails()
    {
        return $"{title}: {description}\n{date}, {time} @ {address.ReturnString()}";
    }
    public string ShortDescription()
    {
        return $"{GetType().Name}: {title}, {date}";
    }
}