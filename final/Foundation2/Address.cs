public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _nation;

    public Address(string street, string city, string state, string nation)
    {
        _street = street;
        _city = city;
        _state = state;
        _nation = nation;
    }

    public bool InternationalResidence()
    {
        //bool residence = true;
        //if (_nation == "USA")
            //residence = false;
        //return residence;
        return _nation != "USA";
    }

    public string CompleteAddress()
    {
        return $"{_street}\n{_city}, {_state} {_nation}";
    }
}