
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
    Circle myCircle = new Circle();
    myCircle.setRadius(10);

    Console.WriteLine($"{myCircle.GetRadius()}"); 
    Console.WriteLine($"{myCircle.GetArea()}");

    Cylinder myCylinder = new Cylinder();
    myCylinder.SetCircle(myCircle);
    myCylinder.SetHeight(10);
    Console.WriteLine($"{myCylinder.GetVolume()}");
    }
}