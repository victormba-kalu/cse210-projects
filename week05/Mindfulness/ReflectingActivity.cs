using System;
using System.Threading;
using System.Collections.Generic; 
using System.Linq; 

namespace MindfulnessActivity
{
    
    public class ReflectingActivity : Activity
    {
        private List<string> _prompts;
        private List<string> _questions;
        private Random _random;

        // Constructor
        public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
        {
            _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

            _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

            _random = new Random(); 
        }

     
        public void Run()
        {
            DisplayStartingMessage(); 

            Console.Clear();
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine();
            DisplayPrompt(); 
            Console.WriteLine();
            Console.WriteLine("When you have thought about the prompt, press enter to continue.");
            Console.ReadLine(); 

            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
            Console.Write("You may begin in: ");
            ShowCountDown(5); 

            Console.Clear(); 

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                DisplayQuestion(); 
                ShowSpinner(5); 
                Console.WriteLine(); 
                if (DateTime.Now >= endTime) break; 
            }

            DisplayEndingMessage(); 
        }

       
        private void DisplayPrompt()
        {
            string prompt = GetRandomPrompt();
            Console.WriteLine($"--- {prompt} ---");
        }

     
        private void DisplayQuestion()
        {
            string question = GetRandomQuestion();
            Console.Write($"> {question} "); 
        }

        
        private string GetRandomPrompt()
        {
            int index = _random.Next(0, _prompts.Count);
            return _prompts[index];
        }

       
        private string GetRandomQuestion()
        {
            int index = _random.Next(0, _questions.Count);
            return _questions[index];
        }
    }
}