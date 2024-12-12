public class Running : Activity
{
    private float _distance;

    public float Distance
    {
        get {return _distance;}
    }

    public Running(DateTime date, int length, float distance) : base(date, length)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return Distance;
    } 
    public override float GetSpeed()
    {
        return Distance / Length * 60;
    }

    public override float GetPace()
    {
        return Length / Distance;
    }

    public override string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} Running ({Length} min): Distance {GetDistance():0.0} m," +
            $"Speed {GetSpeed():0.0} mph, Pace {GetPace()} min per m";
    }
}