using System;

class Program
{
    static void Main(string[] args)
    {        
        Scripture s1 = new Scripture();

        s1.GetScripture();
        s1.Display();
        s1.HideWords();
        s1.Clear();
    }
}