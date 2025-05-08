using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        //Console.Write("What is the magic number? ");
        //string userInput = Console.ReadLine();
        int magicNumber = randomGenerator.Next(1, 101);

        Console.Write("What is your guess? ");
        string userGuess = Console.ReadLine();
        int guess = int.Parse(userGuess);

        if (guess == magicNumber)
        {
            Console.WriteLine("You guessed it!");
        }
        else if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("Lower");
        }

        string playAgain = "";

        while (playAgain != "no")
        {
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                userGuess = Console.ReadLine();
                guess = int.Parse(userGuess);
                if (guess == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higer");
                }
                else
                {
                    Console.WriteLine("Lower");
                }

            }
            Console.WriteLine("Would you like to play again? (yes/no) ");
            playAgain = Console.ReadLine();
            
            if (playAgain == "yes")
            {
                magicNumber = randomGenerator.Next(1, 101);
                guess = 0;
            }
            else if (playAgain == "no")
            {
                Console.WriteLine("Thanks for playing!");
            }
            else
            {
                Console.WriteLine("Please enter yes or no.");
            }
        }
    }
}

