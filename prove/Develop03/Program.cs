using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("D&C", 6, 36, "Look unto me in every thought; doubt not fear not");
        Console.Clear();
        scripture.Display();
        Console.WriteLine("Press enter to continue, or type 'quit' to end");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;
            if (!scripture.HideRandomWord())
            {
                Console.WriteLine("You have finsihed memorizing the scripture");
                break;
            }


            Console.Clear();
            scripture.Display();
            Console.WriteLine("Press enter or type 'quit' to end");
        }

    }
}