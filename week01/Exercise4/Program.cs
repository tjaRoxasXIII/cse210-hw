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

        int spn = num_list.Where(t => t > 0).Min();

        if (spn > 0)
        {
            Console.WriteLine($"The smallest positive number is: {spn}");
        }
        else
        {
            Console.WriteLine("There are no positive numbers in this list.");
        }
        List<int> sorted_list = num_list;
        sorted_list.Sort();

        Console.WriteLine("Here is the sorted list: ");
        foreach (int num in sorted_list)
        {
            Console.WriteLine($"{num}");
        }
    }
}