using System.Collections.Generic;
public class PromptGenerator
{
   public List<string> _promptsList = new List<string>();
   public string GetRandomPrompt()
    {
        _promptsList.Add("What was the most interesting thing that happened today?");
        _promptsList.Add("What's something that's been lingering in my mind?");
        _promptsList.Add("How did I see the hand of the Lord in my life today?");
        _promptsList.Add("What was the strongest emotion I felt today?");
        _promptsList.Add("If I had one thing I could do over today, what would it be?");
        _promptsList.Add("What do I need to express more gratitude for? and why?");
        _promptsList.Add("Rant here if you need to: ");


        Random randomGenerator = new Random();

        int _randIndex = randomGenerator.Next(_promptsList.Count);
        string _chosenPrompt = _promptsList[_randIndex];

        return _chosenPrompt;

        //yay!! I finished the random prompt generator on my own 
        // AND i understood it muahahahaha
    }
}