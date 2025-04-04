using System;
class Program
{
    static void Main(string[] args)
    {
        Journal _journalInstance = new Journal();
        int _loop = 1000000;

        Console.WriteLine();
        Console.WriteLine("Hello and welcome to your journal!");

        while (_loop != 0)
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine();
            Console.Write("What would you like to do? ");

            string _userInput = Console.ReadLine();
            int _choice = 0;
            bool _validInput = false;

            while (!_validInput)
            {    
                if (int.TryParse(_userInput, out _choice) && _choice >= 1 && _choice <= 5)
                {
                    _validInput = true;
                }
                else
                {
                    Console.WriteLine("** Please select a number from 1 to 5 **");
                    _userInput = Console.ReadLine();
                }
            }

            if (_choice == 1)
            {
                _journalInstance.AddEntry();
            }
            else if (_choice == 2)
            {
                _journalInstance.DisplayEntry();
            }
            else if (_choice == 3)
            {
                _journalInstance.LoadToFile();
            }
            else if (_choice == 4)
            {
                _journalInstance.SaveToFile();
            }
            else if (_choice == 5)
            {
                Console.WriteLine("Thank you! See you next time");
                break;
            }
        }
    }
}