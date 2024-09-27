using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        
        //Ask user for random number//
        //Console.WriteLine("Choose a magic number:");
        //string usernum = Console.ReadLine();
        //int number = int.Parse(usernum);

        //Generate magic number with random//
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);

        //Ask for user guess//
        //Console.WriteLine("What is your guess?");
        //string guess = Console.ReadLine();
        //int intGuess = int.Parse(guess);
        int guess = 0;

        //Compare number//
        while (guess != number)
        {
            //Ask for user guess//
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());
            //guess = int.Parse(guess);
            
            //Compare numbers//
            if (guess == number)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Please enter a valid integer.");
            }
        } 
    }
}