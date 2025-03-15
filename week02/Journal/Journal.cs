using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks.Dataflow;
public class Journal 
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        
        Console.WriteLine("Saving to file...");
        using (StreamWriter outputFile = new StreamWriter(filename))
        {    
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}\n{entry._entryText}\nQUOTE OF THE DAY FOR YOU: {entry._promptMotivation}\n");
            }
        }
    }

    public void LoadFromFile()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        
        Console.WriteLine("Loading from file...");

         if (!System.IO.File.Exists(filename))
        {
            Console.WriteLine("Error: The file does not exist.");
            return;
        }

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}