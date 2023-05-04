using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Party City";
        job1._jobTitle = "Clerk";
        job1._startYear = 2020;
        job1._endYear = 2022;


        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2022;
        job2._endYear = 2063;
        
        job1.Display();
        job2.Display();

        Resume resume1 = new Resume();
        resume1._firstName = "Patrick";
        resume1._lastName = "Hodge";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        Console.WriteLine($"{resume1._jobs[0]._jobTitle}");

        resume1.Display();
    }

}