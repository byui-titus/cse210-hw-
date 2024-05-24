public class SimpleGoal : Goal
{
    // Define a default constructor that calls the base class constructor
    public SimpleGoal() : base()
    {
    }

    // Define a constructor that takes in a name, description, and points and calls the base class constructor with those values
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }
}