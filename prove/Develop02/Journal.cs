using System;
using System.Collections.Generic;
using System.IO;

class Journal {
    private List<Entry> entries;
    private PromptGenerator promptGenerator;

    public Journal() {
        entries = new List<Entry>();
        promptGenerator = new PromptGenerator();
    }

    public void WriteNewEntry() {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine("Prompt: " + prompt);
        Console.WriteLine("Enter your response:");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString();
        Entry newEntry = new Entry(prompt, response, date);
        entries.Add(newEntry);
    }

    public void DisplayJournal() {
        foreach (Entry entry in entries) {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename) {
        using (StreamWriter writer = new StreamWriter(filename)) {
            foreach (Entry entry in entries) {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    public void LoadFromFile(string filename) {
        entries.Clear();
        string line;
        using (StreamReader reader = new StreamReader(filename)) {
            while ((line = reader.ReadLine()) != null) {
                string[] parts = line.Split('|');
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];
                Entry loadedEntry = new Entry(prompt, response, date);
                entries.Add(loadedEntry);
            }
        }
    }
}
