using System.Dynamic;

public class Activity
{
    private string _activityName;
    private string _openMessage;
    private string _closeMessage;
    private int _duration;
    public List<Activity> _activities = new List<Activity>();

    public void SetActivityName(string name)
    {
        _activityName = name;   
    }

    public void SetOpenMessage(string open)
    {
        _openMessage = open;
    }

    public void SetCloseMessage(string close)
    {
        _closeMessage = close;
    }

    public int SetDuration()
    {
        return _duration;
    }

    public int GetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        string answer = Console.ReadLine();
        _duration = int.Parse(answer);
        Console.WriteLine($"\n");

        return _duration;
    }

    public void DisplayOpenMessage()
    {
        Pause();

        Console.WriteLine();
        Console.WriteLine($"~~~~The {_activityName}~~~~ ");
        Console.WriteLine();
        Console.WriteLine($"{_openMessage}");
        Console.WriteLine();
        Console.Write("Press enter to continue");
        Console.ReadLine();
    }

    public void DisplayCloseMessage()
    {
        Console.WriteLine("\nWell done!\n");
        Console.WriteLine($"You completed the {_activityName} for {_duration} seconds. ");
        Pause();
    }

    public void Pause()
    {
        char[] spinner = {'-','\\','|','/'};
        int index = 0;

        for (int i = 0; i < 12; i++)
        {
            Console.Write(spinner[index]);
            Thread.Sleep(350);  
            Console.Write("\b \b");

            index++;
            if (index == 4)
            {
                index = 0;
            }          
        }
    }

    public void Countdown(string message, int start, int end, DateTime duration)
    {
        if (start < end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"\r{message} {i}");
                Thread.Sleep(1000);

                if (DateTime.Now >= duration)
                {
                    break;
                }
            }
        }

        else
        {
            for (int i = start; i>= end; i--)
            {
                Console.Write($"\r{message} {i}");
                Thread.Sleep(1000);

                if (DateTime.Now >= duration)
                {
                    break;
                }
            }
        }
        Console.WriteLine();
    }
}