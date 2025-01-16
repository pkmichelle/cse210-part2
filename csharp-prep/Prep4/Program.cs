using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        bool entry = true;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (entry == true)
        {
            Console.Write("Enter number: ");

            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number != 0)
            {
                numbers.Add(number);
            }

            if (number == 0)
            {
                break;
            }
        }

        float total = 0;
        float average = 0;
        float maximum = 0;
        float minimum = 0;

        for (int i=0; i<numbers.Count; i++)
        {
            total += numbers[i];
            average = total/numbers.Count;
            maximum = numbers.Max();
            
            if (numbers[i] > 0)
            {
                minimum = numbers.Min();
            }

            Console.WriteLine(numbers[i]);
        }
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is : {average}");
        Console.WriteLine($"The maximum value is: {maximum}");
        Console.WriteLine($"The smallest positive number is:{minimum}");
    }
}