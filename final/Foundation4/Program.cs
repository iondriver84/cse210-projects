using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        DateTime date = new DateTime(2023, 7, 16);

        Running running = new Running(date, 20, 2.5);
        Cycling cycling = new Cycling(date, 40, 15);
        Swimming swimming = new Swimming(date, 20, 30);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}