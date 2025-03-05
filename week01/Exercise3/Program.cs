using System;

class Program
{
    static void Main(string[] args)
    {
        string playing;

        Console.WriteLine("Welcome to the number guessing game!  How quickly can you guess the number?");

        do {
            Random randomGenerator = new Random();
            int magic_num = randomGenerator.Next(1, 100);
            int attempts = 0;
            Console.WriteLine("A random number has been generated!");

            Console.Write("Please try to guess the number: ");
            int guess = int.Parse(Console.ReadLine());

            attempts++;

            do {
                if (guess > magic_num)
                {
                    Console.WriteLine("Lower");
                    Console.Write("Please try to guess the number: ");
                    guess = int.Parse(Console.ReadLine());
                    attempts++;
                }
                else if (guess < magic_num)
                {
                    Console.WriteLine("Higher");
                    Console.Write("Please try to guess the number: ");
                    guess = int.Parse(Console.ReadLine());
                    attempts++;
                }
            } while (guess != magic_num);

            Console.WriteLine($"You guessed it! It took you {attempts} guesses.");
            Console.Write("Would you like to play again? (yes or no): ");
            playing = Console.ReadLine();

            } while (playing == "yes");
    }
}