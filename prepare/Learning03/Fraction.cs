using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

public class Fraction
{
    private int _top;
    private int _bottom;


    //Constructor that has //
    //no parameters that initializes //
    //the number to 1/1//
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    //Constructor that has one//
    //parameter for the top and initializes//
    //the denominator to 1.//
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    //Constructor has two parameters,//
    //one for top and one for bottom//
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;

    }


    //Getters and setters are accessors that//
    //access the private variables//
    //Getters retrieve the value, setters reassign a value//
    //Get top function//
    public int GetTop()
    {
        //access the _top value//
        return _top;
    }

    public void SetTop(int top)
    {
        top = _top;
    }

    public int GetBottom(int bottom)
    {
        //access the _bottom value//
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        bottom = _bottom;
    }

    public string GetFractionString()
    {
        //convert top and bottom to string?
        string fractionString = _top + "/" + _bottom;
        return fractionString;
    }

    public double GetDecimalValue()
    {
        double decimalValue = (double)_top / (double)_bottom;
        return decimalValue;
    }

}