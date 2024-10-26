using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Display program name and welcome user//
        Console.WriteLine("Digital Journal");
        Console.WriteLine("");
        Console.WriteLine("Welcome Back!");
        Console.WriteLine("");

        Console.WriteLine("Enter user name: ");
        string userName = Console.ReadLine();
        Journal journal = new Journal(userName); 

        while (true)
        {
        
            int userChoice = MainMenu();

            if (userChoice == 1)
            {
                //New journal choice//
                Console.WriteLine("");
                journal.NewEntry();
            }
            else if (userChoice == 2)
            {
                //Save journal choice//
                Console.WriteLine("");
                journal.SaveJournal(); 
            }
            else if (userChoice == 3)
            {
                //Load journal choice//
                Console.WriteLine("");
                journal.LoadJournal();
            }
            else if (userChoice == 4)
            {
                //Display journal choice//
                Console.WriteLine("");
                journal.DisplayAll();
            }
            else if (userChoice == 5)
            {
                //Exit message and end program//
                Console.WriteLine("");
                Console.WriteLine("See you tomorrow! Bye!");
                Console.WriteLine("");
                System.Environment.Exit(1);
            }
            else
            {
                //Ask user for valid response//
                Console.WriteLine("");
                Console.WriteLine("Invalid response. Please choose a number 1-5.");
                Console.WriteLine("");
            }

        }
    
    }
    //Menu function//
    static int MainMenu()
    {
        //Options//
        Console.WriteLine("Choose an option (1-5):");
        Console.WriteLine("1. New journal entry");
        Console.WriteLine("2. Save journal entry");
        Console.WriteLine("3. Load journal entry");
        Console.WriteLine("4. Display the journal");
        Console.WriteLine("5. Exit");

        //User input//
        string userInput = Console.ReadLine();
        var userChoice = int.Parse(userInput);
                
        return userChoice;
    }
    
}
