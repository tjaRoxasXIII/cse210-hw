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

    public void SaveToFile(string file)
    {

    }

    public void LoadFromFile(string file)
    {

    }

}