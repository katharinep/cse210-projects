namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string goalType, string goalName, string goalDescription, int goalPoints)
            : base(goalType, goalName, goalDescription, goalPoints) 
            {  
            }
        
        public override string DisplayGoalInList(int number)
        {
            return $"{number}. [ ] {GoalName} ({GoalDescription}) ";
        }

        public override void RecordEvent()
        {
            Console.Clear();
            Console.WriteLine($"Congratulations!\nYou have earned {GoalPoints} points.");
        }

        public override string SaveGoal()
        {
            return $"Eternal Goal|{GoalName}|{GoalDescription}|{GoalPoints}";
        }
    }
}