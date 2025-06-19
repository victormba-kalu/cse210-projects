using System; 
namespace ExerciseTracking
{
    // Creates the Running Class from the Base activity class
    public class Running : Activity
    {
        private double _distance;

        // Initialize Constructor with values from the base class and additional values
        public Running(DateTime date, int minutes, double distance) : base(date, minutes)
        {
            _distance = distance;
        }

        // Override the GetDistance, GetSpeed and GetPace methods from the base class
        public override double GetDistance()
        {
            return _distance;
        }

        public override double GetSpeed()
        {
            if (Minutes == 0) return 0;
            return (_distance / Minutes) * 60;
        }

        public override double GetPace()
        {
            if (_distance == 0) return 0;
            return Minutes / _distance;
        }
    }
}
