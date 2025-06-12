using System;
namespace StudentAssignmentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Student Assignment System!");
            Console.WriteLine("------------------------------------------\n");

            // Create an instance of Assignment
            Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");

            // Display the summary of the assignment

            Console.WriteLine(assignment.GetSummary());

            // Create an instance of MathAssignment
            MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");


            // Display the summary of the math assignment
            Console.WriteLine("\n----------Math Assignment Summary:");
            Console.WriteLine(mathAssignment.GetSummary());

            // Display the homework list for the math assignment
            Console.WriteLine(mathAssignment.GetHomeworkList());

            // Create an instance of WritingAssignment
            WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

            // Display the summary of the writing assignment
            Console.WriteLine("\n----------Writing Assignment Summary:");
            Console.WriteLine(writingAssignment.GetSummary());
            Console.WriteLine(writingAssignment.GetWritingInformation());
            Console.WriteLine();
        }
    }
}