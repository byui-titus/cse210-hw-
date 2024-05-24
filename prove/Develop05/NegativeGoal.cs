public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public void Penalize()
    {
        SetAchievement(true);
        SetPoints(-Math.Abs(GetPoints()));
    }

    public override string Display()
    {
        return $"[{(GetAchievement() ? 'X' : ' ')}] Negative Goal: {GetName()} - ({GetDescription()}) [Penalty: {GetPoints()}]";
    }
}