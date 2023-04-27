using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomgenerator = new Random();

        bool answer = false;
        
        int magic_num = randomgenerator.Next(1, 10);
        do{
            Console.Write("What is your guess?");
            string guess = Console.ReadLine();
            int guess_num = int.Parse(guess);

            if(guess_num < magic_num){
                Console.WriteLine("Higher");
            }
            else if (guess_num > magic_num){
                Console.WriteLine("Lower");
            }
            else if (guess_num == magic_num){
                answer = true;
                Console.WriteLine("You guessed correctly!.");
            }
        
    } while (answer == false);




    }
}
