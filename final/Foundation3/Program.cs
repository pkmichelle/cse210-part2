using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("A Guide to Self Motivation", "A deep dive into how to engage your inner motivate yourself, how to improve oneself, and how to move on from setbacks", new DateTime(2025, 4, 20), new DateTime(2025, 4, 20, 9, 0, 0), "604 Napatree St, Las Vegas, NV 89144, USA", "Emily Sommers", 150);
        Reception reception = new Reception("Paige and Thomas Wedding", "A luncheon following the sealing of Paige Klingler and Thomas Koster. Lunch, dessert, and refreshments will be provided", new DateTime(2025, 4, 8), new DateTime(2025, 4, 8, 11, 0, 0), "163 N Center St, Rexburg, ID 83440, USA", "Please join us for the wedding of Paige Klingler and Thomas Koster on April, 8, 2025. To RSVP, respond to this email with 'RSVP'. We hope to see you there! ");
        Outdoor outdoor = new Outdoor("Company Picnic", "A potluck style picnic for all company employees at Roy City Park.", new DateTime(2025, 5, 17), new DateTime(2025, 5, 17, 3, 30, 0), "5300 S 1000 W, Roy, UT 84167, USA", "70°F ~ Partly Cloudy");

        List<Event> events = new List<Event>{lecture, reception, outdoor};

        foreach (Event e in events)
        {
            Console.WriteLine("Full Details: \n");
            Console.WriteLine(e.FullDetails());

            if (e is Lecture l)
            {
                Console.WriteLine(l.LectureDetails());
            }
            else if (e is Reception r)
            {
                Console.WriteLine(r.ReceptionDetails());
            }
            else if (e is Outdoor o)
            {
                Console.WriteLine(o.OutdoorDetails());
            }

            Console.WriteLine("Standard Details: \n");
            Console.WriteLine(e.StandardDetails());
            Console.WriteLine(e.ShortDescription());
        }
    }
}