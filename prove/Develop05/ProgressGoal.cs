public class ProgressGoal : Goal
{
    private int _currentProgress;
    private int _targetProgress;

    public ProgressGoal(string name, string description, int points, int targetProgress) : base(name, description, points)
    {
        _currentProgress = 0;
        _targetProgress = targetProgress;
    }

    public void UpdateProgress(int amount)
    {
        _currentProgress += amount;
        if (_currentProgress >= _targetProgress)
        {
            SetAchievement(true);
        }
    }

    public void ResetProgress()
    {
        _currentProgress = 0;
        SetAchievement(false);
    }

    public override string Display()
    {
        return $"[{(GetAchievement() ? 'X' : ' ')}] Progress Goal: {GetName()} - ({GetDescription()}) [{_currentProgress}/{_targetProgress}]";
    }

    public override string Stringify()
    {
        return $"{base.Stringify()}|*|{_currentProgress}|*|{_targetProgress}";
    }
}