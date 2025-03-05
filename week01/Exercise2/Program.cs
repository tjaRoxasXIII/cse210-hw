using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string grade = Console.ReadLine();
        int percentage = int.Parse(grade);
        string letter = "";
        string sign = "";
         
        if (percentage >= 90 )
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else if (percentage < 60)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine("Not a valid grade percentage.");
        }

        if ((percentage % 10 >= 7) && (letter != "F") && (letter != "A"))
        {
            sign = "+";
        }
        else if ((percentage % 10 < 3) && (letter != "F"))
        {
            sign = "-";
        }
        Console.WriteLine($"Your grade is a: {letter}{sign}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations, you're passing!");
        }
        else
        {
            Console.WriteLine("Work a little harder and try to get those grades up!");
        }
    }
}