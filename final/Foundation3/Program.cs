using System;

class Program
{
    static void Main(string[] args)
    
    {
        Lecture lectureEvent = new Lecture("How platypuses are really from another galaxy", "Learn how the government and the scientific 'community' are playing us all for fools!", new DateTime(2023, 8, 23), new TimeSpan(8, 0, 0), new Address("300 S 200 E", "Salt Lake City", "Utah", "84201"), "Freddie Mercury", 1300);
        Reception receptionEvent = new Reception("Billie and Ted's Excellent Wedding Reception!", "It's just like the movie!", new DateTime(2023, 8, 25), new TimeSpan(4, 0, 0), new Address("300 S 200 E", "Salt Lake City", "Utah", "84201"), "rsvpBillie&Ted@gmail.com");
        OutdoorEvent outdoorBBQ = new OutdoorEvent("Ward BBQ!", "Bring the smoker Ed!", new DateTime(2023, 8, 27), new TimeSpan(3, 0, 0), new Address("300 E 400 N","Salt Lake City", "Utah", "84201"), "Sunny");

        Console.WriteLine("Lecture Event - Standard Details:");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Reception Event - Full Details");
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Event - Short Description");
        Console.WriteLine(outdoorBBQ.GetShortDescription());

    }
}