using System; 

namespace ExerciseTracking
{
    // The Cyling class inherited from the Activity class
    public class Cycling : Activity
    {
        private double _speed; 

        // Initialize Constructor with values unique to this class and also from the base class
        public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
        {
            _speed = speed;
        }

        // Override GetDistance, GetSpeed, and GetPace inherited from Activity class
        public override double GetDistance()
        {
            return (_speed * Minutes) / 60;
        }

        public override double GetSpeed()
        {
            return _speed;
        }

        public override double GetPace()
        {
            if (_speed == 0) return 0;
            return 60 / _speed;
        }
    }
}
