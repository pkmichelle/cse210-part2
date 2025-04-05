public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string title, string description, DateTime date, DateTime time, string address, string speakerName, int capacity)
        :base(title, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public string LectureDetails()
    {
        string detail = 
            $"Event Type: {this.GetType().Name}\n" +
            $"Speaker: {_speakerName}\n" +
            $"Capacity: {_capacity}\n~~~~~\n";

        return detail;
    }
}