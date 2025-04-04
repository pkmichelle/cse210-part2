public class Reception: Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime date, DateTime time, string address, string rsvpEmail)
        :base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public string ReceptionDetails()
    {
        string detail = 
            $"Event Type: {this.GetType().Name}\n" +
            $"RSVP Email: {_rsvpEmail}\n~~~~~\n";

        return detail;
    }
}