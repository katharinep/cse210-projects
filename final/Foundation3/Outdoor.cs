public class Outdoor : Event
{
    private string _weather;

    public string Weather
    {
        get {return _weather;}
    }

    public Outdoor(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override string FullDetail()
    {
        return $"Outdoor Event\n{_title}\n{_description}\n{_date} {_time}\nAddress: {_address.GetFullAddress()}\nWeather Forecast: {_weather}";
    }
}