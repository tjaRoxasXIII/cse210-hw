using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 1990;
        job1._endYear = 2007;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Software Architect";
        job2._startYear = 2000;
        job2._endYear = 2015;

        job1.Display();
        job2.Display();
    }


}