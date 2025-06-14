
// class Program
// {
//     static void Main(string[] args)
//     {
//         Cylinder myCylinder = new Cylinder();
//         myCylinder.SetCircle
//     }
// }

class Program
{

    static void Main(string[] args)
    {
        //     Circle myCircle = new Circle(10);
        //     // myCircle.setRadius(10);

        //     Console.WriteLine($"{myCircle.GetRadius()}");
        //     Console.WriteLine($"{myCircle.GetArea()}");

        //     Cylinder myCylinder = new Cylinder(100, 5);
        //     // myCylinder.SetCircle(myCircle);
        //     // myCylinder.SetHeight(10);
        //     Console.WriteLine($"{myCylinder.GetVolume()}");
        // }
        // int sleepTime = 250;
        int time = 12;
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(time);

        string animationString2 = "+\\/-";
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(animationString2[index++] % animationString2.Length);
            Thread.Sleep(1000);
            Console.Write("\b");
        }

        // int count = time;
        // // string animationString = "(^_^)(-_-)";

        // while (DateTime.Now < endTime)
        // {
        //     Console.Write(count--);
        //     Thread.Sleep(1000);
        //     Console.Write("\b\b\b\b\b\b\b");
        // }

        // while (DateTime.Now < endTime)
        // {
        //     Console.Write("-");
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b\b\b");
        //     Console.Write("\\");
        //     Thread.Sleep(sleepTime);
        //     Console.Write("|");
        //     Console.Write("\b\b\b\b\b");
        //     Thread.Sleep(sleepTime);
        //     Console.Write("/");
        //     Console.Write("\b\b\b\b");
        //     Thread.Sleep(sleepTime);
        //     Console.Write("-");
        //     Console.Write("\b\b\b");
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\\");
        //     Console.Write("|");
        // }
    } 
}