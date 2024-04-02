namespace foundation4;
class Cycling : Activity
{
    double distance;
    public Cycling(string date, int lengthInMins, double distance) : base(date, lengthInMins)
    {
        this.distance = distance;
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