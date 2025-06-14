using System;
using System.Threading;
namespace MindfulnessActivity
{
    public class BreathingActivity : Activity
    {
        // Constructor
        public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
            
        }

        public void Run()
        {
            DisplayStartingMessage(); 

            Console.WriteLine(); 

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                // Wait for 2 seconds to simulate breathing in 
                Console.Write("Breathe in...");
                ShowCountDown(2); 
                Console.WriteLine();

                // Check if the end time has been reached before continuing
                // This is to ensure that the activity does not run longer than the specified duration
                if (DateTime.Now >= endTime) break; 

                Console.Write("Breathe out...");
                ShowCountDown(2); 
                Console.WriteLine(); 
                Console.WriteLine(); 
            }

            DisplayEndingMessage();
        }
    }
}