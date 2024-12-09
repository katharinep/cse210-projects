public class Event
{
    protected string _title {get; private set;}
    protected string _description {get; private set;}
    protected string _date {get; private set;}
    protected string _time {get; private set;}
    protected Address _address {get; private set;}

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string StandardDetail()
    {
        return $"{_title}\n{_description}\n{_date} {_time}\n{_address.GetFullAddress()}";
    }

    public virtual string FullDetail()
    {
        return $"{_title}\n{_description}\n{_date} {_time}\n{_address.GetFullAddress()}";
    }

    public string ShortDescription()
    {
        return $"{_title}\n{_date}";
    }
}