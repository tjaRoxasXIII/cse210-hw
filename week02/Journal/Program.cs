using System;
using System.Security.Cryptography.X509Certificates;

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

                    Entry userEntry = new Entry(prompt, userResponse );
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
                    break;
            //4. Load from File
                case "4":
                    break;
            //5. Quit
                case "5":
                    isRunning = false;
                    break;
            }
        

        }
        
        
        

        

    }
}