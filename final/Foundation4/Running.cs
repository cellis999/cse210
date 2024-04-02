namespace foundation4;
class Running : Activity
{
    double distance;
    public Running(string date, int lengthInMins, double distance) : base(date, lengthInMins)
    {
        this.distance = distance;
        this.date = date;
        this.lengthInMins = lengthInMins;
    }
    public override double GetDistance()
    {
        return distance;
    }
    public override double GetSpeed()
    {
        return (distance / lengthInMins) * 60;
    }
    public override double GetPace()
    {
        return lengthInMins / distance;
    }
}