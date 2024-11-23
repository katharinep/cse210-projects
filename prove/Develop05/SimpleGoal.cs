namespace EternalQuest
{
    public class SimpleGoal : Goal
    {  
        public SimpleGoal(string goalType, string goalName, string goalDescription, int goalPoints, bool goalCompleted)
            : base(goalType, goalName, goalDescription, goalPoints) 
            {
                GoalCompleted = goalCompleted;
            }
        

        public override string DisplayGoalInList(int number)
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

        public override bool CompleteGoal()
        {
            GoalCompleted = true;
            return GoalCompleted;
        }

        public override void RecordEvent()
        {
            if (!GoalCompleted)
            {
                CompleteGoal();
                Console.Clear();
                Console.WriteLine($"Congratulations!\nYou have earned {GoalPoints} points.");

            }
            else
            {
                Console.Clear();
                Console.WriteLine($"The goal '{GoalName}' has already been completed.");
            }
        }

        public override string SaveGoal()
        {
            return $"Simple Goal|{GoalName}|{GoalDescription}|{GoalPoints}|{GoalCompleted}";
        }

    }
}