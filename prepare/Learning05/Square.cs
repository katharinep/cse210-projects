using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

public class Square : Shape
{
    private double _side;

    public Square(double side, string color) : base(color)
    {
        _side = side;
        _color = color;
    }

    public override double GetArea()
    {
        double area = _side * _side;
        return area;
    }
}