using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> num_list = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number; 

        do 
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                num_list.Add(number);
            }

        } while (number != 0);

        foreach (int num in num_list)
        {
            Console.WriteLine(num);
        }
        
        Console.WriteLine($"The sum of the list is: {num_list.Sum()}");
        Console.WriteLine($"The average is: {num_list.Average()}");
        Console.WriteLine($"The largest number is: {num_list.Max()}");
    }
}