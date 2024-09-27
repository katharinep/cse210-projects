using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        //Create List//
        List<int> numbers = new List<int>();

        int number = -1;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        //Ask user for numbers//
        while (number != 0)
        {
            //user input/
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            //Add number to list//
            numbers.Add(number);
            
        }
        
        //Test list//
        //foreach (int item in numbers)
        //{
            //Console.WriteLine(item);
        //}

        //Compute and print sum of numbers//
        //foreach (int item in numbers)
        //{
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");
        //}

        //Compute and print average of numbers//
        //Remove 0 from list so it doesn't affect the average)
        numbers.RemoveAll(i => i == 0);

        int count = numbers.Count;
        int average = sum / count;
        Console.WriteLine($"The average is: {average}");

        //Find and print the largest number//
        int max = numbers.Max();
        Console.WriteLine($"The max is: {max}");

    }
}