using System.Runtime.CompilerServices;

public class GoalTracker
{
    private List<Goal> _goals = new List<Goal>();
    public int _totalScore = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to display yet. Create some goals first!");
            return;
        }

        Console.WriteLine("\n--- Your Goals ---");
        for (int i = 0; i < _goals.Count; i++) 
        {
            Goal goal = _goals[i];
            
            Console.WriteLine($"{i + 1}. {goal.GetDetails()}");
        }
        Console.WriteLine("------------------\n");
    }
    public void DisplayScore()
    {
        Console.WriteLine(_totalScore);
    }
    public void RecordGoalEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];
            bool wasComplete = goal.isComplete();

            goal.RecordEvent();

            bool isNowComplete = goal.isComplete();
            if (!wasComplete && isNowComplete)
            {
                _totalScore += goal.Points;
                Console.WriteLine($"Points added! Total score: {_totalScore}");
            }
            else if (wasComplete)
            {
                Console.WriteLine("Goal already completed; no points added.");
            }
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void SaveGoalsToFile()
    {
        Console.WriteLine("Please enter a filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_totalScore);

            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.SaveString());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoalsFromFile()
    {
        Console.WriteLine("Please enter the filename to load: ");
        string filename = Console.ReadLine();

        
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found. Make sure the filename is correct.");
            return; 
        }

        
        _goals.Clear();
        _totalScore = 0;

        try
        {
            
            using (StreamReader reader = new StreamReader(filename))
            {
                
                string scoreLine = reader.ReadLine();
                _totalScore = int.Parse(scoreLine); 

                string line;
                
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':'); 
                    string goalType = parts[0];       

                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    bool status = bool.Parse(parts[4]);

                    Goal loadedGoal = null;

                    switch (goalType)
                    {
                        case "SimpleGoal":
                            loadedGoal = new SimpleGoal(name, description, points);
                            loadedGoal._status = status; 
                            break;

                        case "Eternal Goal": 
                            loadedGoal = new EternalGoal(name, description, points);
                            loadedGoal._status = status; 
                            break;

                        case "Checklist Goal": 
                            int targetCount = int.Parse(parts[5]);   
                            int currentCount = int.Parse(parts[6]); 
                            loadedGoal = new ChecklistGoal(name, description, points, targetCount, currentCount);
                            loadedGoal._status = status; 
                            break;
                    }

                    if (loadedGoal != null)
                    {
                        _goals.Add(loadedGoal); 
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully!");
            DisplayGoals(); 
            Console.WriteLine($"Your total score is now: {_totalScore}");
        }
        catch (Exception ex) 
        {
            Console.WriteLine($"An error occurred while loading goals: {ex.Message}");
            Console.WriteLine("Please ensure the file is correctly formatted.");
        }
    }


}