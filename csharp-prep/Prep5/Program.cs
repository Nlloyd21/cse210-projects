using System;
using System.Globalization;

class Program
{

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
        
    }
    static string GetUserName()
    {
        Console.Write("Please enter your name: ");
        string username = Console.ReadLine();
        return username;
    }
    static int PromptUserNumber()
    {   int number = 0;
        Console.Write("Please enter an interger: ");
        number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square; 
    }
    static string DisplayResults(string username, int number, int square)
    {
        Console.WriteLine($"{username}, your number is {number}. Your number squared is {square}");
        string results = Console.ReadLine();
        return results;
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = GetUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResults(username, number, square);

    }
}