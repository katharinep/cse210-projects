public abstract class Activity
{
    private DateTime _date;
    private int _length;

    public DateTime Date
    {
        get {return _date;}
    }

    public int Length
    {
        get {return _length;}
    }

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public abstract float GetDistance();

    public abstract float GetSpeed();

    public abstract float GetPace();

    public abstract string GetSummary();
}