using System;

class ReflectionActivity
{
    private string[] prompts = new string[]
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = new string[]
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(int duration) : base(duration)
    {
    }

    protected override void DisplayStartingMessage()
    {
        Console.WriteLine("Reflection Activity");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
        Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine("Please enter the duration of the activity in seconds:");
        duration = Int32.Parse(Console.ReadLine());
    }

    protected override void PrepareToBegin()
    {
        Console.WriteLine("Preparing to begin in...");
        ShowCountdown(3);
    }

    protected override void Run()
    {
        Random random = new Random();

        for (int i = 0; i < duration; i++)
        {
            // Show a random prompt.
            Console.WriteLine(prompts[random.Next(prompts.Length)]);

            // Ask the user each question and pause for a moment.
            foreach (string question in questions)
            {
                Console.WriteLine(question);
                ShowSpinner(1);
            }
        }
    }

}
