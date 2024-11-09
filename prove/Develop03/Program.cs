using System;
using System.Runtime.InteropServices;
using ScriptureMemory;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Scripture Memory");

        Scripture scripture = new Scripture();

        Console.WriteLine(scripture.FullScript());
        Console.WriteLine("Press enter to hide a word or type 'exit' to quit: ");

        while (!scripture.CompletelyHidden())
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                break;
            }
                
            ClearScreen();
            scripture.HideWords();
            Console.WriteLine(scripture.RenderedText());
            Console.WriteLine("Press enter to hide a word or type 'exit' to quit:");
            
        }

    }
    static void ClearScreen()
    {
        Console.Clear();
    }
}
