using System;
using System.Diagnostics;
using System.Collections.Generic;

public class Listing : Activity
{
    //class variables//
    private List<string> _prompts;
    private List<string> _input;
    private Random _random;
    private string _listPrompt;

    //constructors//
    public Listing(int activityChoice) : base(activityChoice)
    {
        _prompts = new List<string>
        {
           "Who are people that you appreciate?",
           "What are personal strengths of yours?",
           "Who are people that you have helped this week?",
           "When have you felt the Holy Ghost this month?",
           "Who are some of your personal heroes?", 
        };

        _input = new List<string>();
        _random = new Random();
    }

    //methods//
    public string RandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        string _listPrompt = _prompts[index];
        return _listPrompt;
    }

    public void ListInput()
    {
        Console.Write("> ");
        string userInput = Console.ReadLine();
        _input.Add(userInput);
    }
    public void PromptMessage(string _listPrompt)
    {
        Console.Clear();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"{_listPrompt}");
    }
    
    public void RunListing(int activityLength)
    {
        _listPrompt = RandomPrompt();
        Console.Clear();
        Console.WriteLine("\nGet ready.");
        SleepSpinner();
        PromptMessage(_listPrompt);

        Console.WriteLine("\nPress enter when you are ready.");
        Console.ReadLine();

        DateTime futureTime = DateTime.Now.AddSeconds(activityLength);

        while (DateTime.Now < futureTime)
        {
            ListInput();
        }

        Console.WriteLine($"You gave {_input.Count} responses. Good work!");

        EndMessage();
    }
}