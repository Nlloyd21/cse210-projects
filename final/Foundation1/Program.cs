using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Raj plays Fortnite!", "Noah Lloyd", 300);
        video1.AddComment(new Comment("Giselle", "Great Video Raj!"));
        video1.AddComment(new Comment("Peter", "You are kinda trash. Do better!"));
        video1.AddComment(new Comment("Hannah", "You are the best Raj"));

        Video video2 = new Video("Baking a cake", "Raj Patil", 900);
        video2.AddComment(new Comment("Jeffery", "That looks like a tasty cake"));
        video2.AddComment(new Comment("Emily", "Can you do a lemon cake next?"));
        video2.AddComment(new Comment("Tyson", "Emily lemon cakes suck!"));

        Video video3 = new Video("Cedar Point Vlog!", "Coaster Pioneer", 700);
        video3.AddComment(new Comment("G", "Great Content!"));
        video3.AddComment(new Comment("Taylor", "YOU NEED TO RIDE STEEL VENGEANCE"));
        video3.AddComment(new Comment("Eric", "This looks like a fun park!"));

        video1.DisplayVideoInformation();
        video2.DisplayVideoInformation();
        video3.DisplayVideoInformation();

    }
}