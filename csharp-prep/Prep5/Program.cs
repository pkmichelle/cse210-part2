using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayResult()
        {
            DisplayWelcome();
            string name = PromptUserName();
            int number = PromptUserNumber();
            string result = $"{name}, the square of your number is {SquareNumber(number)}";
            Console.WriteLine(result);
        }

        static void DisplayWelcome()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userNum = Console.ReadLine();
            int number = int.Parse(userNum);
            return number;
        }

        static int SquareNumber(int number)
        {
            int numSquared = number * number;
            return numSquared;
        }

        DisplayResult();
        // DisplayWelcome();
        // PromptUserName();
        // int number = PromptUserNumber();
        // SquareNumber(number);
    }
}