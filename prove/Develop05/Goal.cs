using System;
using System.Collections.Generic;
using System.IO;

public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _achievement;

    public Goal()
    {
        Console.WriteLine("What is the name of your goal? ");
        Console.Write(">> ");
        string name = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("What is the short description of it? ");
        Console.Write(">> ");
        string description = Console.ReadLine();

        int points;
        bool isValidInput = false;
        do
        {
            Console.WriteLine();
            Console.WriteLine("What is the amount of points associated with this goal? ");
            Console.Write(">> ");
            string pointsInput = Console.ReadLine();
            isValidInput = int.TryParse(pointsInput, out points);
            if (!isValidInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer value.");
            }
        } while (!isValidInput);

        _name = name;
        _description = description;
        _points = points;
        _achievement = false;
    }

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _achievement = false;
    }

    public Goal(string name, string description, int points, bool achievement)
    {
        _name = name;
        _description = description;
        _points = points;
        _achievement = achievement;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public virtual bool GetAchievement()
    {
        return _achievement;
    }

    public virtual void SetAchievement(bool achievement)
    {
        _achievement = achievement;
    }

    public virtual int completionEvent()
    {
        SetAchievement(true);
        return GetPoints();
    }

    public virtual string Display()
    {
        string type;
        if (this.GetType() == typeof(EternalGoal))
        {
            type = "Eternal: ";
        }
        else if (this.GetType() == typeof(CheckListGoal))
        {
            type = "Checklist: ";
        }
        else
        {
            type = "Simple: ";
        }
        return $"[{(GetAchievement() ? 'X' : ' ')}]{type}{_name} - ({_description}) [{_points} points]";
    }

    public virtual string Stringify()
    {
        return $"{GetType()}|*|{GetName()}|*|{GetDescription()}|*|{GetPoints()}|*|{GetAchievement()}";
    }
}
