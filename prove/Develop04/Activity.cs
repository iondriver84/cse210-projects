using System;
using System.Threading;

public abstract class Activity
{
    protected int duration;
    private Thread timerThread;
    protected bool isRunning;
    
    public int Duration
    {
        get{return duration;}
        set{duration = value;}
    }

    public bool IsRunning
    {
        get {return isRunning;}
        set {isRunning = value;}
    }
    public Activity(int duration)
    {
        this.duration = duration;
    }
    public void Start()
    {
        Console.WriteLine($"Welcome to the {GetType().Name}!");
        Console.WriteLine(GetDescription());
        Console.WriteLine("Please set the duration in seconds:");
        duration = ReadDurationFromInput();

        Console.WriteLine("It's time to start...");
        Thread.Sleep(4000);

        isRunning = true;
        timerThread = new Thread(CountDown);
        timerThread.Start();
    }
    
    private int ReadDurationFromInput()
    {
        int duration = 0;
        bool isValidDuration = false;
        while (!isValidDuration)
        {
            if (int.TryParse(Console.ReadLine(), out duration) && duration > 0)
            {
                isValidDuration = true;
            }
            else
            {
                 Console.WriteLine("Invalid duration. Please enter a positive integer:");
            }
        }
        return duration;
       
   
    }
    protected abstract string GetDescription();
    protected virtual void CountDown()
    {

        int secondsPassed = 0;
        char[] spinnerChars = { '|', '/', '-', '\\'};
        int spinnerIndex = 0;

        while (secondsPassed < duration && isRunning)
        {
            Console.WriteLine($"Elapsed time: {secondsPassed} seconds");
            secondsPassed++;
            spinnerIndex = (spinnerIndex = 1) % spinnerChars.Length;
            Thread.Sleep(1000);
            Console.SetCursorPosition(0, Console.CursorTop -1);
        }
        Console.WriteLine("Time's Up!");
        Console.WriteLine("Great job! ");
        Console.WriteLine($"You have completed {GetType().Name} for {duration} seconds");
        Thread.Sleep(4000);
    }
    public void Stop()
    {
        isRunning = false;
        if (timerThread != null && timerThread.IsAlive)
        {
            timerThread.Join();
        }
    }
}