using System;

class ListingActivity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("listing") {}

    protected override void DoActivity()
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Pause(2);

        // Select a random prompt
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Pause(5);

        // Ask user to keep listing items until duration is reached
        int count = 0;
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.Write("Enter item: ");
            string item = Console.ReadLine();
            count++;
        }

        // Display number of items entered
        Console.WriteLine($"You listed {count} items.");
    }
}
