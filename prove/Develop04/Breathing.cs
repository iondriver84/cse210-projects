using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration)
    {

    }
    protected override string GetDescription()
    {
        return "This activity will help you relax by walking you through a simple, timed breathing exercise. Please follow the isntructions on your screen.";
    }
    protected override void CountDown()
    {
        base.CountDown();
        Console.WriteLine("Initializing breathing activity...");
        
        while (IsRunning)
        {
            Console.WriteLine("Breathe in");
            Thread.Sleep(3000);

            if (!IsRunning)
                break;
            
            Console.WriteLine("Breathe out");
            Thread.Sleep(3000);
        }
        
        Console.WriteLine("Breathing Activity Complete.");
        
    }
}

