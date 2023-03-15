using System;

// Simple goal class
public class SimpleGoal : Goal {
    public int Value { get; private set; }

    public SimpleGoal(string name, int value) : base(name) {
        Value = value;
    }

    public override void RecordEvent() {
        Score += Value;
        IsCompleted = true;
    }
}
