public class Outdoor: Event
{
    private string _weather;

    public Outdoor(string title, string description, DateTime date, DateTime time, string address, string weather)
        :base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public string OutdoorDetails()
    {
        StandardDetails();

        string detail = 
            $"Event Type: {this.GetType().Name}\n" +
            $"Weather Forecast: {_weather}\n~~~~~\n" ;

        return detail;
    }
}