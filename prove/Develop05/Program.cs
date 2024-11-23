using System;

namespace EternalQuest
{
    class Program
    {
        //Extra Credit Improvements: I added a level system that moves
        //the user up one level per 100 points earned.
        //I also added a feature to ask the user if they want
        //to save to a file that is already open
        
        static int totalPoints = 0;

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Eternal Quest\n");
        
            bool program = true;
            string currentFileName = null;
            List<Goal> goals = new List<Goal>();

            while (program == true)
            {
                int level = totalPoints / 100;
                Console.WriteLine($"\nYou have {totalPoints} points.");
                Console.WriteLine($"You are at level {level}.\n");
                
                Console.WriteLine("Menu\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit\n");
                Console.Write("Select a choice from the menu: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    //Create New Goal//
                    Console.Clear();
                    Console.WriteLine("What kind of goal would you like to create?");
                    Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
                    string goal = Console.ReadLine();

                    if (goal == "1")
                    {
                        string goalType = "Simple Goal";
                        Console.Clear();
                        Console.Write("Enter goal name: ");
                        string goalName = Console.ReadLine();

                        Console.Write("Enter a short description of your goal: ");
                        string goalDescription = Console.ReadLine();

                        Console.Write("Enter the amount of points associated with the goal: ");
                        int goalPoints = int.Parse(Console.ReadLine());
                        
                        bool goalCompleted = false;
                        goals.Add(new SimpleGoal(goalType, goalName, goalDescription, goalPoints, goalCompleted));
                    }
                    else if (goal == "2")
                    {
                        string goalType = "Eternal Goal";
                        Console.Clear();
                        Console.Write("Enter goal name: ");
                        string goalName = Console.ReadLine();

                        Console.Write("Enter a short description of your goal: ");
                        string goalDescription = Console.ReadLine();

                        Console.Write("Enter the amount of points associated with the goal: ");
                        int goalPoints = int.Parse(Console.ReadLine());

                        goals.Add(new EternalGoal(goalType, goalName, goalDescription, goalPoints));
                    }
                    else if (goal == "3")
                    {
                        string goalType = "Checklist Goal";
                        Console.Clear();
                        Console.Write("Enter goal name: ");
                        string goalName = Console.ReadLine();

                        Console.Write("Enter a short description of your goal: ");
                        string goalDescription = Console.ReadLine();

                        Console.Write("Enter the amount of points associated with the goal: ");
                        int goalPoints = int.Parse(Console.ReadLine());

                        Console.Write("Enter the number of times the goal needs to be accomplished for a bonus: ");
                        int totalCount = int.Parse(Console.ReadLine());

                        Console.Write($"Enter the bonus points accomplishing the goal {totalCount} times: ");
                        int bonusPoints = int.Parse(Console.ReadLine());

                        int completedCount = 0;
                        bool goalCompleted = false;


                        goals.Add(new ChecklistGoal(goalType, goalName, goalDescription, goalPoints, goalCompleted, bonusPoints, totalCount, completedCount));    
                    } 
                }
                else if (choice == "2")
                {
                    //List Goals//
                    Console.Clear();
                    for (int i = 0; i < goals.Count; i++)
                    {
                        Console.WriteLine(goals[i].DisplayGoalInList(i + 1));
                    } 
                }
                else if (choice == "3")
                {
                    //Save Goals//
                    string fileName;
                    Console.Clear();

                    if (currentFileName != null)
                    {
                        Console.Write($"Would you like to save to the loaded file {currentFileName}? (y/n) ");
                        string response = Console.ReadLine().ToLower();

                        if (response == "y")
                        {
                            fileName = currentFileName;
                        }
                        else
                        {
                            Console.Write("What is the filename for the goal file?(.txt) ");
                            fileName = Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.Write("What is the filename for the goal file?(.txt) ");
                        fileName = Console.ReadLine();
                    }

                    List<string> lines = new List<string>
                    {
                        totalPoints.ToString()
                    };

                    lines.AddRange(goals.Select(g => g.SaveGoal()));

                    File.WriteAllLines(fileName, lines);

                    Console.WriteLine($"Goals and points saved to {fileName}.\n");
                }
                else if (choice == "4")
                {
                    //Load Goals//
                    Console.Clear();
                    Console.Write("Enter a filename to load goals: ");
                    string fileName = Console.ReadLine();
                    
                    if (File.Exists(fileName))
                    {
                        string[] lines = File.ReadAllLines(fileName);

                        totalPoints = int.Parse(lines[0]);

                        goals = lines.Skip(1).Select(Goal.LoadGoal).ToList();

                        currentFileName = fileName;
                        Console.WriteLine("Goals and points loaded successfully.\n");
                    }
                    else
                    {
                        Console.WriteLine($"An error occurred while loading file: {fileName}.");
                    }
                }
                else if (choice == "5")
                {
                    //RecordEvent//
                    Console.Clear();
                    for (int i = 0; i < goals.Count; i++)
                    {
                        Console.WriteLine(goals[i].DisplayGoalInList(i + 1));
                    } 
                    Console.Write("Enter the number of the completed goal: ");
                    int number = int.Parse(Console.ReadLine()) - 1;

                    goals[number].RecordEvent();
                    totalPoints += goals[number].GoalPoints; 
                }
                else if (choice == "6")
                {
                    program = false;
                }
                else
                {
                    Console.WriteLine("Please choose a number 1-6");
                    program = true;
                }
            }
        }
        public static void UpdatePoints(int bonusPoints)
        {
            totalPoints += bonusPoints;
        }
    }
}