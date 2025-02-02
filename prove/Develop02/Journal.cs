using System.Collections.Generic;
public class Journal
{
    List<Entry> _entriesList = new List<Entry>();

    public void AddEntry()
    {
        Entry _entryInstance = new Entry();
        
        _entryInstance.GetPrompt();
        _entryInstance.GetResponse();
        _entryInstance.GetDate();
        _entryInstance.GetRating();
        
        _entriesList.Add(_entryInstance);
    }

    public void DisplayEntry()
    {
        foreach (Entry entry in _entriesList)
        {
            Console.WriteLine();
            Console.WriteLine("~");
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"Response: {entry._response}");
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Rating: {entry._rating}");
            Console.WriteLine("~");
        }
    }

    public void LoadToFile()
    {
        Console.WriteLine("What is the name of the file you would like to load? ");
        string _fileName = Console.ReadLine();
        Console.WriteLine();
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        Entry _entryInstance = new Entry();

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            _entryInstance._prompt = parts[0];
            _entryInstance._response = parts[1];
            _entryInstance._date = parts[2];
            _entryInstance._rating = parts[3];

            Console.WriteLine($"Prompt: {_entryInstance._prompt}");
            Console.WriteLine($"Response: {_entryInstance._response}");
            Console.WriteLine($"Date: {_entryInstance._date}");
            Console.WriteLine($"Rating: {_entryInstance._rating}");
            Console.WriteLine();
        }
    }
    
    public void SaveToFile()
    {
        Console.WriteLine("What is the name of the file you would like to save? ");
        string _fileName = Console.ReadLine();
        int number;

        if (int.TryParse(_fileName, out number))
        {
            _fileName = number.ToString();
        }
        
        using (StreamWriter writer = new StreamWriter(_fileName))
        {
            foreach (Entry entry in _entriesList)
            {
                writer.WriteLine($"{entry._prompt} ~ {entry._response} ~ {entry._date} ~ {entry._rating}");
            }
        }
    }
}