using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("The History of Roller Coasters", "We will dig dip and learn the history of modern roller coasters.", new DateTime(2025, 7, 15, 18, 0, 0), "1600 Pennsynvalia Ave, Washington DC", "Noah Lloyd", 2500);

        Reception reception = new Reception("Tyson & Aubrey Short", "Come together as we celebrate the sealing of Tyson Short and Aubrey Huber.", new DateTime(2025, 7, 29, 19, 0, 0), "2504 Hitt Rd, Idaho Falls, Idaho", "tysonwedding@gmail.com");

        Outdoor outdoor = new Outdoor("Music Festival", "Come listen to some amazing artists and jam out", new DateTime(2025, 8, 24, 9, 0, 0), "150 Great Music Drive, Ammon, Idaho", "Sunny weather with slight wind for a little breeze");

        Console.WriteLine("===Lecture===\n");
        Console.WriteLine($"Standard Details:\n\n{lecture.StandardDetails()}");
        Console.WriteLine($"\n\nFull Details:\n\n{lecture.FullDetails()}");
        Console.WriteLine($"\n\nShort Description:\n\n{lecture.ShortDescription()}");

        Console.WriteLine("\n\n--------------------------------------\n\n");
        Console.WriteLine("===Reception===\n");
        Console.WriteLine($"Standard Details:\n\n{reception.StandardDetails()}");
        Console.WriteLine($"\n\nFull Details:\n\n{reception.FullDetails()}");
        Console.WriteLine($"\n\nShort Description:\n\n{reception.ShortDescription()}");

        Console.WriteLine("\n\n--------------------------------------\n\n");
        Console.WriteLine("===Outdoor Gathering===\n");
        Console.WriteLine($"Standard Details:\n\n{outdoor.StandardDetails()}");
        Console.WriteLine($"\n\nFull Details:\n\n{outdoor.FullDetails()}");
        Console.WriteLine($"\n\nShort Description:\n\n{outdoor.ShortDescription()}");

    }
}