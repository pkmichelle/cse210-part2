using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);
        int count = 0;

        while (number != 0)
        {
            Console.WriteLine("What is your guess?");
            string userGuess = Console.ReadLine();
            int guess = int.Parse(userGuess);
            count ++;

            if (guess > number)
            {
                Console.WriteLine("Lower");
                Console.WriteLine("");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
                Console.WriteLine("");
            }
            else 
            {   
                Console.WriteLine("That's right!");
                Console.WriteLine($"Guesses: {count}");
                Console.WriteLine("");
                break;
            }

        }

    }
}