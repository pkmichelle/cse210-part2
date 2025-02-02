using System.Dynamic;
public class Rating
{
    public int _number;
    public string _description;

    public string GetDescription()
    {
        bool _validInput = false;

        while (!_validInput)
        {    
            Console.WriteLine("How was your day on a scale of 1-10? ");
            string _numberString = Console.ReadLine();

            if (int.TryParse(_numberString, out _number) && _number >= 1 && _number <= 10)
            {
                _validInput = true;
            }
            else
            {
                Console.WriteLine("** Please select a number between 1-10 **");
            }
        }

        if (_number == 1)
        {
            _description = "1- I'm sorry you didn't have a good day. I know things will get better!";
        }
        else if (_number == 2)
        {
            _description = "2- I'm sorry you didn't have the best day. Keep your head up!";
        }
        else if (_number == 3)
        {
            _description = "3- I'm sorry you day wasn't the greatest. Keep persisting and things will turn up!";
        }
        else if (_number == 4)
        {
            _description = "4- I'm sorry you didn't have the greatest day. Tomorrow always has the potential of being better!";
        }
        else if (_number == 5)
        {
            _description = "5- Seems like you had a pretty neutral day. Sometimes remembering what I'm grateful for gives that extra boost!";
        }
        else if (_number == 6)
        {
            _description = "6- Sounds like your day was alright. I know your coming days can be even better!";
        }
        else if (_number == 7)
        {
            _description = "7- A fairly solid day, yeah? Glad to hear it! Keep up the good spirits!";
        }
        else if (_number == 8)
        {
            _description = "8- A solid day! Remembering the greatness of your day helps for the future!";
        }
        else if (_number == 9)
        {
            _description = "9- Awesome! I'm stoked your day went well. Carry that feeling onto tomorrow!!";
        }
        else if (_number == 10)
        {
            _description = "10- That's great news! Tomorrow can have even greater things in store!";
        }
        else
        {
            Console.WriteLine("Please select a number 1-10");
        }
        
        return _description;
    }
}