using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>{};
        
        Activity activity1 = new Running(DateTime.Now, 30, 2);
        activities.Add(activity1);
        Activity activity2 = new Cycling(DateTime.Now.AddDays(-1), 20, 1);
        activities.Add(activity2);
        Activity activity3 = new Swimming(DateTime.Now.AddDays(-2), 45, 30);
        activities.Add(activity3);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
        
        //Console.WriteLine(activity1.GetSummary());
        //Console.WriteLine(activity2.GetSummary());
        //Console.WriteLine(activity3.GetSummary());

    }
}