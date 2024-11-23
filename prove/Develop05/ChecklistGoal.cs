namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _bonusPoints;
        private int _totalCount;
        private int _completedCount;
        public ChecklistGoal(string goalType, string goalName, string goalDescription, int goalPoints, bool goalCompleted, int bonusPoints, int totalCount, int completedCount)
            : base(goalType, goalName, goalDescription, goalPoints) 
            {
                _bonusPoints = bonusPoints;
                _totalCount = totalCount;
                _completedCount = completedCount;
                GoalCompleted = goalCompleted;  
            }
        
        public override bool CompleteGoal()
        {
            GoalCompleted = true;
            return GoalCompleted;
        }

        public override string DisplayGoalInList(int number)
        {
            if (GoalCompleted == false)
            {
                return $"{number}. [ ] {GoalName} ({GoalDescription}) -- Currently completed {_completedCount}/{_totalCount} ";
            }
            else
            {
                return $"{number}. [X] {GoalName} ({GoalDescription}) -- Currently completed {_completedCount}/{_totalCount} ";

            }
        }

        public override void RecordEvent()
        {
            Console.Clear();
            if (_completedCount < _totalCount)
            {
                _completedCount++;
                Console.WriteLine($"Congratulations!\nYou have earned {GoalPoints} points.");
                
                if (_completedCount == _totalCount)
                {
                    CompleteGoal();
                    Program.UpdatePoints(_bonusPoints);
                    Console.WriteLine($"Congratulations!\nYou earned {_bonusPoints} bonus points!");
                }
            }
            else
            {
                Console.WriteLine($"The goal '{GoalName}' has already been fully completed.");
            }
        }

        public override string SaveGoal()
        {
            //goal completed parts[4] bonus points is parts[5], total count is parts[6], and completed count is parts[7]
            return $"Checklist Goal|{GoalName}|{GoalDescription}|{GoalPoints}|{GoalCompleted}|{_bonusPoints}|{_totalCount}|{_completedCount}";
        }
    }
}