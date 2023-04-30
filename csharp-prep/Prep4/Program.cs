using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;
        int max = 0;
        do{
            Console.WriteLine("Enter numbers until you wish to stop. Enter 0 when you would like to stop.");
            string input = Console.ReadLine();
            number = int.Parse(input);
            numbers.Add(number);
        }
        while (number != 0);
        int sum = 0;
        foreach(int num in numbers){
            
            sum = sum + num;
            if (num > max){
                max = num;
            }
        }
        
        Console.WriteLine($"The sum total of the numbers in the list is: {sum}.");
        float average = ((float)sum / numbers.Count);
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");



    }
}