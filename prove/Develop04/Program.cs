using System;

class Program
{
    static void Main(string[] args)
    {
        //Extra credit: I added some logic that prevents questions//
        //being asked multiple times in the reflection activity.//
        
        //Main Menu//
        Console.WriteLine("Menu\n1. Breathing\n2. Listing\n3. Reflection\n4. Exit");
        Console.Write("> ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            int activityChoice = 1;
            
            Breathing breathing = new Breathing(activityChoice);
            
            breathing.StartMessage(activityChoice);
            Console.WriteLine("How long, in seconds, would you like your session? ");
            Console.Write("> ");
            string userInput = Console.ReadLine();
        
            int activityLength = int.Parse(userInput);
            Console.Clear();
            
            breathing.RunBreathing(activityLength);
        }
        else if (choice == "2")
        {
            int activityChoice = 2;
            
            Listing listing = new Listing(activityChoice);
            
            listing.StartMessage(activityChoice);
            Console.WriteLine("How long, in seconds, would you like your session? ");
            Console.Write("> ");
            string userInput = Console.ReadLine();
        
            int activityLength = int.Parse(userInput);
            Console.Clear();
            listing.RunListing(activityLength);
        }
        else if (choice == "3")
        {
            int activityChoice = 3;
            
            Reflection reflection = new Reflection(activityChoice);
            reflection.StartMessage(activityChoice);
            Console.WriteLine("How long, in seconds, would you like your session? ");
            Console.Write("> ");
            string userInput = Console.ReadLine();
        
            int activityLength = int.Parse(userInput);
            Console.Clear();
            reflection.RunReflection(activityLength);
        }
        else if (choice == "4")
        {
            System.Environment.Exit(1);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
        
    }
}