namespace EternalQuest
{
    public abstract class Goal
    {
        public string GoalType {get; protected set;}
        public string GoalName {get; protected set;}
        public string GoalDescription {get; protected set;}
        public int GoalPoints {get; protected set;}
        public bool GoalCompleted {get; protected set;}

        public Goal(string goalType, string goalName, string goalDescription, int goalPoints)
        {
            GoalType = goalType;
            GoalName = goalName;
            GoalDescription = goalDescription;
            GoalPoints = goalPoints;
        }

        public virtual string DisplayGoalInList(int number)
        {
            if (GoalCompleted == true)
            {
                return $"{number}. [X] {GoalName} ({GoalDescription}) ";
            }
            else
            {
                return $"{number}. [ ] {GoalName} ({GoalDescription}) ";
            }
        }

        public virtual bool CompleteGoal()
        {
            GoalCompleted = true;
            return GoalCompleted;
        }

        public virtual void DisplayPoints()
        {
            Console.WriteLine($"You have {GoalPoints} points.");
        }

        public abstract string SaveGoal();

        public static Goal LoadGoal(string data)
        {
            string[] parts = data.Split("|");

            if (parts[0] == "Simple Goal")
            {
                return new SimpleGoal(parts[0], parts[1], parts[2], int.Parse(parts[3]), Convert.ToBoolean(parts[4]));
            }
            else if (parts[0] == "Eternal Goal")
            {
                return new EternalGoal(parts[0], parts[1], parts[2], int.Parse(parts[3]));
            }
            if (parts[0] == "Checklist Goal")
            {
                //bonus points is parts[4], total count is parts[5], and completed count is parts[6]
                return new ChecklistGoal(parts[0], parts[1], parts[2], int.Parse(parts[3]), Convert.ToBoolean(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]),int.Parse(parts[7]));
                
            }
            return null;
        }

        public abstract void RecordEvent();
    }
}