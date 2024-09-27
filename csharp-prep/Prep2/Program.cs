using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        //Ask user for grade percentage//
        Console.Write("Enter grade percentage:");
        string percentage = Console.ReadLine();
        int number = int.Parse(percentage);

        //If statements for letter grade//
        string letter = "";
        if (number >= 90)
        {
            letter = "A";
        }
        
        else if (number >= 80)
        {
            letter = "B";
        }
        
        else if (number >= 70)
        {
            letter = "C";
        }
        
        else if (number >= 60)
        {
            letter = "D";
        }
        
        else if (number < 60)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine("Enter a valid integer (0-100)");
        }
        Console.WriteLine($"Your grade is a/an {letter}.");
        //If statements for passing/failing class//
        if (number >= 70)
        {
            Console.WriteLine("You passed the class.");
        }
        else if (number < 70)
        {
            Console.WriteLine("You failed the class. Try harder next time.");
        }

    }
}