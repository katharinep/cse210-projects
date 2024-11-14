using System;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base(color)
    {
        _color = color;
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        double area = _width * _length;
        return area;
    }
} 