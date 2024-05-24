public class GoalManager
{
    private List<Goal> _goals = new List<Goal>(); // A list to store all the goals
    private int _score; // Variable to keep track of the score

    // Method to display the current score
    public void DisplayScore()
    {
        Console.WriteLine($"Your current score is: {_score}");
    }

    // Method to add a goal to the list of goals
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    // Method to display all the goals in the list
    public void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.Display());
        }
    }

    // Method to record an event by completing a goal
    public void RecordEvent(int goalIndex)
    {
        if (goalIndex < 0 || goalIndex >= _goals.Count)
        {
            Console.WriteLine("Invalid goal index.");
            return;
        }

        Goal goal = _goals[goalIndex];
        _score += goal.completionEvent();
    }

    // Method to save the list of goals and score to a file
    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.Stringify());
            }
        }
    }

    // Method to load the list of goals and score from a file
    public void LoadGoals(string filename)
    {
        _goals.Clear();

        using (StreamReader reader = new StreamReader(filename))
        {
            _score = int.Parse(reader.ReadLine());

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(new string[] { "|*|" }, StringSplitOptions.None);
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool achievement = bool.Parse(parts[4]);

                if (type.Contains("SimpleGoal"))
                {
                    SimpleGoal goal = new SimpleGoal(name, description, points);
                    goal.SetAchievement(achievement);
                    _goals.Add(goal);
                }
                else if (type.Contains("EternalGoal"))
                {
                    EternalGoal goal = new EternalGoal(name, description, points);
                    _goals.Add(goal);
                }
                else if (type.Contains("CheckListGoal"))
                {
                    int achievementCount = int.Parse(parts[5]);
                    int achievementGoal = int.Parse(parts[6]);
                    int bonus = int.Parse(parts[7]);
                    CheckListGoal goal = new CheckListGoal(name, description, points, achievementCount, achievementGoal, bonus);
                    _goals.Add(goal);
                }
            }
        }
    }
}