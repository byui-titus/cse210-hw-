

public class CheckListGoal : Goal
{
    private int _achievementCount;
    private int _achievementGoal;
    private int _bonus;

    public CheckListGoal() : base()
    {
        Console.WriteLine();
        Console.WriteLine("How many times this goal needs to be accomplished for a bonus? ");
        Console.Write(">> ");
        int achievementGoal;
        while (!int.TryParse(Console.ReadLine(), out achievementGoal))
        {
            Console.WriteLine("Please enter a valid integer value.");
            Console.Write(">> ");
        }
        Console.WriteLine();
        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        Console.Write(">> ");
        int bonus;
        while (!int.TryParse(Console.ReadLine(), out bonus))
        {
            Console.WriteLine("Please enter a valid integer value.");
            Console.Write(">> ");
        }

        _bonus = bonus;
        _achievementCount = 0;
        _achievementGoal = achievementGoal;
    }

    public CheckListGoal(string name, string description, int points, int achievementGoal, int bonus) : base(name, description, points)
    {
        _bonus = bonus;
        _achievementCount = 0;
        _achievementGoal = achievementGoal;
    }

    public CheckListGoal(string name, string description, int points, int achievementCount, int achievementGoal, int bonus) : base(name, description, points)
    {
        _bonus = bonus;
        _achievementCount = achievementCount;
        _achievementGoal = achievementGoal;
    }

    public int GetAchievementCount()
    {
        return _achievementCount;
    }

    public void SetAchievementCount(int achievementCount)
    {
        _achievementCount = achievementCount;
    }

    public int GetAchievementGoal()
    {
        return _achievementGoal;
    }

    public void SetAchievementGoal(int achievementGoal)
    {
        _achievementGoal = achievementGoal;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }

    public void IncrementAchievementCount()
    {
        _achievementCount += 1;
    }

    public override int completionEvent()
    {
        if (GetAchievementCount() < GetAchievementGoal())
        {
            IncrementAchievementCount();
            SetAchievement(GetAchievementCount() == GetAchievementGoal());
            if (GetAchievementCount() == GetAchievementGoal())
                return GetPoints() + GetBonus();
            else
                return GetPoints();
        }
        else
        {
            return GetPoints();
        }
    }

    public override string Display()
    {
        return $"[{(GetAchievement() ? 'X' : ' ')}] Checklist: {GetName()} - ({GetDescription()}) [{GetPoints()} points] -- Currently completed: {GetAchievementCount()}/{GetAchievementGoal()}";
    }

    public override string Stringify()
    {
        return $"{GetType()}|*|{GetName()}|*|{GetDescription()}|*|{GetPoints()}|*|{GetAchievement()}|*|{GetAchievementCount()}|*|{GetAchievementGoal()}|*|{GetBonus()}";
    }
}
