using System.Collections.Generic;

public class Entry
{
    string _date;
    string _response;
   
    public void GetResponse()
    {
        Console.WriteLine("> ");
        _response = Console.ReadLine();
    }
    
}