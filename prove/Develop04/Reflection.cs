public class Reflection : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    
    public Reflection() :base()
    {
        SetActivityName("Reflection Activity");
        SetOpenMessage("Hello and welcome! This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experiene meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void RunActivity()
    {
        DisplayOpenMessage();
        GetDuration();
        Pause();
        ShowPrompt();
        Pause();
        ShowQuestions();
        DisplayCloseMessage();
    }
    
    public void ShowPrompt()
    {
        Console.WriteLine("Consider the following prompt:");

        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string randomPrompt = _prompts[randomIndex];

        Console.WriteLine($"    --- {randomPrompt} ---\n");
    }

    public void ShowQuestions()
    {
        Random random = new Random();

        int duration = SetDuration();
        DateTime nowTime = DateTime.Now;
        DateTime durationTime = nowTime.AddSeconds(duration);

        while (DateTime.Now < durationTime)
        {
            // loop to go through each question in the list
            for (int i = 0; i < _questions.Count; i++)
            {
                int randomIndex = random.Next(_questions.Count); // getting a random index
                string tempQuestion = _questions[i];  // holding a temporary question

                _questions[i] = _questions[randomIndex];
                _questions[randomIndex] = tempQuestion; // giving tempQuestion a the random Index to "swap" out the previous question
            }

            foreach(string question in _questions)
            {
                Console.WriteLine($"    ---{question}---");
                Console.ReadLine();
                Console.WriteLine();

                if (DateTime.Now >= durationTime)
                {
                    break;
                }
            }
        }

        Console.WriteLine("Time's up!");
    }
}