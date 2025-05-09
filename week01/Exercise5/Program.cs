using System;

class Program
{
    static void Main(string[] args)
    {
        // call the DisplayWelcome function
        DisplayWelcome();

        // call the PromptUserName function
        // store the result in a variable so it can be used later
        string name = PromptUserName();

        // call the PromptUserNumber function
        // store the result in a variable so it can be used later
        int userNumber = PromptUserNumber();

        // call the SquareNumber function
        // store the result in a variable so it can be used later
        int square = SquareNumber(userNumber);

        // call the DisplayResult function  
        // pass the userName and squaredNumber variables above to the function
        DisplayResult(name, square);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();
        // Console.WriteLine(userName);
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userNumber = Console.ReadLine();
        int favNumber = int.Parse(userNumber);
        return favNumber;
    }

    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;
        return squaredNumber;
    }

    static void DisplayResult(string userName, int squaredNumber)
    {
        
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }
}