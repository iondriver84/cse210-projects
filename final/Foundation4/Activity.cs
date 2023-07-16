public abstract class Activity
{
    private DateTime date;
    protected int duration;
   
    public Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;
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
    public virtual string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} {GetType().Name} ({duration} min)";
    }


}   

