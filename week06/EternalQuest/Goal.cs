using System; 
using System.Collections.Generic; 
using System.IO; 
using System.Linq; 

namespace EternalQuest
{
    // Base class for the EternalQuest project
    public abstract class Goal
    {
        protected string _shortName;
        protected string _description;
        protected int _points;

        public Goal(string name, string description, int points)
        {
            _shortName = name;
            _description = description;
            _points = points;
        }

        public string ShortName => _shortName;
        public string Description => _description;
        public int Points => _points;

        public abstract int RecordEvent();

        public abstract bool IsComplete();

        public virtual string GetDetailsString()
        {
            // I use the ternary operator to assign a value to the checkbox depending on the return value of the IsComplete method. 
            string checkbox = IsComplete() ? "[X]" : "[ ]";
            return $"{checkbox} {_shortName} ({_description})";
        }

        public abstract string GetStringRepresentation();

        public static Goal CreateGoalFromString(string goalString)
        {
            // I split the goalString at the colon. Split return a list 
            // and I use list indices to return parts of the list and assign them to variables
            string[] parts = goalString.Split(":");
            string goalType = parts[0];
            string[] details = parts[1].Split(",");

            string name = details[0];
            string description = details[1];
            int points = int.Parse(details[2]);


            if (goalType == "SimpleGoal")
            {
                bool isComplete = bool.Parse(details[3]);
                return new SimpleGoal(name, description, points, isComplete);
            }
            else if (goalType == "EternalGoal")
            {
                return new EternalGoal(name, description, points);
            }
            else if (goalType == "ChecklistGoal")
            {
                int amountCompleted = int.Parse(details[3]);
                int target = int.Parse(details[4]);
                int bonus = int.Parse(details[5]);
                return new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
            }
            else
            {
                // Null check 
                throw new ArgumentException("Unknown goal type in string representation. Not able to create goal.");
            }
        }
    }
}
