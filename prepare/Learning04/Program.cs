using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Assignment assignment = new Assignment("Micheal", "Math");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment1 = new MathAssignment("Roberto", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        WritingAssignment w1 = new WritingAssignment("Mary Walters", "European History", "The Causes of World War II");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingAssignment());

    }
}