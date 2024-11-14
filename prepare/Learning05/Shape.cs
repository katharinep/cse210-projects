using System;
using System.Drawing;

public abstract class Shape
{
    protected string _color;


    public Shape(string color)
    {
        _color = color;
    }

    public void SetColor(string color)
    {
        color = _color;
    }

    public string GetColor()
    {
        return _color;
    }
    public abstract double GetArea();
}