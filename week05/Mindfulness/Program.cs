
// In order to exceed requirements, I've keept a log of how many times activities were performed
// by using a dictionary to store the activity names and their counts. The dictionary is initialized
// in the main method in line 17 and updated each time an activity is run. When the user chooses to quit, a summary
// of the activities is displayed, showing how many times each activity was performed.

using System;
using System.Collections.Generic; 
using System.Threading;
namespace MindfulnessActivity
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Dictionary<string, int> activityLog = new Dictionary<string, int>();
            activityLog.Add("Breathing Activity", 0);
            activityLog.Add("Reflecting Activity", 0);
            activityLog.Add("Listing Activity", 0);
          

            string choice = "";
            while (choice != "4") 
            {
                Console.Clear();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("  1. Start breathing activity");
                Console.WriteLine("  2. Start reflecting activity");
                Console.WriteLine("  3. Start listing activity");
                Console.WriteLine("  4. Quit");
                Console.Write("Select a choice from the menu: ");
                choice = Console.ReadLine();

                Activity currentActivity = null;


                // Based on the user's choice, instantiate the appropriate activity class
                // and update th1e activity log.
                if (choice == "1")
                {
                    currentActivity = new BreathingActivity();
                    activityLog["Breathing Activity"]++;
                }
                else if (choice == "2")
                {
                    currentActivity = new ReflectingActivity();
                    activityLog["Reflecting Activity"]++;
                }
                else if (choice == "3")
                {
                    currentActivity = new ListingActivity();
                    activityLog["Listing Activity"]++;
                }
                else if (choice == "4")
                {
                    Console.WriteLine("\nThank you for using the Mindfulness Program!");
                    Console.WriteLine("Activity Summary:");
                    foreach (var entry in activityLog)
                    {
                        Console.WriteLine($"  {entry.Key}: {entry.Value} session(s)");
                    }
                    Thread.Sleep(3000);

                }
                else
                {
                    Console.WriteLine("\nInvalid choice. Please enter a number between 1 and 4.");
                    Thread.Sleep(2000);
                    continue;
                }

                // If a valid activity was selected, run it
                // and update the activity log. Each class runs it's unique run method
                if (currentActivity != null)
                {
                    if (currentActivity is BreathingActivity breathingActivity)
                    {
                        breathingActivity.Run();
                    }
                    else if (currentActivity is ReflectingActivity reflectingActivity)
                    {
                        reflectingActivity.Run();
                    }
                    else if (currentActivity is ListingActivity listingActivity)
                    {
                        listingActivity.Run();
                    }
                }
            }
        }
    }
}