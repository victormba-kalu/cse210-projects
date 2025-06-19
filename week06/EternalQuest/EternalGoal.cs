using System; 

namespace EternalQuest
// Goals that never really complete
{

    public class EternalGoal : Goal
    {
        // Instructor properties already initialized from base Goal class so the EternalGoal instructor is empty
        public EternalGoal(string name, string description, int points) : base(name, description, points)
        {

        }
        
        public EternalGoal(string name, string description, int points, bool isCompleteDummy) : base(name, description, points)
        {

        }

        public override int RecordEvent()
        {
            Console.WriteLine($"Congratulations! You have accomplished '{_shortName}' and earned {_points} points!");
            return _points; 
        }

        public override bool IsComplete()
        {
            return false; 
        }

        public override string GetDetailsString()
        {
            return base.GetDetailsString();
        }

        public override string GetStringRepresentation()
        {
            // Specifies how the data is saved to file
            return $"EternalGoal:{_shortName},{_description},{_points},False";
        }
    }
}
