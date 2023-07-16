public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int duration, int laps): base(date, duration)
    {
        this.laps = laps;
    }
    public override double GetDistance()
    {
        return laps * 50.0 / 1000.0;
    }
    public override double GetSpeed()
    {
        return GetDistance() / (duration / 60.0);
    }
    public override double GetPace()
    {
        return duration / GetDistance();
    }
    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance():F2} km, Speed: {GetSpeed:F2} mph, Pace: {GetPace():F2} min/km";
    }
}    