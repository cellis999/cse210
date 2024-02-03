using System;
using System.Collections.Generic;
using System.IO;
namespace Develop02;
public class Journal
{
    public List<Entry> Entries;

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void AddEntry(string prompt, string response, DateTime date)
    {
        Entries.Add(new Entry(prompt, response, date));
    }

    public void DisplayEntries()
    {
        foreach (var entry in Entries)
        {
            Console.WriteLine($"Date: {entry.Date}\nPrompt: {entry.Prompt}\nResponse: {entry.Response}");
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in Entries)
            {
                writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        Entries.Clear();
        using (StreamReader reader = new StreamReader(fileName))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine().Split(',');
                DateTime date = DateTime.Parse(line[0]);
                string prompt = line[1];
                string response = line[2];
                Entries.Add(new Entry(prompt, response, date));
            }
        }
    }
}
