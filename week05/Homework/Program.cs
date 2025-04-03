using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment test = new Assignment("Sam Jackson", "Mathematics");
        MathAssignment mathTest = new MathAssignment("Jack Johnson", "Trigonemtry", "7", "1-23");
        WritingAssignment writingTest = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");

        Console.WriteLine(test.GetSummary());

        Console.WriteLine(mathTest.GetSummary());
        Console.WriteLine(mathTest.GetHomeworkList());

        Console.WriteLine(writingTest.GetSummary());
        Console.WriteLine(writingTest.GetWritingInformation());

    }
    
}

