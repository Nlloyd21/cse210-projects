using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Please enter a list of numbers. When you are done, please enter 0");

        List<int> numbers = new List<int>();
        int number = -1;
        while (number != 0)
        {
            Console.Write("Please enter a number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }
        int sum = numbers.Sum();
        double average = numbers.Average();
        int largest = numbers.Max();
        int total_numbers = numbers.Count();
        Console.WriteLine($"The sum of your numbers is: {sum}\nThe average number is: {average}\nThe largest number is {largest}\nYou entered {total_numbers -1 } numbers");
    }
}