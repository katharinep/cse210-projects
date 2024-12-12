public class Swimming : Activity
{
    private int _laps;

    public int Laps
    {
        get {return _laps;}
    }

    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        return _laps * 50f / 1000f * 0.62f;
    }

    public override float GetSpeed()
    {
        return GetDistance() / Length * 60;
    }

    public override float GetPace()
    {
        return Length / GetDistance();
    }

    public override string GetSummary()
    {
        // Convert laps (50m each) to miles (1 mile = 1609 meters, approximately 0.62 miles per 1000 meters)
        return $"{Date.ToString("dd MMM yyyy")} Swimming ({Length} min): Distance {GetDistance():0.0} miles, " +
           $"Speed {GetSpeed():0.0} mph, Pace {GetPace():0.0} min per mile";
    }
}