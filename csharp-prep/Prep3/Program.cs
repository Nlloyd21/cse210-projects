using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

    
       
        int guess = -1;
        while (guess != number)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > number)
            Console.WriteLine("Lower");

            else if (guess < number)
            Console.WriteLine("Higher");

            else
            Console.WriteLine("Congrats! You guessed Correctly!");
        }
       
       
        }
}