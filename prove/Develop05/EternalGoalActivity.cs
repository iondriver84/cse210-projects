class EternalGoalActivity : Activity
{
    public override void RecordEvent()
    {
        Console.WriteLine("Event reocorded for an eternal goal. You earned some points!");
        Points+=100;
    }
    public override void DisplayGoals()
    {
        Console.WriteLine($"Eternal Goal: {BigGoal}");
    }
    public override void DisplayScore()
    {
        Console.WriteLine($"Current Score: {Points}");
    }
}