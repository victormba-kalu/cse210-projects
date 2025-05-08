using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter your score: ");
        string userInput = Console.ReadLine();

        int score = int.Parse(userInput);
        string letter;
        int remainder;

        if (score >= 90)
        {
            //Console.WriteLine("Your grade is A.");
            letter = "A";
            remainder = score % 10;
            
            if (score == 100)
            {
                letter += "";
            }
            else if (remainder < 3)
            {
                letter += "-";
            }

        }
        else if (score >= 80)
        {
            //Console.WriteLine("Your grade is B.");
            letter = "B";
            remainder = score % 10;
            if (remainder >= 7)
            {
                letter += "+";
            }
            else
            {
                letter += "-";
            }
        }

        else if (score >= 70)

        {
            //Console.WriteLine("Your grade is C.");
            letter = "C";
            remainder = score % 10;
            if (remainder >= 7)
            {
                letter += "+";
            }
            else
            {
                letter += "-";
            }
        }
        else if (score >= 60)
        {
            //Console.WriteLine("Your grade is D.");
            letter = "D";
            remainder = score % 10;
            if (remainder >= 7)
            {
                letter += "+";
            }
            else
            {
                letter += "-";
            }
        }

        else
        {
            //Console.WriteLine("Your grade is F.");
            letter = "F";

        }

        if (score >= 70)
        { 
            Console.WriteLine($"Congratulations! Your grade is {letter}. You passed the course.");
        }
        else
        {
            Console.WriteLine($"Sorry! Your grade is {letter}. You failed the course. Please, try again.");
        }

        

    }
}