public class ListingActivity : Activity
{
    private string[] prompts = {
        "What are some of the achievements you are proud of?",
        "What are some of the blessings you are most grateful for?",
        "What are some of the things that bring you joy?",
        "What are some moments you have felt the Holy Ghost this month?",
        "Who are some of the people you look up to most in your life?"
    };

    public ListingActivity(int duration) : base(duration)
    {

    }
    protected override string GetDescription()
    {
        return "This activity will assist you with reflecting on various uplifting topics concerning your life.";
    }

    protected override void CountDown()
    {
        base.CountDown();

        Console.WriteLine("Initializing listing activity");

        Random random = new Random();

        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Thread.Sleep(4000);
        Console.WriteLine("Begin listing:");

        int itemsCount = 0;
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < endTime && IsRunning)
        {
            string item = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(item))
                break;

            itemsCount++;
        }
        Console.WriteLine($"You listed {itemsCount} items.");
        Console.WriteLine("Listing activity completed.");
    }
}