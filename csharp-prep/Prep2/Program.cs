using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        String grade = Console.ReadLine();
        int percent = int.Parse(grade);

        string letter = " ";

        if (percent >=90)
        {
            letter = "A";
        }

        else if (percent >= 80)
        {
            letter = "B";
        }

        else if (percent >= 70)
        {
            letter = "C";
        }

        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }


         // Stretch Challenge: Determine grade sign
        string sign = "";

        int lastDigit = (int) percent % 10;

        if (lastDigit >= 7 && letter != "F") // Check if grade is a "+" except for "F"
        {
            sign = "+";
        }
        else if (lastDigit < 3 || letter == "F") // Check if grade is a "-"
        {
            sign = "-";
        }

        // Check for exceptional cases A+ and F+
        if (letter == "A" && sign == "+")
        {
            sign = ""; // Reset sign to empty as there's no A+
        }
        else if (letter == "F" && sign == "+")
        {
            letter = "D"; // Change letter grade to D for F+
            sign = ""; // Reset sign to empty as there's no F+
        }
        else if (letter == "F" && sign == "-")
        {
            letter = "F"; // Keep F as it is for F-
        }

        // Display the final grade with sign
        Console.WriteLine($"Your final grade is: {letter}{sign}");
    }
}