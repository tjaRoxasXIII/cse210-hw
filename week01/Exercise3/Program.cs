using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_num = randomGenerator.Next(1, 100);

        Console.Write("Please try to guess the number: ");
        int guess = int.Parse(Console.ReadLine());

        do {
            if (guess > magic_num)
            {
                Console.WriteLine("Lower");
                Console.Write("Please try to guess the number: ");
                guess = int.Parse(Console.ReadLine());
            }
            else if (guess < magic_num)
            {
                Console.WriteLine("Higher");
                Console.Write("Please try to guess the number: ");
                guess = int.Parse(Console.ReadLine());
            }
        } while (guess != magic_num);

        Console.WriteLine("You guessed it!");

    }
}