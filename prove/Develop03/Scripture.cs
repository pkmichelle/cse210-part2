public class Scripture
{
    List<Reference> _verses = new List<Reference>();
    List<Word> _words = new List<Word>();

    public void GetScripture()
    {
        //Getting all the info for the scripture from the user
        Console.WriteLine("What scripture would you like to memorize today?");
        Console.WriteLine();

        Console.Write("Book: ");
        string book = Console.ReadLine();

        Console.Write("Chapter: ");
        string stringChapter = Console.ReadLine();
        int chapter = int.Parse(stringChapter);

        Console.Write("Start verse: ");
        string sVerse = Console.ReadLine();
        int startVerse = int.Parse(sVerse);

        Console.Write("Is there an end verse? (y/n)");
        string answer = Console.ReadLine();

        Reference newReference;

        // loop for if the user wants to use more than one scripture
        while (true)
        {    
            // if y then use the Reference that formats an end verse
            if (answer.ToLower() == "y")
            {
                Console.Write("End Verse: ");
                string eVerse = Console.ReadLine();
                int endVerse = int.Parse(eVerse);
                newReference = new Reference(book, chapter, startVerse, endVerse);

                break;
            }
            // if n then use Reference that formats for just one verse
            else if (answer.ToLower() == "n")
            {
                newReference = new Reference(book, chapter, startVerse);           
                break;
            }
            // if they answer something other than y or n, ask again until they do
            else
            {
                Console.WriteLine("Please enter 'y' or 'n' ");
            }
        }

        //once user has typed scripture info, add this reference to the verses list
        _verses.Add(newReference);

        //while this might not be most effective, have the user copy and paste the scripture here
        Console.WriteLine();
        Console.WriteLine("Please place the scripture text here (enter as one line, pasting each verse one at a time): ");
        string scriptureText = Console.ReadLine();

        //using TextToList method
        TextToList(scriptureText);
    }

    private void TextToList(string givenText)
    // method puts the text that the user gives into an array and adds it to the _words list
    {
        string[] words = givenText.Split(new[] {' '});

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.Clear();
        //start by clearing the console so that it doesn't print a million times over

        for (int i = 0; i < _verses.Count; i++)
        {
            // loop that formats the reference given in the verses list
            Reference reference = _verses[i];
            Console.WriteLine(reference.FormattedReference());
        }
        
        //iterates through the words in _words and renders them either printed or as underscore
        foreach (Word word in _words)
        {
            Console.Write(word.GetRenderedText() + " ");
        }

        Console.WriteLine();
    }

    public void HideWords()
    {
        while(true)
        {   
            Random _random = new Random();
            List<int> indexAvailable = new List<int>();

            Console.WriteLine("Press Enter to hide words or type 'quit' to exit. ");
            string input = Console.ReadLine();
            
            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Exiting the program, thanks!");
                break;
            }

            // for loop that checks if the words in _words are hidden or not
            // if they  aren't hidden append them to the indexAvailable list
            for(int i = 0; i < _words.Count; i++)
            {
                if (!_words[i].IsHidden())
                {
                    indexAvailable.Add(i);
                }
            }

            // loop that chooses 3 random indexes from the indexAvailable list
            // sets these words as hidden with the Hide() method and then removes
            // them from indexAvailable so that they can't be used again
            for (int i = 0 ; i < Math.Min(3, indexAvailable.Count); i++)
            {
                int index = _random.Next(indexAvailable.Count);
                _words[indexAvailable[index]].Hide();
                indexAvailable.RemoveAt(index);
            }

            Display();

            if (IsCompletelyHidden())
            {
                Console.WriteLine("Exiting the program, thanks!");
                break;
            }
        }
    }

    private bool IsCompletelyHidden()
    //checks if all the words in _words list is hidden or not
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public void Clear()
    // clears the console so that the scripture doesn't stay in the console a million timesa
    {
        _verses.Clear();
        _words.Clear();
    }
}