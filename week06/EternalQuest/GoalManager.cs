using System;
using System.Collections.Generic;
using System.IO; 

namespace EternalQuest
{
    // Manages most of the interractivity of the program
    public class GoalManager
    {
        // Creates a list of goal objects
        // When we call this object's method, 
        // if overriden, the method would function based on the context of the derived class
        private List<Goal> _goals;
        private int _score;

        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }

        public void Start()
        {
            int choice = 0;

            while (choice != 6)
            {
                DisplayPlayerInfo();
                Console.WriteLine("\nMenu Options:");
                Console.WriteLine("  1. Create New Goal");
                Console.WriteLine("  2. List Goals");
                Console.WriteLine("  3. Save Goals");
                Console.WriteLine("  4. Load Goals");
                Console.WriteLine("  5. Record Event");
                Console.WriteLine("  6. Quit");
                Console.Write("Select a choice from the menu: ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    if (choice == 1)
                    {
                        CreateGoal();
                    }
                    else if (choice == 2)
                    {
                        ListGoalDetails();
                    }
                    else if (choice == 3)
                    {
                        SaveGoals();
                    }
                    else if (choice == 4)
                    {
                        LoadGoals();
                    }
                    else if (choice == 5)
                    {
                        RecordEvent();
                    }
                    else if (choice == 6)
                    {
                        Console.WriteLine("Exiting program. Goodbye!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
                Console.WriteLine();
            }
        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"You have {_score} points.");
        }


        public void ListGoalNames()
        {
            Console.WriteLine("\nYour Goals:");
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals created yet.");
                return;
            }
            // Display the short-name for each goal inside the list object only
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].ShortName}");
            }
        }

        public void ListGoalDetails()
        {
            Console.WriteLine("\nThe goals are:");
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals created yet. Create some goals to see them here.");
                return;
            }
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
        }

        public void CreateGoal()
        {
            Console.WriteLine("\nThe types of Goals are:");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            string goalTypeChoice = Console.ReadLine();

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            Goal newGoal = null;

            if (goalTypeChoice == "1")
            {
                newGoal = new SimpleGoal(name, description, points);
            }
            else if (goalTypeChoice == "2")
            {
                newGoal = new EternalGoal(name, description, points);
            }
            else if (goalTypeChoice == "3")
            {
                Console.Write("What is the target amount for this goal? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it this many times? ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, target, bonus);
            }
            else
            {
                Console.WriteLine("Invalid goal type. No goal created.");
                return;
            }

            _goals.Add(newGoal);
            Console.WriteLine($"Goal '{name}' created successfully!");
        }

        public void RecordEvent()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("You have no goals yet. Please, create one");
                return;
            }

            Console.WriteLine("\nThe goals are:");
            ListGoalNames();

            Console.Write("Please, indicate the goal you accomplished ");
            if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex > 0 && goalIndex <= _goals.Count)
            {   // _goals stores a list of goal objects
                // So when the RecordEvent method is called, it's implemented according to the context of the derived clas
                int pointsEarned = _goals[goalIndex - 1].RecordEvent();
                _score += pointsEarned;
                Console.WriteLine($"\nYou now have {_score} points.");
            }
            else
            {
                Console.WriteLine("Invalid goal number. Please select a valid goal from the list.");
            }
        }

        public void SaveGoals()
        {
            Console.Write("Please, enter filename ");
            string filename = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(_score);

                foreach (Goal goal in _goals)
                {

                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals saved successfully!");
        }
        public void LoadGoals()
        {
            Console.Write("Please, enter filename ");
            string filename = Console.ReadLine();

            if (!File.Exists(filename))
            {
                Console.WriteLine($"Error: File '{filename}' not found.");
                return;
            }

            string[] lines = File.ReadAllLines(filename);

            if (lines.Length == 0)
            {
                Console.WriteLine("Empty file. Please, load goals");
                return;
            }


            _score = int.Parse(lines[0]);
            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                try
                {

                    Goal loadedGoal = Goal.CreateGoalFromString(line);
                    _goals.Add(loadedGoal);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error loading goal from line: '{line}' - {ex.Message}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error parsing data from line: '{line}' - {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected error occurred loading goal from line: '{line}' - {ex.Message}");
                }
            }
            Console.WriteLine("Goals loaded successfully!");
            
            // After loading the goals, display a brief information about the goal
            Console.WriteLine("\n--- Loaded Goals Overview ---");
            if (_goals.Count == 0)
                {
                    Console.WriteLine("No goals were found in the loaded file.");
                }
            else
                {
                    for (int i = 0; i < _goals.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
                    }
                }
    
        }
    }
}
