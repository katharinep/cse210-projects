using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

public class Activity
{
    //class variables//
    protected int _activityLength;
    protected int _randomNum;
    protected int _activityChoice;
    
    //constructors//
    public Activity(int activityChoice)
    {
        _activityChoice = activityChoice;
    }

    //methods//
    public void StartMessage(int _activityChoice)
    {
        //Display Description(activity choice, description, 
        //prep user) and ask user for _activityLength
        //convert input to int
        Console.Clear();
        Description(_activityChoice);
        
        //Console.WriteLine("How long, in seconds, would you like your session? ");
        //string userInput = Console.ReadLine();
        
        //int _activityLength = int.Parse(userInput);//

        //Console.Clear();
        //Console.WriteLine("\nGet ready.");
    }
    
    public static void Description(int _activityChoice)
    {
        //Print activity description to the console.
        //1 = breathing, 2 = listing, 3 = reflection
        if (_activityChoice == 1)
        {
            Console.WriteLine("You have chosen the breathing activity.\n\nThis activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
        }
        else if (_activityChoice == 2)
        {
            Console.WriteLine("You have chosen the listing activity.\n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");
        }
        else if (_activityChoice == 3)
        {
            Console.WriteLine("You have chosen the  reflection activity.\n\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n");
        }
    }

    public static void EndMessage()
    {
        Console.WriteLine("Well done. See you next time.");
        System.Environment.Exit(1);
    }

    public int RandomNum(List<string> _activityList)
    {
        //select a random number within the index of
        //a list and return the random number
        //the list must be set to _activityList before
        //passing through the method
        var random = new Random();
        int _randomNum = random.Next(_activityList.Count);
        return _randomNum;
    }

    public static void SleepSpinner()
    {
        //Spinner to give user time
        //spinner rotates once (2 second pause)//
        Console.Write("|");

        Thread.Sleep(500);

        Console.Write("\b\b");
        Console.Write("/");

        Thread.Sleep(500);

        Console.Write("\b\b");
        Console.Write("-");

        Thread.Sleep(500);

        Console.Write("\b\b");
        Console.Write("\\");

        Thread.Sleep(500);

        Console.Write("\b\b");
        Console.Write("|");
    }
    
    public static void Countdown()
    {
        //5 second countdown to guide user
        //starts with new line//

        Console.WriteLine("");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);

            if (i > 1)
            {
                Console.Write("\b\b");
            }
        }
        //Console.Write("5");

        //Thread.Sleep(1000);

        //Console.Write("\b\b");
        //Console.Write("4");

        //Thread.Sleep(1000);

        //Console.Write("\b\b");
        //Console.Write("3");

        //Thread.Sleep(1000);

        //Console.Write("\b\b");
        //Console.Write("2");

        //Thread.Sleep(1000);

        //Console.Write("\b\b");
        //Console.Write("1");
        //Console.WriteLine("\b\b");//
    }
}