using System; 
using System.Collections.Generic;

namespace ExerciseTracking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n** Welcome to my exercise tracking program ***\n");
          
            // Creates list object for objects derived from the base Activity class
            List<Activity> activities = new List<Activity>();


            activities.Add(new Running(DateTime.Parse("2025-12-06"), 21, 4.0));


            activities.Add(new Cycling(DateTime.Parse("2023-09-10"), 25, 5.0));


            activities.Add(new Swimming(DateTime.Parse("2021-01-05"), 40, 15));


            // Iterate through each object in the list and call the GetSummary function on each object
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
                Console.WriteLine();
            }

        }
    }
}