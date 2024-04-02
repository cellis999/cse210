namespace foundation4;
class Activity
{
    public string date;
    public int lengthInMins;
    public Activity(string date, int lengthInMins)
    {
        this.date = date;
        this.lengthInMins = lengthInMins;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public string GetSummary()
    {
        return $"{date} {GetType().Name} ({lengthInMins})- Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}