public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll(List<Entry> entries)
    {
        if (_entries.Count > 0)
        {
            foreach (Entry entry in entries)
            {
                entry.Display();
            }
        }
        else
        {
            Console.WriteLine("No entries to display.\n");
        }
    }

    public void SaveToFile(List<Entry> entry, string filename)
    {
        if (entry.Count > 0)
        {
            Console.WriteLine("Saving to File...");

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry e in entry)
                {
                    outputFile.WriteLine($"{e._date}~~{e._entryPrompt}~~{e._userResponse}");
                }
            }
        }
        else 
        {
            Console.WriteLine("You have no entries in your Journal to save. Please write something first!");
        }
    }

    public Journal LoadFromFile(string filename)
    {
        Journal journal = new Journal();
        string[] lines = null;
        try
        {
            lines = System.IO.File.ReadAllLines(filename);
        }
        catch
        {
            Console.WriteLine($"No file found with name: '{filename}'.  Please try again.");
        }

        if (lines != null)
        {
            foreach (string line in lines)
            {
                string[] line_item = line.Split("~~"); 
                Entry userEntry = new Entry(line_item[1], line_item[2]);
                userEntry._date = line_item[0];
                journal.AddEntry(userEntry);
            }

            return journal;

        }
        else
        {
            return journal;
        }

    }

}