using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

class Program
{
    static string logFilePath = "activityLog.txt";

    static void Main(string[] args)
    {
        string input = "";
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        // Load log file if it exists
        LoadLog(ref breathingCount, ref reflectingCount, ref listingCount);

        void DisplayLog()
        {
            Console.WriteLine("Activity Log - Current Session");
            Console.WriteLine($"Breathing Activity: {breathingCount}");
            Console.WriteLine($"Reflecting Activity: {reflectingCount}");
            Console.WriteLine($"Listing Activity: {listingCount}");
            Console.WriteLine();
        }

        while (input != "4")
        {
            Console.Clear();
            DisplayLog();
            Console.WriteLine("Activity Options:");
            Console.WriteLine("1. Breathing activity");
            Console.WriteLine("2. Reflecting activity");
            Console.WriteLine("3. Listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the Options: ");

            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    var breathingActivity = new BreathingActivity();
                    breathingActivity.RunActivity();
                    breathingActivity.PromptBreathing();
                    breathingActivity.EndActivity();
                    breathingCount++;
                    SaveLog(breathingCount, reflectingCount, listingCount);
                    break;

                case "2":
                    var reflectingActivity = new ReflectingActivity();
                    reflectingActivity.RunActivity();
                    reflectingActivity.PromptReflecting();
                    reflectingActivity.EndActivity();
                    reflectingCount++;
                    SaveLog(breathingCount, reflectingCount, listingCount);
                    break;

                case "3":
                    var listingActivity = new ListingActivity();
                    listingActivity.RunActivity();
                    listingActivity.PromptListing();
                    listingActivity.EndActivity();
                    listingCount++;
                    SaveLog(breathingCount, reflectingCount, listingCount);
                    break;

                case "4":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Please enter a valid menu option.");
                    break;
            }
        }
    }

    static void SaveLog(int breathing, int reflecting, int listing)
    {
        using (StreamWriter writer = new StreamWriter(logFilePath))
        {
            writer.WriteLine(breathing);
            writer.WriteLine(reflecting);
            writer.WriteLine(listing);
        }
    }

    static void LoadLog(ref int breathing, ref int reflecting, ref int listing)
    {
        if (File.Exists(logFilePath))
        {
            using (StreamReader reader = new StreamReader(logFilePath))
            {
                breathing = int.Parse(reader.ReadLine());
                reflecting = int.Parse(reader.ReadLine());
                listing = int.Parse(reader.ReadLine());
            }
        }
    }
}