public class Listing : Activity
{
    private List<string> _prompts;
    private List<string> _responses = new List<string>();
    
    public Listing() : base()
    {
        SetActivityName("Listing Activity");
        SetOpenMessage("Hello and welcome! This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void RunActivity()
    {
        DisplayOpenMessage();
        GetDuration();
        ShowPrompt();
        GetList();
        DisplayCloseMessage();
    }

    private void ShowPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];

        Console.WriteLine("Get ready for your prompt...");
        Pause();
        Console.WriteLine();

        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"    --- {randomPrompt} ---\n\n");
    }

    private void GetList()
    {
        int duration = SetDuration();
        DateTime nowTime = DateTime.Now;
        DateTime durationTime = nowTime.AddSeconds(duration);

        Countdown("You may begin in... ", 3, 1, durationTime);
        while(DateTime.Now < durationTime)
        {
            string item = Console.ReadLine();
            _responses.Add(item);
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {_responses.Count} items!");
        Console.WriteLine();
    }
}