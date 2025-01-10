using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What's your grade percentage? ");

        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = "";
        int lastDigit = grade % 10;
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade >= 50)
        {
            letter = "F";
        }


        if (letter!= "F")
            if (lastDigit >= 7 && letter != "A")
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
        {
            sign = "";
        }
        
        Console.WriteLine();
        Console.WriteLine($"Your grade percentage is: {grade}%");
        Console.WriteLine($"Your grade letter is: {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine();
            Console.WriteLine("Congrats! You passed :)");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("I'm sorry, you didn't pass, but you'll get 'em next time!");
        }
    }
}