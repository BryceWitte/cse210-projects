using System;

// Checklist goal class
public class ChecklistGoal : Goal {
    public int Value { get; private set; }
    public int TargetCount { get; private set; }
    public int CompletedCount { get; private set; }

    public ChecklistGoal(string name, int value, int targetCount) : base(name) {
        Value = value;
        TargetCount = targetCount;
        CompletedCount = 0;
    }

    public override void RecordEvent() {
        Score += Value;
        CompletedCount++;

        if (CompletedCount == TargetCount) {
            Score += 500;
            IsCompleted = true;
        }
    }

    public override void DisplayStatus() {
        Console.Write($"[{(IsCompleted ? "X" : " ")}] {Name} (Completed {CompletedCount}/{TargetCount} times)");
    }

    public override string SaveStatus() {
        return $"{Name},{Score},{IsCompleted},{CompletedCount}";
    }

    public override void LoadStatus(string[] data) {
        Name = data[0];
        Score = int.Parse(data[1]);
        IsCompleted = bool.Parse(data[2]);
        CompletedCount = int.Parse(data[3]);
    }
}
