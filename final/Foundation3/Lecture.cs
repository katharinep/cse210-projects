public class Lecture : Event
{
    private string _speaker;
    private int _maxCap;

    public string Speaker
    {
        get {return _speaker;}
    }

    public int maxCap
    {
        get {return _maxCap;}
    }

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int maxCap) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _maxCap = maxCap;
    }

    public override string FullDetail()
    {
        return $"Lecture Event\n{_title}\nSpeaker: {_speaker}\n{_description}\n{_date} {_time}\n{_address.GetFullAddress()}\nMaximum capacity: {_maxCap}";
    }
}