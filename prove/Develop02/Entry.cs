using System.Collections.Generic;

public class Entry
{
    public string _date;
    public string _response;
    public string _prompt;

    public void GetResponse()
    {
        Console.Write("> ");
        _response = Console.ReadLine();
    }

    public void GetDate()
    {
        DateTime _dateToday = DateTime.Now;
        _date = _dateToday.ToString();
    }

    public void GetPrompt()
    {
        PromptGenerator _promptInstance = new PromptGenerator();
        _prompt = _promptInstance.GetRandomPrompt();
        Console.WriteLine($"Prompt: {_prompt}");
    }
}