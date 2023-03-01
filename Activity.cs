using System;
using System.Threading;

namespace MindfulnessProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("-----------------------------------\n");

            while (true)
            {
                Console.WriteLine("Please choose an activity:");
                Console.WriteLine("1. Breathing");
                Console.WriteLine("2. Reflection");
                Console.WriteLine("3. Listing");
                Console.WriteLine("4. Exit\n");

                Console.Write("Choice: ");
                int choice = int.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        BreathingActivity breathingActivity = new BreathingActivity();
                        breathingActivity.Start();
                        break;

                    case 2:
                        ReflectionActivity reflectionActivity = new ReflectionActivity();
                        reflectionActivity.Start();
                        break;

                    case 3:
                        ListingActivity listingActivity = new ListingActivity();
                        listingActivity.Start();
                        break;

                    case 4:
                        Console.WriteLine("Thank you for using the Mindfulness Program!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice! Please choose again.\n");
                        break;
                }
            }
        }
    }

    abstract class Activity
    {
        protected int duration;

        public virtual void Start()
        {
            Console.WriteLine("Starting activity...");
            Console.WriteLine($"Activity: {GetType().Name}");
            Console.WriteLine($"Duration: {duration} seconds");
            Console.WriteLine("Get ready...");
            Thread.Sleep(3000); // pause for 3 seconds
            Console.WriteLine("Begin!\n");
        }

        protected void Pause(int seconds)
        {
            for (int i = seconds; i >= 1; i--)
            {
                Console.Write(i + " ");
                Thread.Sleep(1000); // pause for 1 second
            }

            Console.WriteLine();
        }

        public virtual void Finish()
        {
            Console.WriteLine("\nGood job!");
            Console.WriteLine($"Activity: {GetType().Name}");
            Console.WriteLine($"Duration: {duration} seconds");
            Console.WriteLine("You have completed the activity.\n");
            Thread.Sleep(3000); // pause for 3 seconds
        }
    }
}
