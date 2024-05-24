public class CheckListGoal : Goal
{
    private int _completionCount;
    private int _completionGoal;
    private int _bonus;

    public CheckListGoal() : base()
    {
        Console.WriteLine();
        Console.WriteLine("How many times this goal needs to be accomplished for a bonus? ");
        Console.Write(">> ");
        int completionGoal;
        while (!int.TryParse(Console.ReadLine(), out completionGoal))
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
        _completionCount = 0;
        _completionGoal = completionGoal;
    }

    public CheckListGoal(string name, string description, int points, int completionGoal, int bonus) : base(name, description, points)
    {
        _bonus = bonus;
        _completionCount = 0;
        _completionGoal = completionGoal;
    }

    public CheckListGoal(string name, string description, int points, int completionCount, int completionGoal, int bonus) : base(name, description, points)
    {
        _bonus = bonus;
        _completionCount = completionCount;
        _completionGoal = completionGoal;
    }

    public int GetCompletionCount()
    {
        return _completionCount;
    }

    public void SetCompletionCount(int completionCount)
    {
        _completionCount = completionCount;
    }

    public int GetCompletionGoal()
    {
        return _completionGoal;
    }

    public void SetCompletionGoal(int completionGoal)
    {
        _completionGoal = completionGoal;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }

    public void IncrementCompletionCount()
    {
        _completionCount += 1;
    }

    public override int completionEvent()
    {
        if (GetCompletionCount() < GetCompletionGoal())
        {
            IncrementCompletionCount();
            SetCompleted(GetCompletionCount() == GetCompletionGoal());
            if (GetCompletionCount() == GetCompletionGoal())
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
        return $"[{(GetCompleted() ? 'X' : ' ')}] Checklist: {GetName()} - ({GetDescription()}) [{GetPoints()} points] -- Currently completed: {GetCompletionCount()}/{GetCompletionGoal()}";
    }

    public override string Stringify()
    {
        return $"{GetType()}|*|{GetName()}|*|{GetDescription()}|*|{GetPoints()}|*|{GetCompleted()}|*|{GetCompletionCount()}|*|{GetCompletionGoal()}|*|{GetBonus()}";
    }
}
