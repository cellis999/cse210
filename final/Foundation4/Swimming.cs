namespace foundation4;
class Swimming : Activity
{
    double laps;
    public Swimming(string date, int lengthInMins, double laps) : base(date, lengthInMins)
    {
        this.laps = laps;
        this.date = date;
        this.lengthInMins = lengthInMins;
    }
    public override double GetDistance()
    {
        return laps * 50 / 1000;
    }
    public override double GetSpeed()
    {
        return laps / lengthInMins * 60;
    }
    public override double GetPace()
    {

        return lengthInMins / (laps * 0.05);
    }
}