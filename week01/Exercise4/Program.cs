using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter a number: ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        List<int> numbers = new List<int>();
        int sum = 0;
        while (number != 0)
        {

            numbers.Add(number);
            Console.Write("Enter a number: ");
            userInput = Console.ReadLine();
            number = int.Parse(userInput);
        }
        // Calculate the sum of the numbers
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Calculate the average of the numbers
        int listSize = numbers.Count;
        // cast the sum to double to avoid integer division
        // I use double instead of float because double is more precise and peformance here is not a concern
        double average = (double)sum / listSize;

        // Find the maximum number
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        // Find the smallest positive number
        int smallestPostive = numbers[0];
        foreach (int num in numbers)
        {
            if (num > 0 && num < smallestPostive)
            {
                smallestPostive = num;
            }
        }

        //Sort the list of numbers
        numbers.Sort();



        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {max}");
        Console.WriteLine($"The smallest positive number is {smallestPostive}");
        Console.WriteLine("The sorted list is: ");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}