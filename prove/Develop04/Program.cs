using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while(running)
        {
            Console.WriteLine("Welcome to your mindfulness program. What activity would you like to enjoy today?");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.Write("Select an option: ");
            {
                int option;
                while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 4)
                {
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 4:");
                }
                if (option == 4)
                    {
                        running = false;
                        continue;
                    }
                Activity activity;
                switch(option)
                {
                    case 1: 
                        activity = new BreathingActivity(0);
                        break;
                    case 2:
                        activity = new ReflectionActivity(0);
                        break;
                    case 3:
                        activity = new ListingActivity(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        continue;
                }
                activity.Start();

                Console.WriteLine("Press Enter to stop the activity.");
                Console.ReadLine();

                activity.Stop();
            }
        
        }

    }
}