class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");
            Console.WriteLine("Select a choice from the menu:");
            Console.Write(">> ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Select goal type:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write(">> ");
                    string goalType = Console.ReadLine();

                    Goal goal = null;
                    switch (goalType)
                    {
                        case "1":
                            goal = new SimpleGoal();
                            break;
                        case "2":
                            goal = new EternalGoal();
                            break;
                        case "3":
                            goal = new CheckListGoal();
                            break;
                        default:
                            Console.WriteLine("Invalid goal type.");
                            break;
                    }

                    if (goal != null)
                    {
                        goalManager.AddGoal(goal);
                        Console.WriteLine("Goal added successfully!");
                    }
                    break;

                case "2":
                    goalManager.DisplayGoals();
                    break;

                case "3":
                    goalManager.DisplayGoals();
                    Console.WriteLine("Enter the index of the goal to record an event for:");
                    Console.Write(">> ");
                    int goalIndex;
                    if (int.TryParse(Console.ReadLine(), out goalIndex))
                    {
                        goalManager.RecordEvent(goalIndex);
                        Console.WriteLine("Event recorded successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid index.");
                    }
                    break;

                case "4":
                    goalManager.DisplayScore();
                    break;

                case "5":
                    Console.WriteLine("Enter filename to save goals:");
                    Console.Write(">> ");
                    string saveFilename = Console.ReadLine();
                    goalManager.SaveGoals(saveFilename);
                    Console.WriteLine("Goals saved successfully!");
                    break;

                case "6":
                    Console.WriteLine("Enter filename to load goals:");
                    Console.Write(">> ");
                    string loadFilename = Console.ReadLine();
                    goalManager.LoadGoals(loadFilename);
                    Console.WriteLine("Goals loaded successfully!");
                    break;

                case "7":
                    quit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine();
        }
    }
}