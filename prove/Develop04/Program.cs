using System;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("\nHello and welcome to the Mindfulness Program!\n");
            Console.WriteLine("Here are your activity options: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Meditation Activity");
            Console.WriteLine("5. Quit");
            Console.Write("Select from the menu (1-5): ");
            string stringChoice = Console.ReadLine();
            int choice = int.Parse(stringChoice);

            if (choice == 1)
            {
                Breathing a = new Breathing();
                a.RunActivity();
            }
            else if (choice == 2)
            {
                Reflection a = new Reflection();
                a.RunActivity();
            }
            else if (choice == 3)
            {
                Listing a = new Listing();
                a.RunActivity();
            }
            else if (choice == 4)
            {
                Meditation a = new Meditation();
                a.RunActivity();
            }
            else if (choice == 5)
            {
                Console.WriteLine("\nThank you, and I hope your mind feels a little bit fuller!\n");
                break;
            }
            else
            {
                Console.WriteLine("I don't recognize that input, please choose a number 1-5");
            }
        }
    }
}