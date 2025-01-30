using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        PromptGenerator prompts = new PromptGenerator();
        prompts.GetRandomPrompt();

        Entry entries = new Entry();
        entries.GetResponse();
    }
}