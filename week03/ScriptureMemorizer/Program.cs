using System;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Word myWord = new Word("Happy");
        Console.WriteLine(myWord.GetDisplayText());
        myWord.Hide();
        Console.WriteLine(myWord.GetDisplayText());
    }

}