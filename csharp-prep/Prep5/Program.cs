using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome(){
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName(){
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber(){;
            Console.WriteLine("What is your favorite number?");
            string fav_num = Console.ReadLine();
            int number = int.Parse(fav_num);
            return number;
        }
        static int SquareNumber(int number){
            int squared = number * number;
            return squared;
        }
        static string DisplayResult(string name, int squared){
            Console.WriteLine($"{name}, the number you selected squareed is {squared}.");
        }
    }
}