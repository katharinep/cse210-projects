public class Reception : Event
{
    private string _rsvp;

    public string RSVP
    {
        get {return _rsvp;}
    }

    public Reception(string title, string description, string date, string time, Address address, string rsvp): base(title, description, date, time, address)
    {
        _rsvp = rsvp;
    }

    public override string FullDetail()
    {
        return $"Reception Event\n{_title}\n{_description}\n{_date} {_time}\n{_address.GetFullAddress()}\nRSVP: {_rsvp}";
    }
}