using System.Collections.Generic;
public class PromptGenerator
{
   public List<string> _promptsList = new List<string>();
   public void GetRandomPrompt()
    {
        _promptsList.Add("Who was the most interesting person I interacted with today?");
        _promptsList.Add("What was the best part of my day?");
        _promptsList.Add("How did I see the hand of the Lord in my life today?");
        _promptsList.Add("What was the strongest emotion I felt today?");
        _promptsList.Add("If I had one thing I could do over today, what would it be?");

        Random randomGenerator = new Random();

        int _randIndex = randomGenerator.Next(_promptsList.Count);
        string _chosenPrompt = _promptsList[_randIndex];

        Console.WriteLine($"Random prompt: {_chosenPrompt}");

        //yay!! I finished the random prompt generator on my own 
        // AND i understood it muahahahaha
    }
}