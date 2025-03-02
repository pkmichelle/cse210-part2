public class Breathing :Activity
{
    public Breathing() : base()
    {
        SetActivityName("Breathing Activity");
        SetOpenMessage("Hello and welcome! This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public void RunActivity()
    {
        DisplayOpenMessage();
        GetDuration();
        NowBreathing();
        DisplayCloseMessage();
    }

    public void NowBreathing()
    {
        int duration = SetDuration();
        DateTime nowTime = DateTime.Now;
        DateTime durationTime = nowTime.AddSeconds(duration);

        while(DateTime.Now < durationTime)
        {
            Countdown("Now breathe in for...", 4, 1, durationTime);
            Countdown("And breathe out...", 1, 6, durationTime);
        }
        Pause();
    }
}