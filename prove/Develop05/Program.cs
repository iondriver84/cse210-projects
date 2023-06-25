using System;

class Program
{
    static List<Activity> activities = new List<Activity>();
    static void Main(string[] args)
    {
        

        while(true)
        {
            Console.WriteLine("1. Create a New Goal");
            Console.WriteLine("2. Record an Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Please Select one of the Above Options");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(activities);
                    break;
                case "2":
                    RecordEvent(activities);
                    break;
                case "3":
                    DisplayGoals(activities);
                    break;
                case "4":
                    DisplayScore(activities);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select again.");
                    break; 
            }

            Console.WriteLine();
            
        }
    }
    static void CreateNewGoal(List<Activity> activites)
    {
        Console.WriteLine("Select the type of goal you want to create:");
        Console.WriteLine("1.Simple Goal");
        Console.WriteLine("2.Eternal Goal");
        Console.WriteLine("3.Checklist Goal");
        Console.WriteLine("Enter your choice");

        string choice = Console.ReadLine();

        Activity activity;

        switch (choice)
        {
            case "1":
                    activity = new SimpleGoalActivity();
                    break;
                case "2":
                    activity = new EternalGoalActivity();
                    break;
                case "3":
                    activity = new ChecklistGoalActivity();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Returning to previous menu.");
                    return; 
        }
        activity.SetBigGoal();
        activity.SetBigGoalPoints();
        activity.SetMilestones();
        activity.SetMilestoneIntervals();

        activities.Add(activity);

        Console.WriteLine("Goal created successfully.");
    }

    static void RecordEvent(List<Activity> activities)
    {
        if (activities.Count ==0)
        {
            Console.WriteLine("No goals found. Please create a goal first");
            return;
        }
        Console.WriteLine("Select a goal to record an event:");
        for (int i = 0; i < activities.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {activities[i].GetType().Name}");
        }
        Console.WriteLine("Enter the number of the goal:");

        if(int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex >= 1 && goalIndex <= activities.Count)
        {
            activities[goalIndex - 1].RecordEvent();
            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Invalid goal number. Event recording canceled");
        }
    }
    
    static void DisplayGoals(List<Activity> activities)
    {
        if (activities.Count == 0)
        {
            Console.WriteLine("No goals found. Please create a goal first.");
            return;
        }

        Console.WriteLine("Goals");

        for(int i = 0; i<activities.Count; i++)
        {
            if (activities.Count == 0)
            activities[i].DisplayGoals();
            Console.WriteLine();
        }
    }
    static void DisplayScore(List<Activity> activities)
    {
        if (activities.Count == 0)
        {
            Console.WriteLine("No goals found. Please create a goal first.");
            return;
        }
        Console.WriteLine("Scores");

        for (int i = 0; i < activities.Count; i++)
        {
            Console.WriteLine($"Goal {i + 1}:");
            activities[i].DisplayScore();
            Console.WriteLine();
        }
        

    }

}