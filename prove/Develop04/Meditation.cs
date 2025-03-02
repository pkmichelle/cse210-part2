public class Meditation :Activity
{
    public Meditation() : base()
    {
        SetActivityName("Meditation Activity");
        SetOpenMessage("Hello and welcome! This activity will help to practice mind calmness by walking you through prompts that help you ground yourself. Clear your mind, focus on your breathing, and get in a relaxing and comfortable position.");
    }

    public void RunActivity()
    {
        DisplayOpenMessage();
        NowMeditating();
        DisplayCloseMessage();
    }

    public void NowMeditating()
    {
        DateTime duration = DateTime.MaxValue;

        Countdown("Take three deep breaths, in through your nose...", 4, 1, duration);
        Countdown("And out through your mouth...", 1, 6, duration);
        Countdown("Good! Two more. In...", 4, 1, duration);
        Countdown("And out...", 1, 6, duration);
        Countdown("Last one, slowly in...",4,1,duration);
        Countdown("And out...",1,6,duration);
        Pause();

        while(true)
        {
            if (Continue() == true)
            {
                Console.WriteLine("\nNow I want you to imagine that you're floating on a cloud. Imagine how nice, soft, and fluffy the cloud feels supporting your body.");
                Console.WriteLine("You feel safe and protected on this cloud. Now let your muscles completely relax and fall into the cloud.");
                Pause();
                Pause();

                if (Continue() == true)
                {
                    Console.WriteLine("\nYou are now apart of this cloud and feel as light as air.");
                    Console.WriteLine("You can see the cities below,and the people, the mountains, the animals, the waterfalls, lakes, and rivers.");
                    Console.WriteLine("You can smell the water, the plants surrounding, and the crisp air");
                    Console.WriteLine("Allow yourself to get lost in this place and feeling. Remember how relaxed you feel");
                    Pause();
                    break;
                }
            }
            else
            {
                break;
            }

            Console.WriteLine("Thank you for joining today!");
        }

        Pause();
    }

    private bool Continue()
    {
        while(true)
        {
            Console.WriteLine("\nWould you like to continue? (yes or no)");
            string response = Console.ReadLine();

            if (response.ToLower() == "yes")
            {
                return true;
            }
            else if (response.ToLower() == "no")
            {
                return false;
            }
            else
            {
                Console.WriteLine("I don't recognize that input. Please answer yes or no");
            }
        }  
    }
}