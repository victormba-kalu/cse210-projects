// This is the base class that contains the shared functionality for all mindfulness activities.

using System;
using System.Threading;
using System.Collections.Generic; // Added for potential future use or derived classes
namespace MindfulnessActivity

{
    

    public class Activity
    {
       
        protected string _name;
        protected string _description;
        protected int _duration;
        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
            _duration = 0; 
        }

        // Method to display the common starting message for all activities
        public void DisplayStartingMessage()
        {
            Console.Clear(); 
            Console.WriteLine($"Welcome to the {_name} Activity.");
            Console.WriteLine();
            Console.WriteLine(_description);
            Console.WriteLine();

            Console.Write("How long, in seconds, would you like for your session? ");
            string input = Console.ReadLine();
            _duration = int.Parse(input);

            Console.Clear();
            Console.WriteLine("Get ready to begin...");
            ShowSpinner(5); 
        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Well done!!");
            ShowSpinner(3); 
            Console.WriteLine($"You have completed the {_name} Activity for {_duration} seconds.");
            ShowSpinner(5);
        }

        // Whenever the activity pauses, I use the show spinner method to indicate a wait time.
        public void ShowSpinner(int seconds)
        {
            List<string> spinnerFrames = new List<string> { "|", "/", "-", "\\" };
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds);
            int i = 0;
            
            // Loop through the spinner frames until the end time is reached
            while (DateTime.Now < endTime)
            {
                string frame = spinnerFrames[i % spinnerFrames.Count];
                Console.Write(frame);
                Thread.Sleep(250);
                Console.Write("\b \b");

                i++;
            }
        }
        
        // This method is used to show a countdown in the console.
        public void ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);

                if (i >= 10)
                {
                    Console.Write("\b\b  \b\b");
                }
                else
                {
                    Console.Write("\b \b");
                }
            }
        }
    }
}