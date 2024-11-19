using System;

public class Breathing : Activity
{
    //class variables//

    //constructors//
    public Breathing(int activityChoice) : base(activityChoice)
    {
    }

    //methods//
    public void BreathMessage()
    {
        //Breathing message to guide user//
        Console.Write("Breathe in...");
        Countdown();
        Console.Clear();
        Console.Write("Breathe out...");
        Countdown();
    }
    
    public void RunBreathing(int activityLength)
    {
        //Runs a breathing guidance method for the duration
        //chosen by the user//
        
        //StartMessage(1);//
        
        Console.Clear();
        Console.WriteLine("\nGet ready.");
        SleepSpinner();
        
        DateTime futureTime = DateTime.Now.AddSeconds(activityLength);

        while (DateTime.Now < futureTime)
        {
            Console.Clear();
            BreathMessage();
        }
        
        Console.WriteLine("");
        EndMessage();
    }
}