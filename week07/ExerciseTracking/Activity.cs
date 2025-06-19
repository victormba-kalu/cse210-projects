using System; 

namespace ExerciseTracking
{
    public abstract class Activity
    {
        private DateTime _date;    
        private int _minutes;     

        public Activity(DateTime date, int minutes)
        {
            _date = date;
            _minutes = minutes;
        }

        public DateTime Date => _date;
        public int Minutes => _minutes;

        public abstract double GetPace();
        public abstract double GetDistance(); 
        public abstract double GetSpeed();   
             

        // Virtual method to generate a summary string for the activity.
        // This method provides a default formatted string using the abstract methods,
        // demonstrating polymorphism. It can be overridden if a derived class
        // needs a significantly different summary format, though generally it won't be needed
        // if the abstract methods provide the correct values.
        public virtual string GetSummary()
        {
            
            string activityType = GetType().Name; 
            string formattedDate = _date.ToString("dd MMM yyyy"); 

            return $"{formattedDate} {activityType} ({_minutes} min) - " +
                   $"Distance {GetDistance():0.0} miles, " + 
                   $"Speed {GetSpeed():0.0} mph, " +
                   $"Pace: {GetPace():0.0} min per mile";
        }
    }
}
