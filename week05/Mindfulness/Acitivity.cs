using System.ComponentModel;

public class Activity
{
    string _name;
    string _description;
    public int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;

    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Let's begin our {_name} Activity.");
        Console.WriteLine($"This activity is all about {_description}.");
        Console.WriteLine("Take just a moment and we will begin.");
        ShowCountDown(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"This concludes our {_name} Activity.  Thank you for taking a moment to practice Mindfulness!");
    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            Console.Write("-");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            currentTime = DateTime.Now;
        }
    }

    public void ShowCountDown(int seconds)
    {
        while(seconds > 0)
        {
            Console.Write($"{seconds}");
            Thread.Sleep(1000);
            Console.Write("\b \b");

            seconds -= 1;
        }
    }

    public int GetDuration()
    {
        return _duration;
    }
}