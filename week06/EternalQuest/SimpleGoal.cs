using System;

namespace EternalQuest

// For goals that are completed onetime.
{
    public class SimpleGoal : Goal
    {
        private bool _isComplete;
        public SimpleGoal(string name, string description, int points) : base(name, description, points)
        {
            _isComplete = false; 
        }
        public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
        {
            _isComplete = isComplete; 
        }
        public override int RecordEvent()
        {

            if (!_isComplete)
            {
                _isComplete = true;
                Console.WriteLine($"Congratulations! You have accomplished '{_shortName}' and earned {_points} points!");
                return _points;
            }
            else
            {
                Console.WriteLine($"You have already completed '{_shortName}'. No additional points awarded.");
                return 0;
            }
        }
        public override bool IsComplete()
        {
            return _isComplete;
        }
        public override string GetDetailsString()
        {
            return base.GetDetailsString();
        }

        public override string GetStringRepresentation()
        {
            // Specifies how the goal data is saved to file
            return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
        }
    }
}
