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

        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {max}");
    }
}