public class Word
{
    private string _word;
    private bool _isHidden;


    public Word(string text)
    {
        _word = text;
        _isHidden = false;
        //simply setting the values 
    }

    public void Hide()
    {
        _isHidden = true;
        // when Hide() function is used, the boolean stores that the word is hidden
    }

    public void Show()
    {
        _isHidden = false;
        // when Show() is used, boolean stores that the word is being shown
    }
    
    public bool IsHidden()
    {
        return _isHidden;
        // point is to return whatever value Hide() or Show() gives to _isHidden
        // so instead of having to use Hide() and Show() in other classes to see
        // if a word is hidden, we only have to use IsHidden()
    }

    public string GetRenderedText()
    {
        if (_isHidden == true)
        {
            return new string('_', _word.Length);
            // if word is hidden then it would print the length of the word as the
            // underscores. so dog = ___(x3) puppy = _____(x5) fantastic = _________(x9)
        }
        else
        {
            return _word;
            // when is hidden is false (the word is still there) the word is printed
            // as it normally would
        }
    }
}