using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        GoalTracker goalTracker = new GoalTracker();
        string input = "";


        while (input != "6")
        {
            Console.WriteLine("--- Goal Tracker Menu ---");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Please choose one of the menu options");

            input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("The type of Goals are: ");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    string goalType = Console.ReadLine();

                    Goal newGoal = null;
                    switch (goalType)
                    {
                        case "1":
                            newGoal = new SimpleGoal(null, null, 0);
                            newGoal.Create();
                            break;
                        case "2":
                            newGoal = new EternalGoal(null, null, 0);
                            newGoal.Create();
                            break;
                        case "3":
                            newGoal = new ChecklistGoal(null, null, 0, 0, 0);
                            newGoal.Create();
                            break;
                    }

                    if (newGoal != null)
                    {
                        goalTracker.AddGoal(newGoal); 
                        Console.WriteLine("Goal created successfully!");
                    }
                    break;
                case "2":
                    goalTracker.DisplayGoals();
                    goalTracker.DisplayScore();
                    break;
                case "3":
                    goalTracker.SaveGoalsToFile();
                    break;
                case "4":
                    goalTracker.LoadGoalsFromFile();
                    break;
                case "5":
                    Console.WriteLine("Which goal would you like to record an event for?");
                    goalTracker.DisplayGoals(); 
                    Console.Write("Enter the number of the goal: ");
                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        goalTracker.RecordGoalEvent(index - 1); 
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }
                    break;
                case "6":
                    Console.WriteLine("Thank you for using the goal tracker. GoodBye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again");
                    break;
            }
            Console.WriteLine($"\nYour current score is: {goalTracker._totalScore}\n");
        }
    }
}