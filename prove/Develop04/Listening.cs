public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }
    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    public void PromptListing()
    {
        string prompt = GeneratePrompt();
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine(prompt);
        Console.Write("You may begin in: ");
        GenerateCountdownTimer(5);
        Console.WriteLine();

        DateTime futureTime = GetFutureTime(GetDuration());

        while (DateTime.Now < futureTime)
        {
            Console.Write(">");
            Console.ReadLine();
        }
    }
}