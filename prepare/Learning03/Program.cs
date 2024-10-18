using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        //1/1 fraction//
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        
        //Whole number fraction//
        int wholeNumber = 6;
        Fraction f2 = new Fraction(wholeNumber);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        //Regular fraction that asks for the numerator and denominator//
        Console.WriteLine("Enter a numerator: ");
        string userTop = Console.ReadLine();
        int top = int.Parse(userTop);
        

        Console.WriteLine("Enter a denominator: ");
        string userBottom = Console.ReadLine();
        int bottom = int.Parse(userBottom);

        Fraction f3 = new Fraction(top, bottom);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
    }
}