public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetName("Breathing Activity");
        SetDescription("This activity will help you relax by guiding you through slow breathing exercises. Clear your mind and focus on your breathing.");
    }
    public void PromptBreathing()
    {
        DateTime futureTime = GetFutureTime(GetDuration());
        Console.WriteLine("\n\nBreathe in...");
        GenerateCountdownTimer(2);
        Console.WriteLine("Breathe out...");
        GenerateCountdownTimer(3);

        while (DateTime.Now < futureTime)
        {
            Console.WriteLine("\n\nBreathe in...");
            GenerateCountdownTimer(4);
            Console.WriteLine("Breathe out...");
            GenerateCountdownTimer(6);
        }
    }
}