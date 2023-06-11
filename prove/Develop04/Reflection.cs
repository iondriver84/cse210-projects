public class ReflectionActivity : Activity{
    private string[] prompts = {
        "Think of a time where you overcame a serious obstacle.",
        "Think of a time where you helped someone through a trial or challenge",
        "Think of a moment where someone helped you through a particularly challenging experience",
        "Think of the last time you had a deeply spiritual moment."
    };

    private string[] questions = {
        "What do you remember clearest about that moment?",
        "What about this brings you happiness or contentment?",
        "What caused this event to occur?",
        "Who helped you reach this point?",
        "What makes this moment stand out over other similar instances?",
        "What did you learn from this experience?",
        "How did God direct you to this experience?",
        "How did The Lord prepare you to have this experience?",
        "What do you think The Lord wished for you to gain from this experience?",
        "How can you be mindful of this experience going forward?"
    };
    public ReflectionActivity(int duration) : base(duration)
    {

    }
    protected override string GetDescription()
    {
        return "This activity will help you reflect on significant events in your life and help you discover additional meaning within these experiences.";
    }
    protected override void CountDown()
    {
        base.CountDown();

        Console.WriteLine("Initializing reflection activity");

        Random random = new Random();

        for (int i = 0; i < Duration; i++)
        {
            if (!IsRunning)
                break;

            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);
            Thread.Sleep(4000);

            foreach (string question in questions)
            {
                Console.WriteLine(question);
                Thread.Sleep(8000);
                Console.WriteLine("Spinner Animation"); //spinner animation goes here
                Thread.Sleep(2000);
            }
        }
        Console.WriteLine("Reflection activity completed.");
    }
}