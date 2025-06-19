using System; 

namespace ExerciseTracking
{ 
    // Create Swimming class from the Activity class
    public class Swimming : Activity
    {
        private int _laps;

        // Initialize constructor with values from the base and include additional values
        public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
        {
            _laps = laps;
        }

        // Override GetDistance, GetSpeed, and GetPace from the base class
        // This is needful so that these methods can be implemented based on the concept of their classes
        public override double GetDistance()
        {
            return _laps * 50 / 1000.0 * 0.62;
        }

        public override double GetSpeed()
        {
            if (Minutes == 0) return 0;
            return (GetDistance() / Minutes) * 60;
        }

        public override double GetPace()
        {
            double distance = GetDistance();
            if (distance == 0) return 0;
            return Minutes / distance;
        }
    }
}
