public class EternalGoal : Goal
{
    public EternalGoal() : base()
    {
    }

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override bool GetCompleted()
    {
        return false;
    }

    public override void SetCompleted(bool completed)
    {
        _completed = false;
    }

    public override int completionEvent()
    {
        SetCompleted(false);
        return GetPoints();
    }
}