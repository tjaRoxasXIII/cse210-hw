// Extra Stretch requirements.  Made the application only hide 'unhidden' words by adding extra function UnhiddenWordsRemaining to Scripture class.
using System;

class Program
{
    static void Main(string[] args)
    {
        string singleVerse = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        string multiVerse = "Trust in the Lord with all thine heart; and lean not unto thine own understanding; In all thy ways acknowledge him, and he shall direct thy paths.";
        
        Random random = new Random();
        string[] values = { singleVerse, multiVerse };
        int randomIndex = random.Next(values.Length);
        string chosenValue = values[randomIndex];

        Scripture scripture = new Scripture(new Reference("John", 3,16), chosenValue);
        Console.WriteLine(scripture.GetDisplayText());

        while (true)
        {
            Console.WriteLine("Press 'Enter' to hide the next set of words: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            if (scripture.IsCompletelyHidden() == false)
            {
                Console.Clear();
                scripture.HideRandomWords(5);
                Console.WriteLine(scripture.GetDisplayText());
            }
            else
            {
                Console.WriteLine("All words are hidden.");
                break;
            }
        }

        Console.WriteLine("Goodbye!");

    }

}