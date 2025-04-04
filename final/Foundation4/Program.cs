using System;

class Program
{
    static void Main(string[] args)
    {        
        Running running = new Running(new DateTime(2025, 4, 1), 30, 3.0);
        Cycling cycling = new Cycling(new DateTime(2025, 4, 2), 45, 15.0);
        Swimming swimming = new Swimming(new DateTime(2024, 4, 3), 42, 30);

        List<Activity> activities = new List<Activity>{running,cycling,swimming};


        foreach (Activity activity in activities)
        {
           Console.WriteLine(activity.GetSummary()); 
        }
    }
}