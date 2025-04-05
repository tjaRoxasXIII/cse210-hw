using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        BreathingActivity test = new BreathingActivity();

        //test.ShowSpinner(30);
        //test.ShowCountDown(5);
        test.Run();
    }
}