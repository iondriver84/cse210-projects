using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What was your grade percentage?");
        string number = Console.ReadLine();
        int grade = int.Parse(number);
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = "B";

        }
        else if (grade >= 70 && grade < 80)
        {
            letter = "C";

        }
        else if (grade >= 60 && grade < 70)
        {
            letter = "D";

        }
        else
        {
            letter = "F";

        }

        Console.WriteLine($"You got an {letter}!");

        if (grade > 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("You'll do better next time!");
        }
    }
}