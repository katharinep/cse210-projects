using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        //Display welcome message//
        DisplayMessage();

        //Ask for and print user name//
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        PromptUserName(name);

        //Ask for favorite number//
        Console.Write("What is your favorite number? ");
        int userNumber = int.Parse(Console.ReadLine());
        PromptUserNumber(userNumber);

        //Square the favorite number//
        int square = SquareNumber(userNumber);

        //Display name and square of the favorite number//
        DisplayResult(name, square);
    }

    static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }
    static string PromptUserName(string name)
    {
        Console.WriteLine($"Your name is {name}.");
        return name;
    }
    static int PromptUserNumber(int userNumber)
    {
        Console.WriteLine($"Your favorite number is {userNumber}.");

        return userNumber; 
    }
    static int SquareNumber(int userNumber)
    {
        int square = userNumber * userNumber;
        return square;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }
}   