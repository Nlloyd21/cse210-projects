using System;
using System.Security.Cryptography.X509Certificates;


class Circle
{
    private double _radius;

    public void setRadius(double radius)
    {
        _radius = radius;
    }

    public double GetRadius()
    {
        return _radius;
    }
    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}
class Program
{

    static void Main(string[] args)
    {
    Circle myCircle = new Circle();
    myCircle.setRadius(10);

    Console.WriteLine($"{myCircle.GetRadius()}"); 
    Console.WriteLine($"{myCircle.GetArea()}");
    }
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Sandbox World!");

//         // int x = 10;

//         // for (int i = 0; i <= x; i++)
//         // {
//         //     Console.WriteLine("" + i);
//         // } 

//         // List<int> myNumbers = new List<int>();
//         // myNumbers.Add(10);
//         // myNumbers.Add(9);
//         // myNumbers.Add(100);

//         // foreach (int i in myNumbers)
//         // {
//         //     Console.WriteLine(i);
//         // }
//         // Console.WriteLine(myNumbers.Count);

//         double total = AddNumbers(234, 432);
//         Console.WriteLine(total);
        
//     }
}