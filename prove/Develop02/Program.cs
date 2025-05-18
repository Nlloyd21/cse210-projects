using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        List<string> prompts = new List<string>
        {
            "What was the best part about your day?", "Who helped you have a good day?", "What was the hardest part about today?", "If I had one thing I can do over today, what would it be?", "What goal do you have tomorrow?", "What act of service did you perform today?", "Did you discover anything new or learn something interesting  today?"
        }
        ;

        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("Welcome to the Journal Program. Please choose one of the options below");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = GetRandomPrompt(prompts);
                    journal.AddEntry(prompt);
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    journal.SaveToFile();
                    break;
                case "4":
                    journal.LoadFromFile();
                    break;
                case "5":
                    quit = true;
                    Console.WriteLine("Goodbye! Have a great day!");
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Please select again");
                    break;


            }

        }
        static string GetRandomPrompt(List<string> prompts)
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
    
}