using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.IO;
//Extra credit:  In the Journal.cs file, I added some error handling to the LoadFromFile method to return an empty Journal instance if a user types in a filename that does not exist.

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool isRunning = true;

        //Menu options
        while (isRunning){
            Console.WriteLine("Please make a choice: ");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save File");
            Console.WriteLine("4. Load from File");
            Console.WriteLine("5. Quit");
            Console.Write("> ");
            string choice = Console.ReadLine();

            //1. Add Entry
            switch (choice)
            {
                
                case "1":
                    PromptGenerator newPromptGen = new PromptGenerator();
                    string prompt = newPromptGen.GetRandomPrompt();
                    Console.WriteLine(prompt);

                    Console.Write("> ");
                    string userResponse = Console.ReadLine();

                    Entry userEntry = new Entry(prompt, userResponse);
                    userEntry.Display();
                    journal.AddEntry(userEntry);

                    break;
            //2. Display Journal
                case "2":
                    Console.WriteLine("\nHere are all of your Journal Entries: \n");
                    journal.DisplayAll(journal._entries);
                    break;
            //3. Save to File
                case "3":
                    Console.Write("Please enter a filename to save your journal: ");
                    string filename = Console.ReadLine();
                    filename = filename + ".txt";
                    journal.SaveToFile(journal._entries, filename);
                    break;
            //4. Load from File
                case "4":
                    Console.Write("Please enter the filename of your journal (ex: journal.txt): ");
                    string loadedFile = Console.ReadLine();
                    journal = journal.LoadFromFile(loadedFile);

                    break;
            //5. Quit
                case "5":
                    isRunning = false;
                    break;
            }
        } 
    }

}