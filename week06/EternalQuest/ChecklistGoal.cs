using System;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    { 
        // Implements encapsulation by restricting access using the keyword "private"
        private int _amountCompleted; 
        private int _target;        
        private int _bonus;         

        public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
        {
            _target = target;
            _bonus = bonus;
            _amountCompleted = 0; 
        }
       
        public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base(name, description, points)
        {
            _target = target;
            _bonus = bonus;
            _amountCompleted = amountCompleted; 
        }

        public void RestoreProgress(int amountCompleted)
        {
            _amountCompleted = amountCompleted;
        }

        public override int RecordEvent()
        {
            _amountCompleted++; 
            int earnedPoints = _points; 

            if (IsComplete())
            {
                earnedPoints += _bonus; 
                Console.WriteLine($"Congratulations! You have completed '{_shortName}' and earned {_points} points, plus a bonus of {_bonus} points!");
            }
            else
            {
                Console.WriteLine($"Congratulations! You have accomplished '{_shortName}' and earned {_points} points!");
            }
            return earnedPoints;
        }

        public override bool IsComplete()
        {
            return _amountCompleted >= _target;
        }

        public override string GetDetailsString()
        {
            string checkbox = IsComplete() ? "[X]" : "[ ]";
            // display progress of the goal. 
            return $"{checkbox} {_shortName} ({_description}) -- Currently completed {_amountCompleted}/{_target} times";
        } 
        public override string GetStringRepresentation()
        {
            // Specifies the manner in which this goal is saved into a file
            return $"ChecklistGoal:{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
        }
    }
}
