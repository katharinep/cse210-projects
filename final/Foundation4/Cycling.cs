public class Cycling : Activity
{
    private float _speed;

    public float Speed
    {
        get {return _speed;}
    }

    public Cycling(DateTime date, int length, float speed) : base(date, length)
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        return Speed * Length / 60;
    }

    public override float GetSpeed()
    {
        return Speed;
    }

    public override float GetPace()
    {
        return 60 / Speed;
    }

    public override string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} Cycling ({Length} min): Distance {GetDistance():0.0} miles, " +
           $"Speed {GetSpeed():0.0} mph, Pace {GetPace():0.0} min per mile";
    }
}