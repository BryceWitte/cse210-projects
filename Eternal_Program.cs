using System;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Eternal Quest!");

            // Load goals and scores from file
            List<Goal> goals = LoadGoals();
            int score = LoadScore();

            while (true)
            {
                // Display options
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. View Goals");
                Console.WriteLine("2. Add Goal");
                Console.WriteLine("3. Record Event");
                Console.WriteLine("4. Quit");

                // Get user input
                Console.Write("Enter option number: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int option))
                {
                    switch (option)
                    {
                        case 1:
                            // Display list of goals
                            DisplayGoals(goals);
                            break;
                        case 2:
                            // Add a new goal
                            AddGoal(goals);
                            break;
                        case 3:
                            // Record an event
                            RecordEvent(goals, ref score);
                            break;
                        case 4:
                            // Quit and save goals and score to file
                            SaveGoals(goals);
                            SaveScore(score);
                            Console.WriteLine("Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }

        static List<Goal> LoadGoals()
        {
            List<Goal> goals = new List<Goal>();
            if (File.Exists("goals.txt"))
            {
                string[] lines = File.ReadAllLines("goals.txt");
                foreach (string line in lines)
                {
                    Goal goal = Goal.FromString(line);
                    if (goal != null)
                    {
                        goals.Add(goal);
                    }
                }
            }
            return goals;
        }

        static int LoadScore()
        {
            if (File.Exists("score.txt"))
            {
                string line = File.ReadAllText("score.txt");
                if (int.TryParse(line, out int score))
                {
                    return score;
                }
            }
            return 0;
        }

        static void SaveGoals(List<Goal> goals)
        {
            List<string> lines = new List<string>();
            foreach (Goal goal in goals)
            {
                lines.Add(goal.ToString());
            }
            File.WriteAllLines("goals.txt", lines);
        }

        static void SaveScore(int score)
        {
            File.WriteAllText("score.txt", score.ToString());
        }

        static void DisplayGoals(List<Goal> goals)
        {
            Console.WriteLine("\nGoals:");
            foreach (Goal goal in goals)
            {
                Console.Write($"- {goal.Name} ");
                if (goal is SimpleGoal simpleGoal)
                {
                    Console.WriteLine(simpleGoal.IsCompleted ? "[X]" : "[ ]");
                }
                else if (goal is EternalGoal eternalGoal)
                {
                    Console.WriteLine($"({eternalGoal.Count}x) {eternalGoal.Value * eternalGoal.Count}");
                }
                else if (goal is ChecklistGoal checklistGoal)
                {
                    Console.WriteLine($"Completed {checklistGoal.Count}/{checklistGoal.TargetCount} times " +
                        $"({checklistGoal.Value * checklistGoal.Count}/{checklistGoal.TargetCount * checklistGoal.Value})");
                }
            }
            Console.WriteLine($"Total score: {CalculateScore(goals)}");
        }

        static void AddGoal(List<Goal> goals)
    }
}
