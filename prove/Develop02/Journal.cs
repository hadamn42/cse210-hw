using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);     
    }

    public void DisplayAll()
    {
        foreach (Entry intro in _entries)
        {
            intro.Display();
        }
    }

    public void SaveToFile(string file)
    {
        string fileName = file;
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                string line = $"{entry._date} | {entry._promptText} | {entry._entryText}";
                outputFile.WriteLine($"{line}");
            }            
        }
    }

    public void LoadFromFile(string file)
    {
        string fileName = file;
        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string date = parts[0];
            string promptText = parts[1];
            string entryText = parts[2];
            Entry entro = new Entry();
            
            entro._date = date;
            entro._promptText = promptText;
            entro._entryText = entryText;
            _entries.Add(entro);
        }        
    }
}