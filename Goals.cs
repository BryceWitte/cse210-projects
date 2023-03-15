using System;

// Base class for all goals
public abstract class Goal {
    public string Name { get; set; }
    public int Score { get; protected set; }
    public bool IsCompleted { get; protected set; }

    public Goal(string name) {
        Name = name;
        Score = 0;
        IsCompleted = false;
    }

    // This method is called when the user records an event for this goal
    public abstract void RecordEvent();

    // This method is called when the user wants to display the goal's status
    public virtual void DisplayStatus() {
        Console.Write($"[{(IsCompleted ? "X" : " ")}] {Name}");
    }

    // This method is called when the user wants to save the goal's status to a file
    public virtual string SaveStatus() {
        return $"{Name},{Score},{IsCompleted}";
    }

    // This method is called when the user wants to load the goal's status from a file
    public virtual void LoadStatus(string[] data) {
        Name = data[0];
        Score = int.Parse(data[1]);
        IsCompleted = bool.Parse(data[2]);
    }
}
