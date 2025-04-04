public class Event
{
    protected string _title;
    protected string _description;
    protected DateTime _date;
    protected DateTime _time;
    protected string _address;

    public Event(string title, string description, DateTime date, DateTime time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string StandardDetails()
    {
        string detail = 
            $"     ===== {_title} =====     \n" +
            $"Description: {_description}.\n=====\n"+
            $"Date= {_date.ToShortDateString()}\n" +
            $"Time= {_time.ToString("h:mm tt")}\n" +
            $"Address= {_address}\n=====\n";

        return detail;
    }

    public string FullDetails()
    {
        string detail = 
            $"     ~~~~~ {_title} ~~~~~     \n" +
            $"Description- {_description}. \n~~~~~\n"+
            $"Date~ {_date.ToShortDateString()}\n" +
            $"Time~ {_time.ToString("h:mm tt")}\n" +
            $"Address~ {_address}\n~~~~~";

        return detail;
    }

    public string ShortDescription()
    {
        string description = 
            "Short Description:\n" +
            "-----\n"+
            $"Type- {this.GetType().Name}\n"+
            $"Date- {_date.ToShortDateString()}\n"+
            "-----\n\n\n";

        return description;
    }
}