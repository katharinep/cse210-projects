using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        //create pink square with side 2 (area 4)//
        shapes.Add(new Square(2,"pink"));
        
        //create a blue rectangle with width 2 and length 4(area 8)//
        shapes.Add(new Rectangle("blue",4,2));

        //create a yellow circle with radius 2(area 12.56636)//
        shapes.Add(new Circle("yellow",2));

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine(color);
            Console.WriteLine(area);
        }
        
    }
}