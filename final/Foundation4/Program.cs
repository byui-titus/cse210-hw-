using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of each activity
        Running running = new Running(new DateTime(2024, 5, 27), 30, 5.0);
        Cycling cycling = new Cycling(new DateTime(2024, 5, 27), 45, 20.0);
        Swimming swimming = new Swimming(new DateTime(2024, 5, 27), 60, 40);

        // Add activities to a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Iterate through the list and display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}

