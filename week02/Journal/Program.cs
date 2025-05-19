using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();

        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine();
            Console.WriteLine("===================================");
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                anEntry = new Entry();
                anEntry._date = DateTime.Now.ToShortDateString();
                anEntry._time = DateTime.Now.ToString("HH:mm tt");
                anEntry._promptText = anEntry._promptGenerator.GetRandomPrompt();
                Console.WriteLine(anEntry._promptText);
                Console.Write("> ");
                anEntry._entryText = Console.ReadLine();
                theJournal.AddEntry(anEntry);
            }
            else if (choice == 2)
            {
                theJournal.DisplayAll();
            }
            else if (choice == 3)
            {
                theJournal.LoadFromFile("journal.txt");
            }
            else if (choice == 4)
            {
                theJournal.SaveToFile("journal.txt");
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}