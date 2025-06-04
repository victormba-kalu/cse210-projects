// To exceed requirments, I have done the following:
// I included a scripture library to store multiple scriptures in my program.cs file - this file
// After my program starts, I select scriptures randomly from the scripture library
// I only select words that are currentyly unhidden to hide, that is using the Scriptures.hideRandomWords method
// If the user enters anything other than "quit" or hitting the enter key, I handle it smoothly using an else block that prompts the user to do the right thing
// And finally, I have also made sure that words are hidden correctly without any extra punctuation marks. For example, one of my scriptures is the popular John 3: 16
// After I perform a split on the scripture, I make sure that for words such as "world," and others ending with a ".", the punctuation marks are not passed into the word object.
// This is done using a method called: CleanWord
using System;
using System.Collections.Generic;
using System.Linq; 

namespace ScriptureMemorizer
// I'm using namespaces to group all my programs together. It's not really necessary here since this is a small project but I like the concept

{
    class Program
    {
        static void Main(string[] args)
        {

            List<Scripture> scriptureLibrary = new List<Scripture>
            {
                new Scripture(
                    new Reference("John", 3, 16),
                    "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
                ),

                new Scripture(
                    new Reference("1 Nephi", 3, 7),
                    "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."
                ),
                new Scripture(
                    new Reference("Proverbs", 3, 5, 6),
                    "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
                ),

                new Scripture(
                    new Reference("Ether", 12, 4),
                    "Wherefore, whoso believeth in God might with surety hope for a better world, yea, even a place at the right hand of God, which hope cometh of faith, maketh an anchor to the souls of men, which would make them sure and steadfast, always abounding in good works, being led to glorify God."
                ),
                new Scripture(
                    new Reference("Philippians", 4, 13),
                    "I can do all things through Christ which strengtheneth me."
                ),

                new Scripture(
                    new Reference("Ether", 12, 26),
                    "And when I had said this, the Lord space unto me, saying: Fools mock, but they shall mourn; and my grace is sufficient for the meek, that they shall take no advantage of your weakness;"

                ),

                new Scripture(
                    new Reference("Romans", 8, 28),
                    "And we know that all things work together for good to them that love God, to them who are the called according to his purpose."
                ),

                new Scripture(
                    new Reference("Ether", 12, 27),
                    "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them."
                )
            };


            Random random = new Random();
            Scripture currentScripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

            Console.WriteLine("Welcome to the Scripture Memorizer!\n");


            while (!currentScripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(currentScripture.GetDisplayText());
                Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");

                string input = Console.ReadLine()?.ToLower().Trim();

                if (input == "quit")
                {
                    break;
                }
                else if (string.IsNullOrEmpty(input))
                {


                    int wordsToHide = random.Next(3, 6);
                    currentScripture.HideRandomWords(wordsToHide);
                }

                else
                {
                    Console.WriteLine("Invalid input. Please press Enter or type 'quit'.");
                    System.Threading.Thread.Sleep(1000);
                }
            }


            Console.Clear();
            Console.WriteLine(currentScripture.GetDisplayText());
            if (currentScripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden! You've mastered this scripture!");
            }
            else
            {
                Console.WriteLine("\nExiting program. Keep practicing!");
            }
            Console.WriteLine("Press any key to close the application.");
            Console.ReadKey();
        }
    }
}