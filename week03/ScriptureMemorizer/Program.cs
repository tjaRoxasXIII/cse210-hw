using System;

class Program
{
    static void Main(string[] args)
    {
        string scripText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture scripture = new Scripture(new Reference("John", 3,16), scripText);
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