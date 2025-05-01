using System;
using System.Security.Cryptography.X509Certificates;

class Program
{

    static double AddNumbers(double a, double b)
        {
            return a + b;
        }


    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        // int x = 10;

        // for (int i = 0; i <= x; i++)
        // {
        //     Console.WriteLine("" + i);
        // } 

        // List<int> myNumbers = new List<int>();
        // myNumbers.Add(10);
        // myNumbers.Add(9);
        // myNumbers.Add(100);

        // foreach (int i in myNumbers)
        // {
        //     Console.WriteLine(i);
        // }
        // Console.WriteLine(myNumbers.Count);

        double total = AddNumbers(234, 432);
        Console.WriteLine(total);
        
    }
}