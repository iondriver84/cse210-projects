public abstract class Activity
{
    protected string BigGoal {get; set; }
    protected int BigGoalPoints {get; set; }
    protected List<string> Milestones{get; set; }
    protected int MilestoneIntervals{get; set; }
    protected int Points{get; set; }

    public virtual void SetBigGoal()
    {
        Console.WriteLine("Enter the final goal you wish to reach");
        string bigGoal = Console.ReadLine();
    }
    public virtual int GetBigGoalPoints()
    {
        Console.WriteLine("Enter the final number of points you wish to reach as a number");
        string bigGoalPointsString = Console.ReadLine();
        
        if (int.TryParse(bigGoalPointsString, out int bigGoalPoints))
        {
            return bigGoalPoints;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            return 1000;
        }
    }
    public virtual void SetMilestones()
    {
        Console.WriteLine("This is for setting the milestones on your journey. If you would like to only have one kind of milestone, type 'same' and hit enter. If you would like to create different milestones in sequential order, type 'sequential' and press enter.");
        string userChoice = Console.ReadLine();

        Milestones = new List<string>();
    
        if (userChoice.ToLower()== "same")
        {
            Console.WriteLine("Enter your milestone");
            string milestone = Console.ReadLine();
            Milestones.Add(milestone);
        }
        else if (userChoice.ToLower()=="sequential")
        {
           Console.WriteLine("Enter your milestone. You can enter how many of these milestones you would like in a moment.");
            string userInput = Console.ReadLine();
            string[] milestoneStrings = userInput.Split(',');

            foreach (string milestoneString in milestoneStrings)
            {
                Milestones.Add(milestoneString);
            }
        }
        else
        {
            Console.WriteLine("Invalid choice, please either enter 'string' or 'list'");
        }
    }
    public virtual void GetMilestoneIntervals()
    {
        Console.WriteLine("Enter the point intervals you would like each milestone to be at, as an integer");
        string milestonesIntervalString = Console.ReadLine();

        if (int.TryParse(milestonesIntervalString, out int milestonesIntervals))
        {
            MilestoneIntervals = milestonesIntervals;
        }
        else
        {
            MilestoneIntervals = 100;
        }
    }
    public virtual void SetBigGoalPoints()
    {
        Console.WriteLine("enter the final number of points you wish to reach:");
        string bigGoalPointsString = Console.ReadLine();

        if (int.TryParse(bigGoalPointsString, out int bigGoalPoints))
        {
            BigGoalPoints = bigGoalPoints;
        }
        else
        {
            Console.WriteLine("Invalid input. Please Enter a valid integer.");
            BigGoalPoints = 1000;
        }
    }
    public virtual void SetMilestoneIntervals()
    {
        Console.WriteLine("Enter the point intervals you would like each milestone to have:");
        string milestonesIntervalString = Console.ReadLine();

        if (int.TryParse(milestonesIntervalString, out int milestonesIntervals))
        {
            MilestoneIntervals = milestonesIntervals;
        }
        else
        {
            MilestoneIntervals = 100;
        }
    }

    public abstract void RecordEvent();
    public abstract void DisplayGoals();

    public abstract void DisplayScore();

}   
