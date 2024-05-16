
public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 15;
    }
    public void SetName(string name) => _name = name;
    public void SetDescription(string description) => _description = description;
    public void ShowDetails()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
    }
    public void AskDuration()
    {
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            _duration = duration;
        }
        else
        {
            Console.WriteLine("Invalid input. Using default duration of 15 seconds.");
        }
    }
    public int GetDuration() => _duration;
    public void RunActivity()
    {
        Console.Clear();
        ShowDetails();
        AskDuration();
        GetReady();
    }
    public void EndActivity()
    {
        Console.WriteLine("\n\nWell done!!");
        GenerateSpinner(5);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        GenerateSpinner(5);
    }
    public void GenerateSpinner(int seconds)
    {
        int spinnerPosition = Console.CursorLeft;
        char[] spinChars = new char[] { '|', '/', '-', '\\' };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            foreach (char spinChar in spinChars)
            {
                Console.CursorLeft = spinnerPosition;
                Console.Write(spinChar);
                Thread.Sleep(250);
            }
        }
        Console.CursorLeft = spinnerPosition;
        Console.Write(" ");
    }
    public void GenerateCountdownTimer(int seconds)
    {
        int timerPosition = Console.CursorLeft;
        for (int i = seconds; i >= 0; i--)
        {
            Console.CursorLeft = timerPosition;
            Console.Write(i);
            Thread.Sleep(1000);
        }
        Console.CursorLeft = timerPosition;
        Console.Write(" ");
    }
    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        GenerateSpinner(5);
    }
    public DateTime GetFutureTime(int seconds) => DateTime.Now.AddSeconds(seconds);
}