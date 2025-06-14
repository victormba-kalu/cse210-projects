using System;
using System;
using System.Threading;
using System.Collections.Generic; 
namespace MindfulnessActivity

{
    

    public class ListingActivity : Activity
    {
        private List<string> _prompts;
        private int _count; 
        private Random _random;

        // Constructor
        public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
            _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
            _count = 0; 
            _random = new Random();
        }

     
        public void Run()
        {
            DisplayStartingMessage(); 

            Console.Clear();
            Console.WriteLine("Ponder on the following prompt:");
            Console.WriteLine();
            DisplayPrompt(); 
            Console.WriteLine();

            Console.WriteLine("You may begin listing items in: ");
            ShowCountDown(5); 

            Console.WriteLine(); 
            Console.WriteLine("Start listing items now (press Enter after each item):");

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);
            _count = 0; 
        
            while (DateTime.Now < endTime)
            {
                if (Console.KeyAvailable) 
                {
                    string item = Console.ReadLine();
                    
                    _count++;
                }
            }

            Console.WriteLine($"\nYou listed {_count} items!");
            ShowSpinner(3); 

            DisplayEndingMessage(); 
        }

        private void DisplayPrompt()
        {
            string prompt = GetRandomPrompt();
            Console.WriteLine($"--- {prompt} ---");
        }

     
        private string GetRandomPrompt()
        {
            int index = _random.Next(0, _prompts.Count);
            return _prompts[index];
        }
    }
}