using System;
using System;
using System.Threading;
using System.Collections.Generic;
namespace MindfulnessActivity

{


    public class ListingActivity : Activity
    {
        
        private List<string> _prompts;

        
        public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
                _prompts = new List<string>
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that have helped you this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?",
                "What are some things you are grateful for?",
                "What are your favorite hobbies and why?",
                "What challenges have you overcome recently?",
                "What skills are you proud of having developed?",
                "List things that make you feel peaceful."
            };
        }

        public void Run()
        {
            DisplayStartingMessage(); 

            Console.WriteLine("\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            Console.WriteLine("Think about the following prompt:");

            string prompt = GetRandomPrompt(); 
            Console.WriteLine($"--- {prompt} ---"); 

            Console.Write("You may begin in: ");
            ShowCountDown(5); 
            Console.WriteLine(); 

            Console.WriteLine("\nStart listing items now (press Enter after each item):");

            List<string> userItems = GetListFromUser(); 

            Console.WriteLine($"\nYou listed {userItems.Count} items.");

            DisplayEndingMessage(); 
        }

        // This method returns a random prompt from the list of prompts.
        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            return _prompts[index];
        }

        // This method collects a list of items from the user until the specified duration is reached.
        public List<string> GetListFromUser()
        {
            List<string> items = new List<string>();
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                
                string item = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(item))
                {
                    items.Add(item);
                }
          
            }
            return items;
        }
    }
}