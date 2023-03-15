using System;

// Eternal goal class
public class EternalGoal : Goal {
    public int Value { get; private set; }

    public EternalGoal(string name, int value) : base(name) {
        Value = value;
    }

    public override void RecordEvent() {
        Score += Value;
    }
}
